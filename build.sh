#!/bin/bash

# Ensure the script stops on errors
set -e

# Clean and build the solution
echo "Cleaning and building the solution..."
dotnet clean
dotnet build

echo "Build completed successfully!"