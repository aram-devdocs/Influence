#!/bin/bash

# Ensure the script stops on errors
set -e

# Step 1: Restore NuGet packages
echo "Restoring NuGet packages..."
dotnet restore

# Step 2: Build the project
echo "Building the solution..."
dotnet build

# Step 3: Set up any required environment variables
# Example environment variables (customize as needed)
echo "Setting up environment variables..."
export GAME_ENVIRONMENT="development"
export GAME_SERVER_PORT=8080

# Step 4: Initial asset preparation (if applicable)
# For example, pre-processing assets, generating shaders, etc.
# Uncomment and modify the line below if asset preparation is needed
# echo "Preparing game assets..."
# ./prepare_assets.sh

echo "Initialization complete! You can now use ./run.sh or ./dev.sh to start the game."