using Brawl;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brawl
{
    static class GameElements
    {
        static public Texture2D heartSprite, birdSprite, speedSprite, fireSprite, meteorSprite;
        public static List<PowerUp> powerUps = new List<PowerUp>();
        public static List<Enemy> enemies = new List<Enemy>();
        public static List<Players> players = new List<Players>();
        public static List<Platform> tiles = new List<Platform>();
        public static List<Bullet> bullets = new List<Bullet>();
        static PrintText printText;
        static int spawnX;
        static Menu menu;
        static SpriteFont font;
        static Background background;
        static HighScore highScore;
        private static Texture2D lobbybg;
        static Song song;
        public static SoundEffect powerUp, damage;

        public enum State { Menu, Run, HighScore, Quit };
        public static State currentState;

        public static void Initialize()
        {
            highScore = new HighScore(10);
        }

        public static void LoadContent(ContentManager content, GameWindow window)
        {
            //Laddar in meny
            menu = new Menu((int)State.Menu);
            menu.AddItem(content.Load<Texture2D>("images/menu/start"), (int)State.Run);
            menu.AddItem(content.Load<Texture2D>("images/menu/highscore"), (int)State.HighScore);
            menu.AddItem(content.Load<Texture2D>("images/menu/exit"), (int)State.Quit);

            //Laddar in backgrund
            background = new Background(content.Load<Texture2D>("images/background"));
            lobbybg = content.Load<Texture2D>("images/background");

            //Laddar in spelare
            players.Add(new Player1(content.Load<Texture2D>("images/player/test"), 200, 150, 5f, 0f, content.Load<Texture2D>("images/player/hp/health_bar_5"),content, content.Load<Texture2D>("images/powerups/fire")));
            players.Add(new Player2(content.Load<Texture2D>("images/player2/test"), 500, 150, 5f, 0f, content.Load<Texture2D>("images/player/hp/health_bar_5"),content, content.Load<Texture2D>("images/powerups/fire")));

            //Laddar in låt och ljudeffekter
            song = content.Load<Song>("Sounds/gametrack");
            powerUp = content.Load<SoundEffect>("Sounds/heart");
            damage = content.Load<SoundEffect>("Sounds/damage");
            //Spelar upp låt
            MediaPlayer.Play(song);
            MediaPlayer.Volume = 0.1f;
            MediaPlayer.IsRepeating = true;

            //Laddar in värld
            for (int i = 150; i < 300; i+= 16)
            {
                tiles.Add(new Platform(content.Load<Texture2D>("images/platform/island"), i, 375, 0f, 0f));
            }

            for (int i = 400; i < 600; i += 16)
            {
                tiles.Add(new Platform(content.Load<Texture2D>("images/platform/island"), i, 250, 0f, 0f));
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

            //Laddar in resterade
            heartSprite = content.Load<Texture2D>("images/powerups/heart");
            speedSprite = content.Load<Texture2D>("images/powerups/speed");
            fireSprite = content.Load<Texture2D>("images/powerups/fire");
            meteorSprite = content.Load<Texture2D>("images/enemies/meteor");
            birdSprite = content.Load<Texture2D>("images/enemies/bird");
            printText = new PrintText(content.Load<SpriteFont>("myFont"));
            highScore.LoadFromFile("highscore.txt");
            font = content.Load<SpriteFont>("myFont");

        }

        //Sparar highscore till fil
        public static void UnloadSave()
        {
            highScore.SaveToFile("highscore.txt");
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

         
            KeyboardState keyboardState = Keyboard.GetState();
            if (keyboardState.IsKeyDown(Keys.Escape)) return State.Menu;

            //Skapar hjärtan och fåglar slumpmässigt
            Random random = new Random();
            int rnd = random.Next(1, 500);
            
            if (rnd == 1 && powerUps.Count <= 0)
            {
                int rndX = random.Next(100, 700);
                int rndY = random.Next(window.ClientBounds.Height / 3, window.ClientBounds.Height - 64);
                powerUps.Add(new Heart(heartSprite, rndX, rndY, 2f, gameTime));
            }

            if (rnd == 3 && powerUps.Count <= 0)
            {
                int rndX = random.Next(100, 700);
                int rndY = random.Next(window.ClientBounds.Height / 3, window.ClientBounds.Height - 64);
                powerUps.Add(new Speed(speedSprite, rndX, rndY, 2f, gameTime));
            }

            if (rnd == 4 && powerUps.Count <= 0)
            {
                int rndX = random.Next(100, 700);
                int rndY = random.Next(window.ClientBounds.Height / 3, window.ClientBounds.Height - 64);
                powerUps.Add(new Fire(fireSprite, rndX, rndY, 2f, gameTime));
            }

            if (rnd == 1)
            {
                int rndX = random.Next(0, 800);
                int Y = -23;
                Meteor meteor = new Meteor(meteorSprite, rndX, Y);
                enemies.Add(meteor);
            }

            if (rnd == 2)
            {
               
                int direction = random.Next(1, 3);
                if(direction == 1)
                {
                    spawnX = -birdSprite.Width;
                }
                else if (direction == 2)
                {
                    spawnX = window.ClientBounds.Width+birdSprite.Width;
                }           
                int rndY = random.Next(window.ClientBounds.Height / 3 , window.ClientBounds.Height - 32 - heartSprite.Height);
                Bird bird = new Bird(birdSprite, spawnX, rndY, direction,content);
                enemies.Add(bird);
            }

            //Kollar om spelare tagit skada
            players[1].Damage(players[0]);
            players[0].Damage(players[1]);

            foreach (Players p in players.ToList())
            {
                   
                p.Update(window, gameTime, content);

                if (!p.IsAlive)
                {
                    return State.HighScore;
                }

                if (p.Lives == 0)
                {
                    Reset(window, content);
                } 
            }
            foreach (Enemy e in enemies.ToList())
            {
                e.Update(window, gameTime);
            }

            foreach (PowerUp p in powerUps.ToList())
            {
                p.Update(window, gameTime);
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
            foreach (PowerUp p in powerUps)
            {
                p.Draw(spriteBatch);
            }
            printText.Print(players[0].Lives.ToString(), spriteBatch, 35, 25);
            printText.Print(players[1].Lives.ToString(), spriteBatch, 780, 25);
        }

        public static State HighScoreUpdate(GameTime gameTime, GameWindow window, ContentManager content)
        {
            KeyboardState keyboardState = Keyboard.GetState();
            if (keyboardState.IsKeyDown(Keys.Escape)) return State.Menu;

            if (players[0].Lives == 0 || players[1].Lives == 0)
            {
                if (players[0].Lives > players[1].Lives)
                {
                    highScore.EnterUpdate(gameTime, players[0].Lives);
                }
                else
                {
                    highScore.EnterUpdate(gameTime, players[1].Lives);
                }

                //Kollar om alla värden blivit satta innan spelet 
                if (highScore.Ärduklarellershuno)
                {
                    ResetTotal(window, content);
                    highScore.Ärduklarellershuno = false;
                    return State.HighScore;
                }
            }

            return State.HighScore;
        }

        public static void HighScoreDraw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(lobbybg, new Vector2(0, 0), Color.White);
            highScore.EnterDraw(spriteBatch, font);

        }

        private static void Reset(GameWindow window, ContentManager content)
        {
 
            foreach(Players p in players.ToList())
            {
                p.Reset(5f, 0f);
            }

        }

        private static void ResetTotal(GameWindow window, ContentManager content)
        {

            foreach (Players p in players.ToList())
            {
                p.ResetTotal(5f, 0f);
                enemies.Clear();
                powerUps.Clear();
            }

        }

    }
}
