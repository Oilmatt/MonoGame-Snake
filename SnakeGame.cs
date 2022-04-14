using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Stuff;

namespace MonoGame_Snake
{
    public class SnakeGame : Game
    {
        public const string AssetNameSpritesheet = "snake-graphics";

        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private Texture2D _spriteSheetTexture;
        private SpriteSheetGrid _spriteSheetGrid;
        
        private Snake _snake;

        public SnakeGame()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(_graphics.GraphicsDevice);
            _spriteSheetTexture = Content.Load<Texture2D>(AssetNameSpritesheet);
            _spriteSheetGrid = new SpriteSheetGrid(_spriteSheetTexture,4,5);

            _snake = new Snake();
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed ||
                Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            _graphics.GraphicsDevice.Clear(Color.CornflowerBlue);
            
            _spriteBatch.Begin();
            
            _spriteBatch.Draw(_spriteSheetTexture, new Vector2(0,0), Color.White);
            
            _spriteBatch.End();
            
            base.Draw(gameTime);
        }
    }
}