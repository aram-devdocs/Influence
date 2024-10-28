
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended;
using MonoGame.Extended.Entities;
using MonoGame.Extended.Screens;
using MonoGame.Extended.Tiled;
using MonoGame.Extended.ViewportAdapters;
using Client.Components;
using Client.Systems;
using Shared.Models;

namespace Client
{
    public class Engine : Game
    {
        private GraphicsDeviceManager _graphics;
        public required SpriteBatch _spriteBatch { get; set; }

        // Core components for managing the game
        public required World _world;
        public required ScreenManager _screenManager;
        public required OrthographicCamera _camera;
        public required TiledMap _map;

        public Engine()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            base.Initialize();

        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // Load the map or assets for the isometric view
            _map = Content.Load<TiledMap>("IsometricMap"); // Replace with actual map name

            // Load other assets here if needed
        }

        protected override void Update(GameTime gameTime)
        {
            base.Update(gameTime);

            // Update the ECS world
            _world.Update(gameTime);

            // Update the camera to follow the player or main entity
            UpdateCamera();
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            // Draw the ECS world
            _world.Draw(gameTime);

            base.Draw(gameTime);
        }

        private void UpdateCamera()
        {
            // Update the camera to follow the player or main entity
            int PlayerId = 1; // Replace with actual player entity ID
            var player = _world.GetEntity(PlayerId);
            var transform = player.Get<TransformComponent>();
            _camera.LookAt(transform.Position);
        }

        public void AddScreen(GameScreen screen)
        {
            _screenManager.LoadScreen(screen);
        }

        public void AddEntity(Entity _entity)
        {
            Entity entity = _world.CreateEntity();
            entity.Attach(_entity);
        }
    }
}