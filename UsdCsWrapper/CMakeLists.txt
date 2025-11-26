cmake_minimum_required(VERSION 3.20)
project(UsdCsWrapper LANGUAGES CXX)

set(USD_ROOT "" CACHE PATH "Path to USD build root")

set(CMAKE_CXX_STANDARD 17)
set(CMAKE_CXX_STANDARD_REQUIRED ON)

include_directories("${USD_ROOT}/include")
link_directories("${USD_ROOT}/lib")

add_library(UsdCs SHARED
    src/UsdCsWrapper.cpp
)

target_link_libraries(UsdCs
    usd_ms
)

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
