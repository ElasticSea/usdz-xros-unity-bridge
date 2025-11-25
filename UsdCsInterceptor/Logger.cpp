// Logger.cpp
#include "Logger.h"

#include <windows.h>
#include <cstdio>
#include <cstdarg>
#include <unordered_map>
#include <share.h>   // for _fsopen
#include "LoggerConfig.h"

// Globals
static FILE* g_log = nullptr;
static LARGE_INTEGER g_qpf{};
static uint64_t g_seq = 0;

// pointer -> handle ID map
static std::unordered_map<void*, uint64_t> g_ptrToId;
static uint64_t g_nextId = 1;

// track args formatting
static bool g_firstArgInCall = true;

// ------------------ internal helpers ------------------

static uint64_t PtrToId(void* p)
{
	if (!p) return 0;
	auto it = g_ptrToId.find(p);
	if (it != g_ptrToId.end())
		return it->second;

	uint64_t id = g_nextId++;
	g_ptrToId[p] = id;
	return id;
}

uint64_t LogNowNs()
{
	return (uint64_t)GetTickCount64() * 1000000ULL;
}

uint64_t LogNextSeq()
{
	return ++g_seq;
}

static void LogArgPrefix()
{
	if (g_firstArgInCall)
	{
		fprintf(g_log, "\n\t\"args\": [");
		fprintf(g_log, "\n");
		g_firstArgInCall = false;
	}
	else
	{
		fprintf(g_log, ",\n");
	}
}

FILE* Logger_GetFile()
{
	return g_log;
}

// ------------------ public API ------------------

void Init()
{
	if (g_log) return; // already init

	g_log = _fsopen(LOG_PATH, "w", _SH_DENYWR);
	if (!g_log) return;

	static char buffer[1024 * 1024];               // 1 MB buffer
	setvbuf(g_log, buffer, _IOFBF, sizeof(buffer)); // full buffering
}

void Shutdown()
{
	if (!g_log) return;
	fflush(g_log);
	fclose(g_log);
	g_log = nullptr;
}

void Header(const char* func)
{
	uint64_t time = LogNowNs();
	uint64_t seq = LogNextSeq();

	g_firstArgInCall = true;
	fprintf(g_log,
		"{\n\t\"seq\": %llu,\n\t\"func\": \"%s\",\n\t\"time\": %llu,",
		(unsigned long long)seq,
		func,
		(unsigned long long)time
	);
}

void LogArgBool(const char* name, bool v)
{
	LogArgPrefix();
	fprintf(g_log, "\t\t{\"%s\": %s}", name, v ? "true" : "false");
}

void LogArgInt(const char* name, int v)
{
	LogArgPrefix();
	fprintf(g_log, "\t\t{\"%s\": %d}", name, v);
}

void LogArgUInt(const char* name, unsigned int v)
{
	LogArgPrefix();
	fprintf(g_log, "\t\t{\"%s\": %u}", name, v);
}

void LogArgFloat(const char* name, float v)
{
	LogArgPrefix();
	fprintf(g_log, "\t\t{\"%s\": %.9g}", name, v);
}

void LogArgDouble(const char* name, double v)
{
	LogArgPrefix();
	fprintf(g_log, "\t\t{\"%s\": %.17g}", name, v);
}

void LogArgString(const char* name, const char* v)
{
	LogArgPrefix();
	if (v)
		fprintf(g_log, "\t\t{\"%s\": \"%s\"}", name, v);
	else
		fprintf(g_log, "\t\t{\"%s\": null}", name);
}

void LogArgPtr(const char* name, void* p) {
	uint32_t id = PtrToId(p);
	LogArgPrefix();
	fprintf(g_log, "\t\t{\"%s\": %u}", name, id);
}

void LogArgEnd()
{
	if (g_firstArgInCall) {
		fprintf(g_log, "\n"); // no args case
	}
	else {
		fprintf(g_log, "\n\t],\n");
	}
}

void LogEnd()
{
	fprintf(g_log, "},\n");
}

void LogReturnHandle(void* p)
{
	uint32_t id = PtrToId(p);

	LogArgEnd();

	fprintf(g_log,
		"\t\"return\": {\"handle\": %u},\n",
		id
	);
	LogEnd();
}

void LogReturnBool(bool v) { LogReturnInt(v ? 1 : 0); }
void LogReturnUInt(unsigned v) { LogReturnInt((int)v); }

void LogReturnInt(int v)
{
	LogArgEnd();
	fprintf(g_log,
		"\t\"return\": {\"int\": %d},\n",
		v
	);
	LogEnd();
}

void LogReturnCStr(const char* v)
{
	LogArgEnd();
	if (v)
		fprintf(g_log, "\t\"return\": {\"string\": \"%s\"},\n", v);
	else
		fprintf(g_log, "\t\"return\": {\"string\": null},\n");
	LogEnd();
}

void LogReturnVoid()
{
	LogArgEnd();
	LogEnd();
}

void LogRaw(const char* msg, ...) {
	va_list args;
	va_start(args, msg);
	vfprintf(g_log, msg, args);
	va_end(args);
}
