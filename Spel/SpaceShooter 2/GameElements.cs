﻿using Brawl;
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
        public static List<Heart> hearts = new List<Heart>();
        public static List<Enemy> enemies = new List<Enemy>();
        public static List<Players> players = new List<Players>();
        public static List<Platform> tiles = new List<Platform>();
        static PrintText printText;
        static int spawnX;
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
            players.Add(new Player1(content.Load<Texture2D>("images/player/test"), 200, 150, 5f, 0f, content.Load<Texture2D>("images/player/hp/health_bar_5")));
            players.Add(new Player2(content.Load<Texture2D>("images/player2/test"), 500, 150, 5f, 0f, content.Load<Texture2D>("images/player/hp/health_bar_5")));
   
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
            int rnd = random.Next(1, 200);
            
            if (rnd == 1 && hearts.Count <= 0)
            {
                int rndX = random.Next(100, 700);
                int rndY = random.Next(window.ClientBounds.Height / 3, window.ClientBounds.Height - 64);
                hearts.Add(new Heart(heartSprite, rndX, rndY, 2f, gameTime));
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
                    spawnX = window.ClientBounds.Width-birdSprite.Width;
                }           
                int rndY = random.Next(window.ClientBounds.Height / 3 , window.ClientBounds.Height - 32 - heartSprite.Height);
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
                    ResetTotal(window, content);
                    return State.Menu;
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

            foreach (Heart h in hearts.ToList())
            {
                h.Update(window, gameTime);
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

        }

        private static void ResetTotal(GameWindow window, ContentManager content)
        {

            foreach (Players p in players.ToList())
            {
                p.ResetTotal(5f, 0f);
                enemies.Clear();
                hearts.Clear();
                Random random = new Random();
            }

        }

    }
}
