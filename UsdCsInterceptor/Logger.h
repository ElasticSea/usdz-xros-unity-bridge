// Logger.h
#pragma once
#include <cstdint>

// Call lifecycle
void Begin();
void End();

// Header
void Header(const char* func);

// Arguments
void LogArgInt(const char* name, int v);
void LogArgDouble(const char* name, double v);
void LogArgString(const char* name, const char* v);
void LogArgHandle(const char* name, void* p);

// Return values
void LogReturnHandle(void* p);
void LogReturnInt(int v);
void LogReturnVoid();

// Other
void LogImmediate(const char* msg, ...);
