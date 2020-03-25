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
        Texture2D hp;
        int who = 0;
        bool isAttacking;
        int health = 5;
        int lives = 3;
        SpriteEffects rotation = SpriteEffects.None;
        int timespressed = 0;

        public Players(Texture2D texture, float X, float Y, float speedX, float speedY, Texture2D hp) : base(texture, X, Y, speedX, speedY)
        {
            this.hp = hp;
        }

        public bool IsAttacking
        {
            get { return this.isAttacking; }
            set { this.isAttacking = value; }
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

        public float SpeedY
        {
            get { return this.speed.Y; }
            set { this.speed.Y = value; }

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
            if(isAttacking && CheckCollision(other))
            {
                other.health--;
            }
        }

        virtual public void Update(GameWindow window, GameTime gameTime, ContentManager content)
        {

        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, vector, null, Color.White, 0f, new Vector2(0, 0), 1.5f, Rotation, 0f);
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

        abstract public void Reset(float speedX, float speedY);
    }
}
