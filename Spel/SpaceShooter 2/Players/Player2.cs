using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brawl
{
    class Player2 : Players
    {
        public Player2(Texture2D texture, float X, float Y, float speedX, float speedY, Texture2D hp) : base(texture, X, Y, speedX, speedY, hp)
        {
            this.texture = texture;
            Who = 2;
        }

        public override void Update(GameWindow window, GameTime gameTime, ContentManager content)
        {
            base.Update(window , gameTime, content);

            if (vector.Y == window.ClientBounds.Height - texture.Height)
            {
                Timespressed = 0;
            }

            if (Board.IsPressed(Keys.Right))
            {
                vector.X += speed.X;
                Rotation = SpriteEffects.None;

            }

            if (Board.IsPressed(Keys.Left))
            {
                vector.X -= speed.X;
                Rotation = SpriteEffects.FlipHorizontally;
            }


            if (Board.HasBeenPressed(Keys.Up) && Timespressed < 2)
            {
                speed.Y = -8f;
                Timespressed++;

            }

            if (Board.HasBeenPressed(Keys.RightControl))
            {
                IsAttacking = true;
            }

        }

        public override void Reset(float speedX, float speedY)
        {
            base.Reset(speedX, speedY);
            vector.X = 500f;
            vector.Y = 200f;
        }

    }
}
