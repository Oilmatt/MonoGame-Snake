using Microsoft.Xna.Framework
using Microsoft.Xna.Framework.Graphics;

namespace Stuff
{
    public class SnakePart
    {
        public int DrawOrder { get; private set; }
        public Sprite Sprite { get; private set; }
        public Vector2 Position { get; private set; }

        public SnakePart(int drawOrder, Sprite sprite)
        {
            DrawOrder = drawOrder;
            Sprite = sprite;
            Position = new Vector2(0, 0);
        }

        public void Update(GameTime gameTime, Vector2 newPosition)
        {
            Position = newPosition;
        }

        public void Draw(SpriteBatch spriteBatch, GameTime gameTime)
        {
            Sprite.Draw(spriteBatch, Position);
        }
    }
}