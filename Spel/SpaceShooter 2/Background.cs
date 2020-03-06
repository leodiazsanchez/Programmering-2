 using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShooter2
{
    class Background
    {
        BackgroundSprite[,] background;
        int nrBackgroundsX, nrBackgroundsY;

        public Background(Texture2D texture, GameWindow window)
        {
            double tmpX = (double)window.ClientBounds.Width / texture.Width;
            nrBackgroundsX = (int)Math.Ceiling(tmpX) + 1;
            double tmpY = (double)window.ClientBounds.Width / texture.Height;
            nrBackgroundsY = (int)Math.Ceiling(tmpY);
            background = new BackgroundSprite[nrBackgroundsX, nrBackgroundsY];
            for (int i = 0; i < nrBackgroundsX; i++)
            {
                for (int j = 0; j < nrBackgroundsY; j++)
                {
                    int posX = i * texture.Width - texture.Width;
                    int posY = j * texture.Height - 300;
                    background[i, j] = new BackgroundSprite(texture, posX, posY);
                }
            }
        }

        public void Update(GameWindow window)
        {
            for (int i = 0; i < nrBackgroundsX; i++)
            {
                for (int j = 0; j < nrBackgroundsY; j++)
                {
                    background[i, j].Update(window, nrBackgroundsY);
                }
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            for (int i = 0; i < nrBackgroundsX; i++)
            {
                for (int j = 0; j < nrBackgroundsY; j++)
                {
                    background[i, j].Draw(spriteBatch);
                }
            }
        }
    }
}
