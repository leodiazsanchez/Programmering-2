﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceShooter2
{
    public class Animation
    {
        Texture2D animation;
        Rectangle sourceRect;
        Vector2 position;

        float elapsed;
        float frameTime;
        int numOffFrames;
        int currentFrame;
        int width;
        int height;
        int frameWidth;
        int frameHeight;
        bool looping;
        Texture2D asset;

        public Animation(ContentManager Content, Texture2D asset, float frameSpeed, int numOffFrames, bool looping)
        {
            this.numOffFrames = numOffFrames;
            this.looping = looping;
            this.asset = asset;
            this.frameTime = frameSpeed;
            frameWidth = (asset.Width / numOffFrames);
            frameHeight = (asset.Height);
            position = new Vector2(380, 400);
        }

        public Vector2 Position
        {
            get { return this.position; }
            set { this.position = value; }
        }

        public int NumOffFrames
        {
            get { return this.numOffFrames; }
            set { this.numOffFrames = value; }
        }

        public Texture2D Asset
        {
            get { return this.asset; }
            set { this.asset = value; }
        }

        public int FrameWidth
        {
            get { return this.frameWidth; }
        }

        public int FrameHeight
        {
            get { return this.frameHeight; }
        }

      

        public void PlayAnim(GameTime gameTime)
        {
            elapsed += (float)gameTime.ElapsedGameTime.TotalMilliseconds;
            sourceRect = new Rectangle(currentFrame * frameWidth, 0, frameWidth, frameHeight);

            if(elapsed >= frameTime)
            {
                if(currentFrame >= numOffFrames - 1)
                {
                    if (looping)
                    {
                        currentFrame = 0;
                    }
                }
                else
                {
                    currentFrame++;
                }
                elapsed = 0;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(asset, position, sourceRect, Color.White, 0f, new Vector2(0, 0), 1f, SpriteEffects.None, 1f);
        }
    }
}
