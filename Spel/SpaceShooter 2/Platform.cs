using ExGame;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShooter2
{
    class Platform : PhysicalObject
    {
        public Platform(Texture2D texture, float X, float Y, float speedX, float speedY) : base (texture, X, Y, speedX, speedY)
        {

        }

        public void Update(GameWindow window, GameTime gameTime, ContentManager content)
        {


        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, new Vector2(X, Y), Color.White);
        }


    }
}
