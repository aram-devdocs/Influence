#!/bin/bash

# Create a build directory if it doesn't exist
mkdir -p build
cd build

# Run CMake to configure and build the project
cmake ..
make