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
    class Bird : Enemy
    {
        Animation animation;
        SpriteEffects rotation = SpriteEffects.None;
        int direction = 1;
        bool hit = false;
       
        public Bird(Texture2D texture, float X, float Y, int direction, ContentManager content) : base(texture, X, Y, 4.5f, 3f)
        {
            this.direction = direction;
            animation = new Animation("images/enemies/bird", 250f, 3, true, content);
        }

        public override void Update(GameWindow window, GameTime gameTime)
        {
            animation.Position = vector;
            animation.Rotation = rotation;
            animation.FrameHeight = (int)Height;
            animation.FrameWidth = (int)Width / 3;
            animation.Update(gameTime);
            switch (direction)
            {
                case 1:
                    rotation = SpriteEffects.None;
                    vector.X += speed.X;
                    if (vector.X > window.ClientBounds.Width)
                    {
                        isAlive = false;
                    }
                    break;
                case 2:
                    rotation = SpriteEffects.FlipHorizontally;
                    vector.X -= speed.X;
                    if (vector.X < -100)
                    {
                        isAlive = false;
                    }
                    break;
            }

            if (!isAlive)
            {
                GameElements.enemies.Remove(this);
            }

            foreach (Players p in GameElements.players)
            {
                if (CheckCollision(p) && !hit)
                {
                    p.Health--;
                    hit = true;
                    speed.X += 3f;
                }

            }
            vector.Y += speed.Y;
            speed.Y = -(float)Math.Cos(X / 100) * 2;
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            animation.Draw(spriteBatch);
        }
    }
}
