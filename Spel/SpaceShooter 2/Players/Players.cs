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
    abstract class Players : PhysicalObject
    {
        float speedX,speedY;
        public bool fire = false;
        protected Texture2D hp;
        protected int who = 0;
        protected bool isAttacking;
        int health = 5;
        int lives = 3;
        protected double timesincelast = 0;
        protected SpriteEffects rotation = SpriteEffects.None;
        protected int timespressed = 0;
        protected bool hasFired = false;

        public Players(Texture2D texture, float X, float Y, float speedX, float speedY, Texture2D hp, Texture2D bulletTexture) : base(texture, X, Y, speedX, speedY)
        {
            this.hp = hp;
            this.speedX = speedX;
            this.speedY = speedY;
        }

        public int Timespressed
        {
            get { return this.timespressed; }
            set { this.timespressed = value; }

        }

        public bool HasFired
        {
            get { return this.hasFired; }
            set { this.hasFired = value; }

        }

        public SpriteEffects Rotation
        {
            get { return this.rotation; }
            set { this.rotation = value; }
        }

        public float SuperSpeed
        {
            get { return speed.X; }
            set { speed.X = value; }
        }

        public bool Fire
        {
            get { return fire; }
            set { fire = value; }
        }

        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        public int Lives
        {
            get { return lives; }
            set { lives = value; }
        }

        public void Damage(Players other)
        {
            if (isAttacking && CheckCollision(other))
            {
                other.health--;
                GameElements.damage.Play();
            }

            /*foreach (Bullet b in bullets.ToList())
            {
                if (b.CheckCollision(other))
                {
                    other.health--;
                    GameElements.damage.Play();
                }
            }*/
        }

        virtual public void Update(GameWindow window, GameTime gameTime, ContentManager content)
        {
            isAttacking = false;
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

            if (who == 1)
            {
                switch (Health)
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
                        hp = content.Load<Texture2D>("images/player/hp/health_bar_4");
                        break;
                    default:
                        hp = content.Load<Texture2D>("images/player/hp/health_bar_5");
                        break;
                }
            }
            else
            {
                switch (Health)
                {
                    case 1:
                        hp = content.Load<Texture2D>("images/player2/hp/health_bar_1");
                        break;
                    case 2:
                        hp = content.Load<Texture2D>("images/player2/hp/health_bar_2");
                        break;
                    case 3:
                        hp = content.Load<Texture2D>("images/player2/hp/health_bar_3");
                        break;
                    case 4:
                        hp = content.Load<Texture2D>("images/player2/hp/health_bar_4");
                        break;
                    default:
                        hp = content.Load<Texture2D>("images/player2/hp/health_bar_5");
                        break;
                }
            }

        

            if (vector.Y > window.ClientBounds.Height)
            {
                Health = 0;
            }
            if (vector.X > window.ClientBounds.Width)
            {
                vector.X = 0;
            }
            if (vector.X < 0)
            {
                vector.X = window.ClientBounds.Width;
            }

            CheckTiles();
            vector.Y += speed.Y;
            speed.Y += 0.5f;
        }


        public override void Draw(SpriteBatch spriteBatch)
        {
            switch (who)
            {
                case 1:
                    spriteBatch.Draw(hp, new Vector2(10, 10), Color.White);
                    break;
                case 2:
                    spriteBatch.Draw(hp, new Vector2(758, 10),null, Color.White, 0f, new Vector2(0,0), 1f, SpriteEffects.None, 0f);
                    break;
            }

         

        }

        virtual public void Reset(float speedX, float speedY)
        {
            speed.X = 5f;
            speed.Y = 0f;
            Health = 5;
            isAlive = true;
            isAttacking = false;
            Timespressed = 0;
            fire = false;
        }
        virtual public void ResetTotal(float speedX, float speedY)
        {
            Reset(speedX, speedY);
            Lives = 3;
        }

    }
}
