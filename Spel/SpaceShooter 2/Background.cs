 using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brawl
{
    class Background
    {
        Texture2D texture;
        public Background(Texture2D texture, GameWindow window)
        {
            this.texture = texture;
        }

        public void Draw(SpriteBatch spriteBatch)
        {

            spriteBatch.Draw(texture, new Rectangle(0, 0, 800, 480), Color.White);
        }
    }
}
