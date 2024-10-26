# CMakeLists.txt (Root)

cmake_minimum_required(VERSION 3.10)
project(YourGame)

set(CMAKE_CXX_STANDARD 17)

# Add subdirectories for each module
add_subdirectory(engine)
add_subdirectory(ui)
add_subdirectory(game)