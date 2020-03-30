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
        float speedX, speedY;
        Texture2D hp;
        int who = 0;
        bool isAttacking;
        int health = 5;
        int lives = 3;
        SpriteEffects rotation = SpriteEffects.None;
        int timespressed = 0;
        Animation temp;
        public Players(Texture2D texture, float X, float Y, float speedX, float speedY, Texture2D hp) : base(texture, X, Y, speedX, speedY)
        {
            this.hp = hp;
            this.speedX = speedX;
            this.speedY = speedY;
        }

        public bool IsAttacking
        {
            get { return this.isAttacking; }
            set { this.isAttacking = value; }
        }
        public Vector2 Vector
        {
            get { return this.vector; }
            set { this.vector = value; }
        }

        public Animation Anim
        {
            get { return temp; }
            set { this.temp = value; }
        }

        public int Timespressed
        {
            get { return this.timespressed; }
            set { this.timespressed = value; }

        }

        public int Who
        {
            get { return this.who; }
            set { this.who = value; }

        }


        public Texture2D Hp
        {
            get { return this.hp; }
            set { this.hp = value; }

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

        public SpriteEffects Rotation
        {
            get { return rotation; }
            set { rotation = value; }
        }

        public void Damage(Players other)
        {
            if (isAttacking && CheckCollision(other))
            {
                other.health--;
            }
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
            //spriteBatch.Draw(texture, vector, new Rectangle((int)X, (int)Y, (int)Width, (int)Height), Color.Red, 0f, new Vector2(0, 0), 1f, Rotation, 0f);
            spriteBatch.Draw(texture, vector, null, Color.White, 0f, new Vector2(0, 0), 1f, Rotation, 0f);
            switch (who)
            {
                case 1:
                    spriteBatch.Draw(hp, new Vector2(10, 10), Color.White);
                    break;
                case 2:
                    spriteBatch.Draw(hp, new Vector2(758, 10),null, Color.White, 0f, new Vector2(0,0), 1, SpriteEffects.FlipHorizontally, 0f);
                    break;
            }
        }

        virtual public void Reset(float speedX, float speedY)
        {
            speed.X = 5f;
            speed.Y = 0f;
            Health = 5;
            isAlive = true;
            IsAttacking = false;
            Timespressed = 0;
        }
        virtual public void ResetTotal(float speedX, float speedY)
        {
            Reset(speedX, speedY);
            Lives = 3;
        }

    }
}
