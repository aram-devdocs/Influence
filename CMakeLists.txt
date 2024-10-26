# CMakeLists.txt (Root)

cmake_minimum_required(VERSION 3.10)
project(Influence)

set(CMAKE_CXX_STANDARD 17)

find_package(SFML 2.5 COMPONENTS graphics REQUIRED)


# Add subdirectories for each module
add_subdirectory(engine)
add_subdirectory(ui)
add_subdirectory(game)