# Influence

Influence is a 2D isometric hack-and-slash game built with C++ and SFML.

## Setup and Run

### Prerequisites

- Docker

### Build and Run

1. **Clone the Repository (if you haven’t already):**
   ```sh
   git clone <repository-url>
   cd influence
   ```
2. **Make the Shell Scripts Executable:**
   ```sh
   chmod +x build.sh run.sh
   ```
3. **Build the Docker Image:**
   ```sh
   ./build.sh
   ```
4. **Run the Game:**
   ```sh
   ./run.sh
   ```

## Development

The `run.sh` script mounts the project directory into the Docker container. You can edit files locally, and the changes will immediately reflect in the container.

## Notes

- Ensure Docker is installed and running on your machine.
- The game runs without GUI forwarding; for GUI setup in Docker, additional configurations are necessary based on your OS.
