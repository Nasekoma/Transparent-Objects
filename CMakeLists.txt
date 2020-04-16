cmake_minimum_required(VERSION 2.8)
project(ALCHEMYgraph)

set(CMAKE_CXX_STANDARD 14)

find_package(OpenGL REQUIRED)

include_directories(
        ../Transparent-Objects-tmp
)

include_directories(${OPENGL_INCLUDE_DIRS})

add_executable(ALCHEMYgraph main.cpp)

target_link_libraries(ALCHEMYgraph ${OPENGL_LIBRARIES} glfw  ${OpenGlLinkers} ${CMAKE_SOURCE_DIR}/SOIL.lib)
