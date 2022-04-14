using System.Collections.Generic;
using Microsoft.Xna.Framework;

namespace Stuff
{
    /// <summary>
    /// Snake class
    /// </summary>
    public class Snake : SnakePart

    {
        public Point HeadPosition { get; private set; }
        public Point TailPosition { get; private set; }
        public bool IsAlive { get; private set; }
        public int Length { get; private set; }
        public SnakeDirection CurrentDirection { get; private set; }
        public SnakeDirection NewDirection { get; private set; }
        public List<SnakePart> SnakeParts { get; private set; }
        public int StartPositionX { get; private set; }
        public int StartPositionY { get; private set; }
        public int StartLength { get; private set; }
        
        
    }
}