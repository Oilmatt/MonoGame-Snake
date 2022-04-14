using Microsoft.Xna.Framework.Graphics;

namespace Stuff
{
    public class SpriteSheetGrid
    {
        public Texture2D Texture { get; private set; }
        public int Rows { get; private set; }
        public int Columns { get; private set; }
        public int SheetHeight { get; private set; }
        public int SheetWidth { get; private set; }

        public float RowHeight { get; private set; }
        public float ColumnWidth { get; private set; }

        public SpriteSheetGrid(Texture2D texture, int rows, int columns)
        {
            Texture = texture;
            Rows = rows;
            Columns = columns;
            SheetHeight = Texture.Height;
            SheetWidth = Texture.Width;
            RowHeight = SheetHeight / rows;
            ColumnWidth = SheetWidth / columns;
        }

        public float XPosition(int row)
        {
            return (row - 1) * RowHeight;
        }

        public float YPosition(int column)
        {
            return (column - 1) * ColumnWidth;
        }
    }
}