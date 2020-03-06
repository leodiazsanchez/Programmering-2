using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExGame
{
    class Bullet : PhysicalObject
    {
        public Bullet(Texture2D texture, float X, float Y) : base(texture, X, Y, 3f, 0)
        {

        }

        public void Update()
        {
            vector.X += speed.X;
            if (vector.X < 0)
            {
                isAlive = false;
            }
        }
    }
}
