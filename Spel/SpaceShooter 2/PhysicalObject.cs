using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExGame
{
    abstract class PhysicalObject : MovingObject
    {
        protected bool isAlive = true;
        protected bool isJumping = false;

        protected PhysicalObject(Texture2D texture, float X, float Y, float speedX, float speedY):base(texture,X,Y,speedX,speedY)
        {
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

        public bool IsJumping
        {
            get { return isAlive; }
            set { isAlive = value; }
        }
    }
}
