using System;
using System.Net.Mime;
using System.Runtime.Intrinsics.X86;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Stuff
{
    
    /// <summary>
    /// alisdjbdflasidjbf 
    /// </summary>
    public class Sprite
    {
        public Texture2D Texture { get; private set; }
        public GraphicsDevice GraphicsDevice { get; private set; }
        public SpriteSheetGrid SpriteSheetGrid { get; private set; }
        public int Row { get; private set; }
        public int Column { get; private set; }

        public Sprite(Texture2D texture, SpriteSheetGrid spriteSheetGrid,int row, int column)
        {
            SpriteSheetGrid = spriteSheetGrid;
            Row = row;
            Column = column;
            Texture = texture
        }

        public void Draw(SpriteBatch spriteBatch, Vector2 position)
        {
            spriteBatch.Draw(Texture, position, new Rectangle(), TintColor);
        }
        
    }
}