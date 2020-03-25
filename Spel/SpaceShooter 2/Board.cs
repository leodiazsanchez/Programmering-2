﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework.Input;

namespace Brawl
{
    public class Board
    {
        static KeyboardState currentKeyState;
        static KeyboardState previousKeyState;
        static int timespressed;

        public static KeyboardState GetState()
        {
            previousKeyState = currentKeyState;
            currentKeyState = Microsoft.Xna.Framework.Input.Keyboard.GetState();
            return currentKeyState;
        }

        public static bool IsPressed(Keys key)
        {
            return currentKeyState.IsKeyDown(key);
        }

        public static bool HasBeenPressed(Keys key, int timespressed)
        {
            return currentKeyState.IsKeyDown(key) && !previousKeyState.IsKeyDown(key) && timespressed < 2;
        }
    }
}
