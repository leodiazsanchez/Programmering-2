﻿using Microsoft.Xna.Framework;
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
        Animation animation;
        int numOffFrames = 4;
        protected List<Bullet> bullets1;
        protected Texture2D bulletTexture;

        public Player1(Texture2D texture, float X, float Y, float speedX, float speedY, Texture2D hp,ContentManager content, Texture2D bulletTexture) : base(texture, X, Y, speedX, speedY, hp, bulletTexture)
        {
        
            who = 1;
            animation = new Animation("images/player/idle", 200f, numOffFrames, true, content);
            this.bulletTexture = bulletTexture;
            bullets1 = new List<Bullet>();
        }

        public override void Update(GameWindow window, GameTime gameTime, ContentManager content)
        {
            base.Update(window, gameTime, content);
            animation.Position = vector;
            animation.Rotation = rotation;
            animation.Texture = content.Load<Texture2D>("images/player/idle");
            animation.NumOffFrames = 4;
            animation.Update(gameTime);
           

            Board.GetState();
            if (Board.IsPressed(Keys.Z))
            {
                if (Board.HasBeenPressed(Keys.Z)){
                    isAttacking = true;
                }
                animation.Texture = content.Load<Texture2D>("images/player/attack");
            }

            if (Board.IsPressed(Keys.D))
            {
                vector.X += speed.X;
                rotation = SpriteEffects.None;
                animation.Texture = content.Load<Texture2D>("images/player/walk");
                animation.NumOffFrames = 6;


            }
            if (Board.IsPressed(Keys.A))
            {
                vector.X -= speed.X;
                rotation = SpriteEffects.FlipHorizontally;
                animation.Texture = content.Load<Texture2D>("images/player/walk");
                animation.NumOffFrames = 6;

            }


            if (Board.HasBeenPressed(Keys.W) && Timespressed < 2)
            {
                speed.Y = -8f;
                Timespressed++;
            }

            if (Board.HasBeenPressed(Keys.X) && fire == true)
            {

                Bullet temp = new Bullet(bulletTexture, vector.X + texture.Width / 2, vector.Y);

                bullets1.Add(temp);

                if (gameTime.TotalGameTime.TotalMilliseconds > timesincelast + 200)
                {
                    timesincelast = gameTime.TotalGameTime.TotalMilliseconds;
                }
            }

            foreach (Bullet b in bullets1.ToList())
            {
                b.Update();

                if (b.CheckCollision(GameElements.players[1]))
                {
                    GameElements.players[1].Health--;
                    GameElements.damage.Play();
                    b.IsAlive = false;
                }
                if (!b.IsAlive)
                {
                    bullets1.Remove(b);
                }
            }

        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
            animation.Draw(spriteBatch);
            foreach (Bullet b in bullets1.ToList())
            {
                b.Draw(spriteBatch);
            }

        }

        public override void Reset(float speedX, float speedY)
        {
            base.Reset(speedX,speedY);
            vector.X = 200f;
            vector.Y = 200f;
            bullets1.Clear();

        }

    }
}
