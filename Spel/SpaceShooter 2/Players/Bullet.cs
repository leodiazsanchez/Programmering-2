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

        public void Update()
        {
            vector.X += speed.X;

            /*foreach(Player1 p in GameElements.players)
            {
                if (p.Rotation == SpriteEffects.None)
                {
                    
                }
                else
                {
                    vector.X = -speed.X;
                }
            }

            foreach (Player2 p in GameElements.players)
            {
                if (p.Rotation == SpriteEffects.None)
                {
                    vector.X = speed.X;
                }
                else
                {
                    vector.X = -speed.X;
                }
            }*/


            /*if (vector.X < 0)
            {
                isAlive = false;
            }*/
        }
    }
}
