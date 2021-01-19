using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using TheGame.Models;
using TheGame.Sprites;


namespace TheGame.Sprites
{
    public class Player: Sprite
    {
        public bool HasDied = false;

        public Player(Texture2D texture) : base(texture)
        {
            _playerPosition = new Vector2(30, 40);
            speed = 5f; 
        }

        
        public override void Update(GameTime gameTime, List<Sprite> missing_name)
        {
            Move(); 
        }

        public void Move()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.W))
            {
                _playerPosition.Y -= 2; 
            }
            if (Keyboard.GetState().IsKeyDown(Keys.S))
            {
                _playerPosition.Y += 2; 
            }
            if (Keyboard.GetState().IsKeyDown(Keys.D))
            {
                _playerPosition.X += 2; 
            }
            if (Keyboard.GetState().IsKeyDown(Keys.A))
            {
                _playerPosition.X -= 2; 
            }
        }
    }
}