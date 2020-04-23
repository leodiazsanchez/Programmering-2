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
        Animation animation;
        int numOffFrames = 4;
       
        public Player2(Texture2D texture, float X, float Y, float speedX, float speedY, Texture2D hp) : base(texture, X, Y, speedX, speedY, hp)
        {
            this.texture = texture;
            who = 2;
            animation = new Animation(texture, 200f, numOffFrames, true);
        }

        public override void Update(GameWindow window, GameTime gameTime, ContentManager content)
        {
            base.Update(window, gameTime, content);

            animation.Position = vector;
            animation.Rotation = rotation;
            animation.Asset = content.Load<Texture2D>("images/player2/idle");
            animation.NumOffFrames = 4;
            animation.Update(gameTime);

            if (Board.IsPressed(Keys.Right))
            {
                animation.Asset = content.Load<Texture2D>("images/player2/walk");
                animation.NumOffFrames = 6;
                vector.X += speed.X;
                rotation = SpriteEffects.None;            
            }

            if (Board.IsPressed(Keys.Left))
            {
                animation.Asset = content.Load<Texture2D>("images/player2/walk");
                animation.NumOffFrames = 6;
                vector.X -= speed.X;
                rotation = SpriteEffects.FlipHorizontally;
            }


            if (Board.HasBeenPressed(Keys.Up) && Timespressed < 2)
            {
                speed.Y = -8f;
                Timespressed++;

            }

            if (Board.HasBeenPressed(Keys.RightControl))
            {
                animation.Asset = content.Load<Texture2D>("images/player2/attack");
                animation.NumOffFrames = 6;
                isAttacking = true;
            }
         

        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            animation.Draw(spriteBatch);
        }

        public override void Reset(float speedX, float speedY)
        {
            base.Reset(speedX, speedY);
            vector.X = 500f;
            vector.Y = 200f;
        }

    }
}
