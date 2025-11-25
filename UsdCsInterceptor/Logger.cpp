// Logger.cpp
#include "Logger.h"

#include <windows.h>
#include <cstdio>
#include <cstdarg>
#include <unordered_map>
#include <share.h>   // for _fsopen
#include "LoggerConfig.h"

// Globals
static LARGE_INTEGER g_qpf{};
static uint64_t g_seq = 0;
static FILE* openedFile;

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
		fprintf(openedFile, "\n");
		g_firstArgInCall = false;
	}
	else
	{
		fprintf(openedFile, ",\n");
	}
}

// ------------------ public API ------------------

void Begin()
{
	g_firstArgInCall = true;

	openedFile = _fsopen(LOG_PATH, "a", _SH_DENYWR);
	if (!openedFile)
		return;
}

void Header(const char* func)
{
	uint64_t time = LogNowNs();
	uint64_t seq = LogNextSeq();

	fprintf(openedFile,
		"{ \"seq\": %llu, \"func\": \"%s\", \"time\": %llu,\n  \"args\": [",
		(unsigned long long)seq,
		func,
		(unsigned long long)time
	);
}

void LogArgInt(const char* name, int v)
{
	LogArgPrefix();
	fprintf(openedFile, "    {\"%s\": %d}", name, v);
}

void LogArgDouble(const char* name, double v)
{
	LogArgPrefix();
	fprintf(openedFile, "    {\"%s\": %.17g}", name, v);
}

void LogArgString(const char* name, const char* v)
{
	LogArgPrefix();
	fprintf(openedFile, "    {\"%s\": \"%s\"}", name, v ? v : "");
	// NOTE: no escaping; OK for internal logs
}

void LogArgHandle(const char* name, void* p)
{
	uint32_t id = PtrToId(p);
	LogArgPrefix();
	fprintf(openedFile, "    {\"%s\": %u}", name, id);
}

void LogReturnHandle(void* p)
{
	uint32_t id = PtrToId(p);

	if (g_firstArgInCall)
		fprintf(openedFile, "\n"); // no args case
	else
		fprintf(openedFile, "\n");

	fprintf(openedFile,
		"  ],\n"
		"  \"return\": {\"handle\": %u},\n",
		id
	);
}

void LogReturnInt(int v)
{
	if (g_firstArgInCall)
		fprintf(openedFile, "\n");
	else
		fprintf(openedFile, "\n");

	fprintf(openedFile,
		"  ],\n"
		"  \"return\": {\"int\": %d},\n",
		v
	);
}

void LogReturnVoid()
{
	if (g_firstArgInCall)
		fprintf(openedFile, "\n"); // no args case
	else
		fprintf(openedFile, "\n");

	fprintf(openedFile,
		"  ],\n"
	);
}

void End()
{
	fflush(openedFile);
	fclose(openedFile);
	openedFile = nullptr;
}

void LogImmediate(const char* msg, ...) {
	Begin();

	va_list args;
	va_start(args, msg);
	vfprintf(openedFile, msg, args);
	va_end(args);

	End();
}
