using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brawl
{
    class Bullet : PhysicalObject
    {
        public Bullet(Texture2D texture, float X, float Y) : base(texture, X, Y, 6f, 0)
        {
        }

        public float SpeedX
        {
            get { return speed.X; }
            set { speed.X = value; }
        }


        public void Update()
        {
            vector.X += speed.X;

            if (vector.X < 0)
            {
                isAlive = false;
            }

            if(vector.X > 800)
            {
                isAlive = false;
            }

        }
    }
}
