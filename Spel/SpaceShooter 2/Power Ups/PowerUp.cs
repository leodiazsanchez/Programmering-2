﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brawl
{
    abstract class PowerUp: PhysicalObject
    {
        protected double timeToDie;

        public PowerUp(Texture2D texture, float X, float Y, float speedY, GameTime gameTime) : base(texture, X, Y, 0, 0)
        {
            timeToDie = gameTime.TotalGameTime.TotalMilliseconds + 10000;

        }

        abstract public void Update(GameWindow window, GameTime gameTime);

      
    }
}
