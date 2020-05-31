using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brawl
{
    class Heart : PowerUp
    {
    

        public Heart(Texture2D texture, float X, float Y, float speedY, GameTime gameTime) : base(texture, X, Y, speedY, gameTime)
        {
        }


        public override void Update(GameWindow window, GameTime gameTime)
        {

            foreach (Players p in GameElements.players)
            {
                if (isAlive)
                {
                    if (CheckCollision(p))
                    {
                        GameElements.powerUps.Remove(this);
                        GameElements.powerUp.Play(volume: 0.1f, pitch: 0.0f, pan: 0.0f);
                        if (p.Health < 5)
                            p.Health++;
                    }
                }
                else
                {
                    GameElements.powerUps.Remove(this);
                }

            }


            CheckTiles();
            vector.Y += speed.Y;
            speed.Y += 0.5f;
            if (timeToDie < gameTime.TotalGameTime.TotalMilliseconds)
            {
                isAlive = false;
            }
        }
    }
}
