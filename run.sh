#!/bin/bash

# Ensure the script stops on errors
set -e

# Check if argument is provided; default to GameClient
if [ "$1" == "server" ]; then
    PROJECT="GameServer"
else
    PROJECT="GameClient"
fi

echo "Running $PROJECT..."
dotnet run --project $PROJECT

echo "$PROJECT terminated."