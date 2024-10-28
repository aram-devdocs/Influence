#!/bin/bash

# Ensure the script stops on errors
set -e

# Check if argument is provided; default to GameClient
if [ "$1" == "server" ]; then
    PROJECT="GameServer"
else
    PROJECT="GameClient"
fi

echo "Starting development mode for $PROJECT with file watching..."
dotnet watch --project $PROJECT run

echo "$PROJECT development mode terminated."