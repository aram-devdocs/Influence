using Microsoft.Xna.Framework;
using MonoGame.Extended.Entities;
using MonoGame.Extended.Entities.Systems;
using Client.Components;

namespace Client.Systems
{
    public class MovementSystem : EntityUpdateSystem
    {
        public MovementSystem() : base(Aspect.All(typeof(TransformComponent)))
        {
        }

        public override void Initialize(IComponentMapperService mapperService)
        {
            throw new NotImplementedException();
        }

        public override void Update(GameTime gameTime)
        {
            foreach (var entity in ActiveEntities)
            {

                // Update the entity's position
            }
        }
    }
}