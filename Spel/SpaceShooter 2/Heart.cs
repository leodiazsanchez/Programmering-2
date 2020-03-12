using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExGame
{
    class Heart : PhysicalObject
    {
        double timeToDie;


        public Heart(Texture2D texture, float X, float Y, GameTime gameTime) : base(texture, X, Y, 0, 2f)
        {
            timeToDie = gameTime.TotalGameTime.TotalMilliseconds + 10000;
        }


        public void Update(GameTime gameTime)
        {
            if(timeToDie < gameTime.TotalGameTime.TotalMilliseconds)
            {
                isAlive = false;
            }
        }
    }
}
