﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brawl
{
    class BackgroundSprite : GameObject
    {
        public BackgroundSprite(Texture2D texture, float X, float Y) : base(texture , X, Y)
        {

        }

        public void Update(GameWindow window, int nrBackgroundsX)
        {
            vector.X += 0f;
            if(vector.X > window.ClientBounds.Width)
            {
                vector.X = vector.X - nrBackgroundsX * texture.Width;
            }
        }


    }
}
