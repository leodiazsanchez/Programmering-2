using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brawl
{
    abstract class Enemy : PhysicalObject
    {
        bool hit = false;
        public Enemy(Texture2D texture, float X, float Y, float speedX, float speedY) : base(texture, X, Y, speedX, speedY)
        {
        }
        public bool Hit
        {
            get { return hit; }
            set { hit = value; }
        }

        abstract public void Update(GameWindow window);

        abstract public override void Draw(SpriteBatch spriteBatch);

    }
}
