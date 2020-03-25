using Brawl;
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
    static class GameElements
    {
        static Texture2D menuSprite, heartSprite, birdSprite;
        static Vector2 menuPos;
        static List<Heart> hearts;
        static List<Enemy> enemies;
        static List<Players> players;
        public static List<Platform> tiles;
        static PrintText printText;
        static int spawnX;
        static Platform platform;
        static Menu menu;
        static Background background;


        //Krafter och liknande
        static public float gravity = 0.5f;
        static public float xFriktion = 1f;

        public enum State { Menu, Run, HighScore, Quit };
        public static State currentState;

        public static void Initialize()
        {

        }

        public static void LoadContent(ContentManager content, GameWindow window)
        {
            menu = new Menu((int)State.Menu);
            menu.AddItem(content.Load<Texture2D>("images/menu/start"), (int)State.Run);
            menu.AddItem(content.Load<Texture2D>("images/menu/highscore"), (int)State.HighScore);
            menu.AddItem(content.Load<Texture2D>("images/menu/exit"), (int)State.Quit);
            background = new Background(content.Load<Texture2D>("images/background"), window);
            players = new List<Players>();
            players.Add(new Player1(content.Load<Texture2D>("images/player/player1"), 200, 150, 5f, 0f, content.Load<Texture2D>("images/player/hp/health_bar_5")));
            players.Add(new Player2(content.Load<Texture2D>("images/player2/player2"), 600, 150, 5f, 0f, content.Load<Texture2D>("images/player/hp/health_bar_5")));
            tiles = new List<Platform>();
            for (int i = 100; i < 300; i+= 16)
            {
                tiles.Add(new Platform(content.Load<Texture2D>("images/platform/tile"), i, 350, 0f, 0f));
            }

            for (int i = 400; i < 600; i += 16)
            {
                if (i == 400)
                {
                    tiles.Add(new Platform(content.Load<Texture2D>("images/platform/tile3"), i, 250, 0f, 0f));
                }
                else
                {
                    tiles.Add(new Platform(content.Load<Texture2D>("images/platform/tile"), i, 250, 0f, 0f));
                }
          
            }

            for (int i = 100; i < 700; i += 16)
            {   
               if(i== 100)
               {
                    tiles.Add(new Platform(content.Load<Texture2D>("images/platform/tile4"), i, window.ClientBounds.Height - 16, 0f, 0f));
                    tiles.Add(new Platform(content.Load<Texture2D>("images/platform/tile3"), i, window.ClientBounds.Height - 32, 0f, 0f));
               }
               else if (i == 692)
               {
                    tiles.Add(new Platform(content.Load<Texture2D>("images/platform/tile6"), i, window.ClientBounds.Height - 16, 0f, 0f));
                    tiles.Add(new Platform(content.Load<Texture2D>("images/platform/tile5"), i, window.ClientBounds.Height - 32, 0f, 0f));
               }
               else
               {
                   tiles.Add(new Platform(content.Load<Texture2D>("images/platform/tile"), i, window.ClientBounds.Height - 32, 0f, 0f));
                   tiles.Add(new Platform(content.Load<Texture2D>("images/platform/tile2"), i, window.ClientBounds.Height - 16, 0f, 0f));
               }

            }
            Random random = new Random();
            enemies = new List<Enemy>();
            hearts = new List<Heart>();
            heartSprite = content.Load<Texture2D>("images/powerups/heart");
            birdSprite = content.Load<Texture2D>("images/enemies/bird");
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

            Random random = new Random();
            int newHeart = random.Next(1, 200);
  
            if(newHeart == 2)
            {
               
                int direction = random.Next(1, 3);
                if(direction == 1)
                {
                    spawnX = -birdSprite.Width;
                }
                else if (direction == 2)
                {
                    spawnX = window.ClientBounds.Width-birdSprite.Width;
                }           
                int rndY = random.Next(window.ClientBounds.Height / 3 , window.ClientBounds.Height);
                Bird bird = new Bird(birdSprite, spawnX, rndY, direction);
                enemies.Add(bird);
            }

            players[1].Damage(players[0]);
            players[0].Damage(players[1]);

            foreach (Players p in players.ToList())
            {
                p.Update(window, gameTime, content);
         
                if (!p.IsAlive)
                {
                    Reset(window, content);
                    return State.Menu;
                }

                foreach (Enemy e in enemies.ToList())
                {
                    e.Update(window);
                    if (e.CheckCollision(p) && !e.Hit)
                    {
                        p.Health--;
                        e.Hit = true;
                    }
                }

                foreach (Heart h in hearts.ToList())
                {
                    h.Update(gameTime);
                    if (h.IsAlive)
                    {
                        if (p.CheckCollision(h))
                        {
                            hearts.Remove(h);
                            if(p.Health < 5) 
                                p.Health++;
                        }
                    }
                    else
                    {
                        hearts.Remove(h);
                    }                
                }

                foreach(Platform t in tiles.ToList())
                {
                    if (t.CheckHitbox(p) && p.SpeedY >= 0)
                    {
                        p.SpeedY = 0f;
                        p.Timespressed = 0;
                    }

                   /* if (newHeart == 1)
                    {
                        int rndX = (int)t.X;
                        int rndY = (int)t.Y - heartSprite.Height;
                        hearts.Add(new Heart(heartSprite, rndX, rndY, gameTime));
                    }*/

                }
            
            }

            return State.Run;
        }

        public static void RunDraw(SpriteBatch spriteBatch)
        {
            background.Draw(spriteBatch);

            foreach (Platform t in tiles.ToList())
            {
                t.Draw(spriteBatch);
            }
            foreach (Players p in players.ToList())
            {
                p.Draw(spriteBatch);
            }
            foreach (Enemy e in enemies)
            {
                e.Draw(spriteBatch);

            }
            foreach (Heart h in hearts)
            {
                h.Draw(spriteBatch);
            }
            printText.Print(players[0].Lives.ToString(), spriteBatch, 35, 25);
            printText.Print(players[1].Lives.ToString(), spriteBatch, 780, 25);

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
 
            foreach(Players p in players.ToList())
            {
                p.Reset(5f, 0f);
            }
            enemies.Clear();
            hearts.Clear();
            Random random = new Random();

        }
    }
}
