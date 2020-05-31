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
    
    class PhysicalObject : MovingObject
    {
        protected bool isAlive = true;
        protected bool isJumping = false;

        public PhysicalObject(Texture2D texture, float X, float Y, float speedX, float speedY) : base(texture, X, Y, speedX, speedY)
        {
        }

        public void CheckTiles()
        {
            foreach (PhysicalObject t in GameElements.tiles)
            {
                if (speed.Y >= 0)
                {
                    if (speed.Y > 0 && Y + t.Height / 2 < t.Y)
                    {
                        PhysicalObject temp = new PhysicalObject(texture, X, Y + speed.Y, speed.X, speed.Y);

                        if (temp.CheckCollision(t))
                        {
                            speed.Y = 0f;
                            vector.Y += t.Y - Y - Height;
                            if (this is Players)
                            {
                                (this as Players).Timespressed = 0;
                            }
                        }
                    }

                }
            }
        }

        public bool CheckCollision(PhysicalObject other)
        {
            Rectangle myrectangle = new Rectangle(Convert.ToInt32(X), Convert.ToInt32(Y), Convert.ToInt32(Width), Convert.ToInt32(Height));
            Rectangle otherrectangle = new Rectangle(Convert.ToInt32(other.X), Convert.ToInt32(other.Y), Convert.ToInt32(other.Width), Convert.ToInt32(other.Height));
            return myrectangle.Intersects(otherrectangle);
        }
          
        public bool IsAlive
        {
            get { return isAlive; }
            set { isAlive = value; }
        }
    }
}