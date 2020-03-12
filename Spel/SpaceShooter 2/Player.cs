using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SpaceShooter2;

namespace ExGame
{
    class Player : PhysicalObject
    {
        List<Bullet> bullets;
        Texture2D bulletTexture, hp;
        double timeSinceLastBullet = 0;
        private int points = 4;
        Texture2D spritePath;
        int numFrames;
        int who;
        SpriteEffects rotation = SpriteEffects.None;
     

        public Player(Texture2D texture, float X, float Y, float speedX, float speedY,Texture2D bulletTexture, Texture2D hp, int who, ContentManager content) : base(texture, X, Y, speedX, speedY )
        {
            bullets = new List<Bullet>();
            this.hp = hp;
            this.who = who;
            this.bulletTexture = bulletTexture;
            numFrames = 4;
            spritePath = content.Load<Texture2D>("images/player/idle");
            isJumping = false;
        }

        public Vector2 Position
        {
            get { return this.vector; }
        }

        public int Points
        {
            get { return points; }
            set { points = value; }
        }

        public Texture2D SpritePath
        {
            get { return this.spritePath; }
            
        }

        public SpriteEffects Rotation
        {
            get { return this.rotation; }

        }

        public int NumFrames
        {
            get { return this.numFrames; }

        }



        public void Update(GameWindow window, GameTime gameTime, ContentManager content)
        {

            KeyboardState keyboardState = Keyboard.GetState();

            //Default
            numFrames = 4;
            spritePath = content.Load<Texture2D>("images/player/idle");

            if(who == 1)
            {
                if (keyboardState.IsKeyDown(Keys.D))
                {
                    speed.X += 1.5f;
                    spritePath = content.Load<Texture2D>("images/player/run"); ;
                    numFrames = 6;
                    rotation = SpriteEffects.None;
                }


                if (keyboardState.IsKeyDown(Keys.A))
                {
                    speed.X -= 1.5f;
                    spritePath = content.Load<Texture2D>("images/player/run");
                    numFrames = 6;
                    rotation = SpriteEffects.FlipHorizontally;

                }

                if (keyboardState.IsKeyDown(Keys.A) && keyboardState.IsKeyDown(Keys.D))
                {
                    numFrames = 4;
                    spritePath = content.Load<Texture2D>("images/player/idle");
                }


                //if (keyboardState.IsKeyDown(Keys.S))
                //    vector.Y += speed.Y;
                if (keyboardState.IsKeyDown(Keys.W) && vector.Y == window.ClientBounds.Height - texture.Height - 60)
                {
                    speed.Y -= 15f;
                    isJumping = true;

                }

                if (keyboardState.IsKeyDown(Keys.Z))
                {
                    spritePath = content.Load<Texture2D>("images/player/attack");
                    numFrames = 4;


                    /* if(gameTime.TotalGameTime.TotalMilliseconds > timeSinceLastBullet + 200)
                     {
                         Bullet temp = new Bullet(bulletTexture, vector.X + texture.Width / 2, vector.Y);

                         bullets.Add(temp);

                         timeSinceLastBullet = gameTime.TotalGameTime.TotalMilliseconds;
                     }*/

                }

                if (keyboardState.IsKeyDown(Keys.X))
                {
                    spritePath = content.Load<Texture2D>("images/player/attack2");
                    numFrames = 7;

                }
            } else if (who == 2)
            {
                if (keyboardState.IsKeyDown(Keys.Right))
                {
                    speed.X += 1.5f;
                    spritePath = content.Load<Texture2D>("images/player/run"); ;
                    numFrames = 6;
                    rotation = SpriteEffects.None;
                }


                if (keyboardState.IsKeyDown(Keys.Left))
                {
                    speed.X -= 1.5f;
                    spritePath = content.Load<Texture2D>("images/player/run");
                    numFrames = 6;
                    rotation = SpriteEffects.FlipHorizontally;

                }

                if (keyboardState.IsKeyDown(Keys.Left) && keyboardState.IsKeyDown(Keys.Right))
                {
                    numFrames = 4;
                    spritePath = content.Load<Texture2D>("images/player/idle");
                }


                //if (keyboardState.IsKeyDown(Keys.S))
                //    vector.Y += speed.Y;
                if (keyboardState.IsKeyDown(Keys.Up) && vector.Y == window.ClientBounds.Height - texture.Height - 60)
                {
                    speed.Y -= 15f;
                    isJumping = true;

                }
            }
           
            
            if (keyboardState.IsKeyDown(Keys.Escape)){
                isAlive = false;
            }
           
            foreach (Bullet b in bullets.ToList())
            {
                b.Update();
                if (!b.IsAlive)
                {
                    bullets.Remove(b);
                }
            }
            if (isJumping)
            {
                speed.Y += GameElements.gravity;
            }
            if(points == 0)
            {
                isAlive = false;
            }
       

       

            // TODO: Add your update logic here


            //if (vector.X < 0)
            //    vector.X = 0;
            //if (vector.X > window.ClientBounds.Width - texture.Width)
            //    vector.X = window.ClientBounds.Width - texture.Width;
            //if (vector.Y < 0)
            //    vector.Y = 0;
            //if (vector.Y > window.ClientBounds.Height - texture.Height)
            //{
            //    vector.Y = window.ClientBounds.Height - texture.Height;
            //}

            if (speed.X > 0)
            {
                speed.X -= GameElements.xFriktion;
            }
            else if (speed.X < 0)
            {
                speed.X += GameElements.xFriktion;
            }


            vector.X += speed.X;
            vector.Y += speed.Y;

            vector.X = Math.Min(Math.Max(vector.X, 0), window.ClientBounds.Width-texture.Width);
            vector.Y = Math.Min(Math.Max(vector.Y, 0), window.ClientBounds.Height - texture.Height - 60);


            switch (points)
            {
                case 1:
                    hp = content.Load<Texture2D>("images/player/hp/health_bar_1");
                    break;
                case 2:
                    hp = content.Load<Texture2D>("images/player/hp/health_bar_2");
                    break;
                case 3:
                    hp = content.Load<Texture2D>("images/player/hp/health_bar_3");
                    break;
                case 4:
                    hp = content.Load<Texture2D>("images/player/hp/health_bar");
                    break;
            }

        }
        public List<Bullet> Bullets
        {
            get
            {
                return bullets;
            }
        }


        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, vector, Color.White);

            switch (who)
            {
                case 1:
                    spriteBatch.Draw(bulletTexture, new Vector2(10, 10), Color.White);
                    spriteBatch.Draw(hp, new Vector2(24, 10), Color.White);
                    break;
                case 2:
                    spriteBatch.Draw(bulletTexture, new Vector2(720, 10),Color.White);
                    spriteBatch.Draw(hp, new Vector2(734, 10), Color.White);
                    break;
            }


            foreach (Bullet b in bullets)
            {
                b.Draw(spriteBatch);
            }

        }

        public void Reset(float X, float Y, float speedX, float speedY)
        {
            vector.X = X;
            vector.Y = Y;
            speed.X = speedX;
            speed.Y = speedY;
            bullets.Clear();
            timeSinceLastBullet = 0;
            points = 4;
            isAlive = true;
            isJumping = false;
        }

       
    }
}
