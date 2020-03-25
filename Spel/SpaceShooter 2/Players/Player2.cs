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
        float speedX, speedY;
        public Player2(Texture2D texture, float X, float Y, float speedX, float speedY, Texture2D hp) : base(texture, X, Y, speedX, speedY, hp)
        {
            this.texture = texture;
            this.speedX = speedX;
            this.speedY = speedY;
            Who = 2;
        }   

        public override void Update(GameWindow window, GameTime gameTime, ContentManager content)
        {
            KeyboardState keystate = Keyboard.GetState();
            IsAttacking = false;
            if(vector.Y == window.ClientBounds.Height - texture.Height)
            {
                Timespressed = 0;
            }

            if (keystate.IsKeyDown(Keys.Right))
            {
                vector.X += speed.X;
                Rotation = SpriteEffects.None;
            }

            if (keystate.IsKeyDown(Keys.Left))
            {
                vector.X -= speed.X;
                Rotation = SpriteEffects.FlipHorizontally;
            }

            if (Board.HasBeenPressed(Keys.Up, Timespressed))
            {
                speed.Y = -8f;
                Timespressed++;
            }

            if (Board.HasBeenPressed(Keys.RightControl, Timespressed))
            {
                IsAttacking = true;
            }

            if (Health == 0)
            {
                Lives--;
                Health = 5;
                Reset(speedX, speedY);
            }


            if (Lives == 0)
            {
                isAlive = false;
            }

            switch (Health)
            {
                case 1:
                    Hp = content.Load<Texture2D>("images/player/hp/health_bar_1");
                    break;
                case 2:
                    Hp = content.Load<Texture2D>("images/player/hp/health_bar_2");
                    break;
                case 3:
                    Hp = content.Load<Texture2D>("images/player/hp/health_bar_3");
                    break;
                case 4:
                    Hp = content.Load<Texture2D>("images/player/hp/health_bar_4");
                    break;
                default:
                    Hp = content.Load<Texture2D>("images/player/hp/health_bar_5");
                    break;
            }
            if (vector.Y > window.ClientBounds.Height)
            {
                isAlive = false;
            }

            vector.Y += speed.Y;
            speed.Y += 0.5f;
            vector.X = Math.Min(Math.Max(vector.X, 0), window.ClientBounds.Width - texture.Width);
        }

        public override void Reset(float speedX, float speedY)
        {
            vector.X = 600f;
            vector.Y = 200f;
            speed.X = speedX;
            speed.Y = speedY;
            Health = 5;
            if (Lives == 0)
            {
                Lives = 3;
            }
            isAlive = true;
            IsAttacking = false;
        }
    }
}
