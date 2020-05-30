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
    class Meteor : Enemy
    {
      
        public Meteor(Texture2D texture, float X, float Y) : base(texture, X, Y, 6f, 6f)
        {
        }

        public override void Update(GameWindow window, GameTime gameTime)
        {
            vector.Y += speed.Y;
            vector.X += speed.X;

            foreach (Players p in GameElements.players)
            {
                if (CheckCollision(p))
                {
                    p.Health--;
                    GameElements.damage.Play(volume: 0.1f, pitch: 0.0f, pan: 0.0f);
                    isAlive = false;
                    GameElements.enemies.Remove(this);
                }

            }

            foreach (Platform t in GameElements.tiles)
            {

                if (CheckCollision(t))
                {
                    isAlive = false;
                    GameElements.enemies.Remove(this);
                }

            }
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture,vector,Color.White);
        }
    }
}
