using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Asteroids
{
    class Player
    {
        public Vector2 PlayerPos;
        public Vector2 Speed;


        private Texture2D playerText;
        private Rectangle playerRect;

        public Player(Vector2 location, Vector2 speed)
        {
            PlayerPos = location;
            Speed = speed;
        }

        public void LoadContent(ContentManager Content)
        {
            playerText = Content.Load<Texture2D>("player");
        }

        public void Update(GameTime gameTime)
        {
            KeyboardState keyState = Keyboard.GetState();

            if(keyState.IsKeyDown(Keys.W))
            {
                PlayerPos.Y -= Speed.Y;
            }
            if (keyState.IsKeyDown(Keys.A))
            {
                PlayerPos.X -= Speed.X;
            }
            if (keyState.IsKeyDown(Keys.S))
            {
                PlayerPos.Y += Speed.Y;
            }
            if (keyState.IsKeyDown(Keys.D))
            {
                PlayerPos.X += Speed.X;
            }

            playerRect = new Rectangle((int)PlayerPos.X, (int)PlayerPos.Y, 64, 128);

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(playerText, playerRect, Color.White);
        }
    }
}
