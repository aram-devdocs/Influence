# # Use a base image with C++ and CMake
# FROM gcc:latest

# # Install CMake and SFML dependencies
# RUN apt-get update && \
#     apt-get install -y cmake libsfml-dev

# # Set the working directory inside the container
# WORKDIR /app

# # Copy project files into the container
# COPY . .

# # Run the build script to compile the project with CMake
# RUN chmod +x build.sh && ./build.sh

# # Specify the command to run the application
# CMD ["./run.sh"]