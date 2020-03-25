using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brawl
{
    class Bird : Enemy
    {
        SpriteEffects rotation = SpriteEffects.None;
        int direction = 1;
        public Bird(Texture2D texture, float X, float Y, int direction) : base(texture, X, Y, 4.5f, 3f)
        {
            this.direction = direction;
        }

        public override void Update(GameWindow window)
        {
            switch (direction)
            {
                case 1:
                    rotation = SpriteEffects.None;
                    vector.X += speed.X;
                    break;
                case 2:
                    rotation = SpriteEffects.FlipHorizontally;
                    vector.X -= speed.X;
                    break;
                default:
                    rotation = SpriteEffects.None;
                    break;
            }
 
            vector.Y += speed.Y;
            speed.Y = -(float)Math.Cos(X / 100) * 2;

            /*if (vector.X > window.ClientBounds.Width)
            {
                isAlive = false;
            }*/
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, vector, null, Color.White, 0f, new Vector2(0, 0), 1, rotation, 0f);
        }
    }
}
