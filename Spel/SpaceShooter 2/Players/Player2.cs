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
        protected Texture2D bulletTexture;
        public Player2(Texture2D texture, float X, float Y, float speedX, float speedY, Texture2D hp, ContentManager content, Texture2D bulletTexture) : base(texture, X, Y, speedX, speedY, hp, bulletTexture)
        {
            who = 2;
            animation = new Animation("images/player2/idle", 200f, numOffFrames, true, content);
            this.bulletTexture = bulletTexture;
        }

        public override void Update(GameWindow window, GameTime gameTime, ContentManager content)
        {
            base.Update(window, gameTime, content);
            animation.Position = vector;
            animation.Rotation = rotation;
            animation.Texture = content.Load<Texture2D>("images/player2/idle");
            animation.NumOffFrames = 4;
            animation.Update(gameTime);

            if (Board.IsPressed(Keys.Right))
            {
                animation.Texture = content.Load<Texture2D>("images/player2/walk");
                animation.NumOffFrames = 6;
                vector.X += speed.X;
                rotation = SpriteEffects.None;            
            }

            if (Board.IsPressed(Keys.Left))
            {
                animation.Texture = content.Load<Texture2D>("images/player2/walk");
                animation.NumOffFrames = 6;
                vector.X -= speed.X;
                rotation = SpriteEffects.FlipHorizontally;
            }


            if (Board.HasBeenPressed(Keys.Up) && Timespressed < 2)
            {
                speed.Y = -8f;
                Timespressed++;

            }

            if (Board.IsPressed(Keys.RightControl))
            {
                animation.Texture = content.Load<Texture2D>("images/player2/attack");
                animation.NumOffFrames = 6;
                if (Board.HasBeenPressed(Keys.RightControl))
                {
                    isAttacking = true;
                }
            }


            if (Board.HasBeenPressed(Keys.Space) && fire == true)
            {
                base.Shoot(gameTime);
            }

            foreach (Bullet b in bullets.ToList())
            {
                b.Update();

                if (b.CheckCollision(GameElements.players[0]))
                {
                    GameElements.players[0].Health--;
                    GameElements.damage.Play();
                    b.IsAlive = false;
                }
                if (!b.IsAlive)
                {
                    bullets.Remove(b);
                }
            }

        }
   
        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
            animation.Draw(spriteBatch);
            foreach (Bullet b in bullets.ToList())
            {
                b.Draw(spriteBatch);
            }
        }

        public override void Reset(float speedX, float speedY)
        {
            base.Reset(speedX, speedY);
            vector.X = 500f;
            vector.Y = 200f;
            bullets.Clear();
        }

    }
}
