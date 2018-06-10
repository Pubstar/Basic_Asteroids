using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Asteroids
{
    class Spaceship  {

        public string Name;
        public int Health;
        public Texture2D ShipSprite;

        private Rectangle ShipRect;


        public Spaceship (string name, int health)
        {
            this.Name = name;
            this.Health = health;
           
        }

        public void LoadContent(ContentManager Content)
        {
            ShipSprite = Content.Load<Texture2D>("alienspaceship");
            ShipRect = new Rectangle(30, 30, 64, 128);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(ShipSprite, ShipRect, Color.White);
        }
        
    }

}
