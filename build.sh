#!/bin/zsh

echo "Building Docker image for Influence..."
docker build -t influence .
echo "Build complete."