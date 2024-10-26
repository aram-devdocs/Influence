#!/bin/zsh

echo "Running Influence in Docker..."
docker run --rm -it -v "$(pwd)":/usr/src/influence influence
echo "Run complete."