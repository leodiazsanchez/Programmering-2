using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using SpaceShooter2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExGame
{
    static class GameElements
    {
        static Texture2D menuSprite;
        static Vector2 menuPos;
        static Player player, player2;
        static Animation playeranim, player2anim;
        static List<Heart> hearts;
        static List<Enemy> enemies;
        static List<Player> players;
        static List<Animation> animations;
        static Texture2D heartSprite;
        static PrintText printText;
        static Menu menu;
        static Background background;


        //Krafter och liknande
        static public float gravity = 0.5f;
        static public float xFriktion = 1f;

        public enum State { Menu,Run,HighScore,Quit};
        public static State currentState;

        public static void Initialize()
        {
            hearts = new List<Heart>();
        }

        public static void LoadContent(ContentManager content, GameWindow window)
        {
            menu = new Menu((int)State.Menu);
            menu.AddItem(content.Load<Texture2D>("images/menu/start"), (int)State.Run);
            menu.AddItem(content.Load<Texture2D>("images/menu/highscore"), (int)State.HighScore);
            menu.AddItem(content.Load<Texture2D>("images/menu/exit"), (int)State.Quit);
            player = new Player(content.Load<Texture2D>("images/player/placeholder"), 200, 150, 2f, 4.5f, content.Load<Texture2D>("images/player/hp/health_bar_decoration"), content.Load<Texture2D>("images/player/hp/health_bar"),1, content);
            player2 = new Player(content.Load<Texture2D>("images/player/placeholder"), 600, 150, 2f, 4.5f, content.Load<Texture2D>("images/player/hp/health_bar_decoration"), content.Load<Texture2D>("images/player/hp/health_bar"),2, content);
            playeranim = new Animation(content, content.Load<Texture2D>("images/player/idle"),200f, player.NumFrames, true);
            player2anim = new Animation(content, content.Load<Texture2D>("images/player/idle"), 200f, player2.NumFrames, true);
            background = new Background(content.Load<Texture2D>("images/background"), window);
            players = new List<Player>();
            players.Add(player);
            players.Add(player2);
            enemies = new List<Enemy>();
            hearts = new List<Heart>();
            Random random = new Random();
            heartSprite = content.Load<Texture2D>("images/powerups/heart");
            Texture2D tmpSprite = content.Load<Texture2D>("images/enemies/mine");

            /*for (int i = 0; i < 5; i++)
            {
                int rndX = random.Next(0, window.ClientBounds.Width - tmpSprite.Width);
                int rndY = random.Next(0, window.ClientBounds.Height / 2);
                Mine temp = new Mine(tmpSprite, rndX, rndY);
                enemies.Add(temp);
            }
            tmpSprite = content.Load<Texture2D>("images/enemies/tripod");
            for (int i = 0; i < 5; i++)
            {
                int rndX = random.Next(0, window.ClientBounds.Width - tmpSprite.Width);
                int rndY = random.Next(0, window.ClientBounds.Height / 2);
                Tripod temp = new Tripod(tmpSprite, rndX, rndY);
                enemies.Add(temp);
            }*/
            //heartSprite = content.Load<Texture2D>("images/powerups/coin");
            printText = new PrintText(content.Load<SpriteFont>("myFont"));
        }

        public static State MenuUpdate(GameTime gameTime)
        {
            return (State)menu.Update(gameTime);
        }

        public static void MenuDraw(SpriteBatch spriteBatch)
        {
            background.Draw(spriteBatch);
            menu.Draw(spriteBatch);
        }


        public static State RunUpdate(ContentManager content, GameWindow window, GameTime gameTime)
        {
            background.Update(window);
            player.Update(window, gameTime, content);
            player2.Update(window, gameTime, content);

            if (player.CheckCollision(player2) && player.IsAttacking)
            {
                player2.Points--;
            }

            if (player2.CheckCollision(player) && player2.IsAttacking)
            {
                player.Points--;
            }

            foreach (Enemy e in enemies.ToList())
            {
                foreach (Player p in players.ToList())
                {
                

                    foreach (Bullet b in p.Bullets)
                    {
                        if (e.CheckCollision(b))
                        {
                            e.IsAlive = false;
                            p.Points++;
                        }
                    }
                    if (e.IsAlive)
                    {
                        if (e.CheckCollision(p))
                        {
                            p.Points--;
                            e.IsAlive = false;
                            if (p.Points == 0)
                            {

                                p.IsAlive = false;
                            }
                        }

                        e.Update(window);
                    }


                    else enemies.Remove(e);
                }
                

            }


            Random random = new Random();
            int newHeart = random.Next(1, 200);
            if (newHeart == 1)
            {
                int rndX = random.Next(0, window.ClientBounds.Width - heartSprite.Width);
                int rndY = window.ClientBounds.Height - heartSprite.Height-52;
                hearts.Add(new Heart(heartSprite, rndX, rndY, gameTime));
            }

            foreach (Heart h in hearts.ToList())
            {
                foreach (Player p in players.ToList())
                {
                    if (h.IsAlive)
                    {
                        h.Update(gameTime);

                        if (h.CheckCollision(p))
                        {
                            hearts.Remove(h);
                            if (p.Points < 4)
                            {
                                p.Points++;
                            }

                        }
                    }
                    else
                    {
                        hearts.Remove(h);
                    }

                    if (!p.IsAlive)
                    {
                        Reset(window, content);
                        return State.Menu;
                    }
                }
                
            }


            playeranim.Position = player.Position;     
            playeranim.Asset = player.SpritePath;
            playeranim.Rotation = player.Rotation;
            playeranim.NumOffFrames = player.NumFrames;
            playeranim.PlayAnim(gameTime);

            player2anim.Position = player2.Position;
            player2anim.Asset = player2.SpritePath;
            player2anim.Rotation = player2.Rotation;
            player2anim.NumOffFrames = player2.NumFrames;
            player2anim.PlayAnim(gameTime);

            return State.Run;
        }

        public static void RunDraw(SpriteBatch spriteBatch)
        {
            background.Draw(spriteBatch);
            foreach (Player p in players.ToList())
            {
                p.Draw(spriteBatch);
            }

            playeranim.Draw(spriteBatch);
            player2anim.Draw(spriteBatch);

            foreach (Enemy e in enemies)
            {
                e.Draw(spriteBatch);
            }
            foreach (Heart h in hearts)
            {
                h.Draw(spriteBatch);
            }
            //printText.Print("HP:" + player.Points, spriteBatch, 0, 50);
   
        }

        public static State HighScoreUpdate()
        {
            KeyboardState keyboardState = Keyboard.GetState();
            if (keyboardState.IsKeyDown(Keys.Escape)) return State.Menu;
            return State.HighScore;
        }

        public static void HighScoreDraw(SpriteBatch spriteBatch)
        {

        }

        private static void Reset(GameWindow window, ContentManager content)
        {
            player.Reset(200, 150, 2f, 4.5f);
            player2.Reset(600, 150, 2f, 4.5f);
            enemies.Clear();
            Random random = new Random();
            Texture2D tmpSprite = content.Load<Texture2D>("images/enemies/mine");
            /*for (int i = 0; i < 5; i++)
            {
                int rndX = random.Next(0, window.ClientBounds.Width - tmpSprite.Width);
                int rndY = random.Next(0, window.ClientBounds.Height / 2);
                Mine temp = new Mine(tmpSprite, rndX, rndY);
                enemies.Add(temp);
            }

            tmpSprite = content.Load<Texture2D>("images/enemies/tripod");
            for (int i = 0; i < 5; i++)
            {
                int rndX = random.Next(0, window.ClientBounds.Width - tmpSprite.Width);
                int rndY = random.Next(0, window.ClientBounds.Height / 2);
                Tripod temp = new Tripod(tmpSprite, rndX, rndY);
                enemies.Add(temp);
            }*/
        }
    }
}
