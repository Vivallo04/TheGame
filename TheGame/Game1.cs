using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using TheGame.Models;
using TheGame.Sprites;

namespace TheGame
{
    public class Game1 : Game
    {
        private Texture2D _playerTexture;
        private Vector2 _playerPosition;
        private List<Sprite> _sprites;
        
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        public Vector2 Position;
        public Texture2D _Texture;
        public static int ScreenWidth = 1280;
        public static int ScreenHeight = 720; 

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;

            ScreenWidth = _graphics.PreferredBackBufferWidth;
            ScreenHeight = _graphics.PreferredBackBufferHeight;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            _playerTexture = Content.Load<Texture2D>("Player");
            _playerPosition = new Vector2(0, 0);
        }

        protected override void Update(GameTime gameTime)
        {
            // TODO: Add your update logic here
            foreach (var sprite in _sprites)
            {
                sprite.Update(gameTime, _sprites);
            }
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);
            
            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            foreach (var sprite in _sprites)
            {
                sprite.Draw(_spriteBatch);
            }
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}