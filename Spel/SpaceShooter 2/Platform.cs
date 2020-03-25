using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brawl
{
    class Platform : PhysicalObject
    {
        public Platform(Texture2D texture, float X, float Y, float speedX, float speedY) : base (texture, X, Y, speedX, speedY)
        {

        }

        public Platform GeneratePlatform(int start, int end, int height)
        {
            Platform p = new Platform(texture,start,Y,0f,0f);
            for (int i = start; i < end; i += texture.Width)
            {
                p = new Platform(texture, start, 480 - height, 0f, 0f);
            }
            return p;

        }

        public bool CheckHitbox(PhysicalObject other)
        {
            Rectangle myrectangle = new Rectangle(Convert.ToInt32(X), Convert.ToInt32(Y), Convert.ToInt32(Width), Convert.ToInt32(Height));
            Rectangle otherrectangle = new Rectangle(Convert.ToInt32(other.X), Convert.ToInt32(other.Y+17), Convert.ToInt32(other.Width), Convert.ToInt32(other.Height));
            return myrectangle.Intersects(otherrectangle);
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
