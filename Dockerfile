# Dockerfile for Influence

# Use Ubuntu as the base image
FROM ubuntu:latest

# Install dependencies
RUN apt-get update && \
    apt-get install -y \
    build-essential \
    cmake \
    libsfml-dev \
    && rm -rf /var/lib/apt/lists/*

# Set the working directory
WORKDIR /usr/src/influence

# Copy the project files into the Docker container
COPY . .

# Run CMake to configure and build the project
RUN mkdir -p build && cd build && \
    cmake .. && \
    make

# Set the default command to execute the built game
CMD ["./build/game/Influence"]