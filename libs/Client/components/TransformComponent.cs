// Client/Components/TransformComponent.cs
using Microsoft.Xna.Framework;

namespace Client.Components
{
    public class TransformComponent
    {
        public Vector2 Position { get; set; }

        public TransformComponent(int x, int y)
        {
            Position = new Vector2(x, y);
        }
    }
}