# Influence

Influence is a 3D polygon-based hack-and-slash game, developed in C# using MonoGame and MonoGame.Extended. This project is built with modularity in mind, using a monorepo-style structure inspired by Nx for separation of concerns between the game client, server, and shared libraries.

## Project Structure

This project is organized as a .NET solution with separate libraries to promote modularity and maintainability.

```
Influence/
├── GameClient/            # Client app for running the game
│   ├── GameClient.csproj
│   └── Program.cs
├── GameServer/            # Server app for handling game logic and networking
│   ├── GameServer.csproj
│   └── Program.cs
└── libs/                  # Shared and specific libraries
    ├── Shared/            # Shared models and logic used by both client and server
    │   ├── Shared.csproj
    │   └── Models/        # Game models (e.g., Player, NPC, Item)
    ├── Client/            # Client-specific code (UI, rendering)
    │   └── Client.csproj
    └── Server/            # Server-specific code (networking, game logic)
        └── Server.csproj
```

## Project Components

- **GameClient**: The client-side application that runs the game, handling rendering, input, and UI.
- **GameServer**: The server application that manages game state, server-side logic, and player interactions.
- **libs/Shared**: Contains shared models and logic used across both client and server, promoting code reuse and consistency.
- **libs/Client**: Client-specific logic, such as rendering components and UI.
- **libs/Server**: Server-specific logic, including networking and game logic components.

## Prerequisites

- **.NET 6 or later**: Download .NET from [https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/download)
- **MonoGame**: Install MonoGame from [https://www.monogame.net/downloads/](https://www.monogame.net/downloads/)
- **Optional - Visual Studio / VS Code**: For a full-featured development environment.

## Getting Started

1. **Clone the Repository**
    ```sh
    git clone https://github.com/your-username/Influence.git
    cd Influence
    ```
2. **Restore NuGet Packages**
    ```sh
    dotnet restore
    ```
3. **Build the Solution**
    ```sh
    dotnet build
    ```
4. **Run the Client**
    ```sh
    dotnet run --project GameClient
    ```
5. **Run the Server**
    ```sh
    dotnet run --project GameServer
    ```

## Features

- **Modular Design**: Inspired by the Nx monorepo structure, allowing for easy separation and scalability of game components.
- **Entity Component System (ECS)**: Uses MonoGame.Extended’s ECS for clean, modular entity management.
- **Networking (WIP)**: GameServer handles networking, allowing GameClient instances to connect and sync data.
- **3D Rendering**: Polygon-based 3D rendering for hack-and-slash gameplay, with expansion planned for complex AI and NPC behaviors.

## Future Plans

- **Town Building**: Allow players to build and upgrade their town.
- **NPC AI and Scheduling**: NPCs with behavior trees, unique schedules, and interactions.
- **Multiplayer Support**: Expanding server functionality for multiplayer gameplay.
- **Custom Game Engine Features**: Integrate additional rendering, physics, and sound systems as the game develops.

## Contributing

Contributions are welcome! Please open an issue to discuss any feature requests or bug reports before making a pull request.

1. **Fork the repository**
2. **Create your feature branch** (`git checkout -b feature/NewFeature`)
3. **Commit your changes** (`git commit -m 'Add new feature'`)
4. **Push to the branch** (`git push origin feature/NewFeature`)
5. **Open a pull request**

## License

This project is licensed under the MIT License. See the LICENSE file for details.