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

        public void Update(GameWindow window, GameTime gameTime, ContentManager content)
        {
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            //spriteBatch.Draw(texture, vector, new Rectangle((int)X, (int)Y, (int)Width, (int)Height), Color.Orange, 0f, new Vector2(0, 0), 1f, SpriteEffects.None, 0f);
            spriteBatch.Draw(texture, vector, Color.White);

        }


    }
}
