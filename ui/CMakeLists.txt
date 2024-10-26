# ui/CMakeLists.txt

# Add ui library
add_library(ui src/ui.cpp)

# Include path to SFML headers
target_include_directories(ui PUBLIC ../include /usr/local/include)

# Link SFML libraries (adjust the path if SFML is in a different location)
find_package(SFML 2.5 COMPONENTS graphics window system REQUIRED)
target_link_libraries(ui engine sfml-graphics sfml-window sfml-system)