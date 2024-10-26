# ui/CMakeLists.txt

# Add ui library
add_library(ui src/ui.cpp)

# Include path to SFML headers
target_include_directories(ui PUBLIC ../include /usr/local/include)

# Link SFML libraries
target_link_libraries(ui sfml-graphics sfml-window sfml-system)
