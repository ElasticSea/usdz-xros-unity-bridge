// Logger.h
#pragma once
#include <cstdint>

// Lifecycle
void Init();
void Shutdown();

// Header
void Header(const char* func);

// Arguments
void LogArgPtr(const char* name, void* p);
void LogArgBool(const char* name, bool v);
void LogArgInt(const char* name, int v);
void LogArgUInt(const char* name, unsigned int v);
void LogArgFloat(const char* name, float v);
void LogArgDouble(const char* name, double v);
void LogArgString(const char* name, const char* v);

// Return values
void LogReturnVoid();
void LogReturnBool(bool v);
void LogReturnUInt(unsigned v);
void LogReturnHandle(void* p);
void LogReturnInt(int v);
void LogReturnCStr(const char* v);

// Other
void LogRaw(const char* msg, ...);
