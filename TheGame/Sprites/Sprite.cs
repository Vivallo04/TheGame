using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace TheGame.Sprites
{
    public class Sprite
    {
        protected KeyboardState _currentKey;
        protected KeyboardState _previousKey;
        protected Texture2D _texture;
        protected float _rotation;

        public Vector2 Origin; 
        public Vector2 _playerPosition; 
        public Color Color = Color.White;
        public float speed = 0f;
        public int LifeSpan;
        public bool isRemoved = false;

        public Sprite(Texture2D texture)
        {
            _texture = texture;
        }

        public Rectangle Rectangle
        {
            get
            {
                if (_texture != null)
                {
                    return new Rectangle((int)_playerPosition.X, (int) _playerPosition.Y, _texture.Width, _texture.Height); 
                }
                throw new Exception("Unknown Sprite");
            }
        }

        public virtual void Update(GameTime gameTime, List<Sprite> sprite)
        {
            
        }
        
        public virtual void Draw(SpriteBatch spriteBatch)
        {
            if (_texture != null)
            {
                spriteBatch.Draw(_texture, _playerPosition, null,
                    Color.White, _rotation, Origin, 1, SpriteEffects.None, 0);
            }
        }
    }
}