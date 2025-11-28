cmake_minimum_required(VERSION 3.20)
project(UsdCsWrapper LANGUAGES CXX)

# USD root
set(USD_ROOT "" CACHE PATH "Path to USD build root")

set(CMAKE_CXX_STANDARD 17)
set(CMAKE_CXX_STANDARD_REQUIRED ON)

include_directories("${USD_ROOT}/include")
link_directories("${USD_ROOT}/lib")

# Collect all sources from src/
file(GLOB_RECURSE USDC_WRAPPER_SOURCES
    CONFIGURE_DEPENDS
    "${CMAKE_CURRENT_SOURCE_DIR}/src/*.cpp"
    "${CMAKE_CURRENT_SOURCE_DIR}/src/*.c"
)

# ------------------------------------------------------------------
# 1. STATIC on XROS / iOS, SHARED everywhere else
# ------------------------------------------------------------------

if (CMAKE_SYSTEM_NAME STREQUAL "XROS" OR CMAKE_OSX_SYSROOT MATCHES "xros")
    message(STATUS "Building STATIC UsdCs for visionOS/XROS")
    add_library(UsdCs STATIC ${USDC_WRAPPER_SOURCES})
else()
    message(STATUS "Building SHARED UsdCs for desktop")
    add_library(UsdCs SHARED ${USDC_WRAPPER_SOURCES})
endif()

# ------------------------------------------------------------------
# 2. Correct monolithic USD lib: usd_ms (desktop), usd_m (XROS)
# ------------------------------------------------------------------

if (CMAKE_SYSTEM_NAME STREQUAL "XROS" OR CMAKE_OSX_SYSROOT MATCHES "xros")
    message(STATUS "Linking against monolithic static usd_m for visionOS/XROS")
    set(USD_MONOLITHIC_LIB usd_m)
else()
    message(STATUS "Linking against monolithic shared usd_ms for desktop")
    set(USD_MONOLITHIC_LIB usd_ms)
endif()

target_link_libraries(UsdCs PRIVATE ${USD_MONOLITHIC_LIB})

# ------------------------------------------------------------------
# 3. Naming / compiler flags
# ------------------------------------------------------------------

set_target_properties(UsdCs PROPERTIES
    OUTPUT_NAME "UsdCs"
)

if (MSVC)
    target_compile_definitions(UsdCs PRIVATE
        NOMINMAX
        _CRT_SECURE_NO_WARNINGS
    )
    target_compile_options(UsdCs PRIVATE /MP /EHsc)
endif()
