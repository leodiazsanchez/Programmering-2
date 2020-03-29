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
    class Player1 : Players
    {
        Animation temp;
        int frames = 4;
        Texture2D hp;
        public Player1(Texture2D texture, float X, float Y, float speedX, float speedY, Texture2D hp) : base(texture, X, Y, speedX, speedY, hp)
        {
            this.texture = texture;
            this.hp = hp;
            Who = 1;
            temp = new Animation(texture, 200f, frames, true);
        }

        public override void Update(GameWindow window, GameTime gameTime, ContentManager content)
        {
            base.Update(window, gameTime, content);
            Board.GetState();
            temp.Update(gameTime);
            temp.Position = Vector;
            temp.Rotation = Rotation;
            if (Board.HasBeenPressed(Keys.Z))
            {
                IsAttacking = true;
            }

            if (Board.IsPressed(Keys.D))
            {
                vector.X += speed.X;
                Rotation = SpriteEffects.None;

            }
            if (Board.IsPressed(Keys.A))
            {
                vector.X -= speed.X;
                Rotation = SpriteEffects.FlipHorizontally;
            }


            if (Board.HasBeenPressed(Keys.W) && Timespressed < 2)
            {
                speed.Y = -8f;
                Timespressed++;
            }
            

        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            //base.Draw(spriteBatch);
            temp.Draw(spriteBatch);
            spriteBatch.Draw(hp, new Vector2(10, 10), Color.White);
        }

        public override void Reset(float speedX, float speedY)
        {
            base.Reset(speedX,speedY);
            vector.X = 200f;
            vector.Y = 200f;

        }

    }
}
