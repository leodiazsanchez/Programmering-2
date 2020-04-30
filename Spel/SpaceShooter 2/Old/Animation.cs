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
        SpriteEffects rotation;
        Texture2D asset;
        string assetName;

        public Animation(string assetName, float frameSpeed, int numOffFrames, bool looping, ContentManager content)
        {
            this.numOffFrames = numOffFrames;
            this.looping = looping;
            this.assetName = assetName;
            this.asset = content.Load<Texture2D>(assetName);
            this.frameTime = frameSpeed;
            frameWidth = (asset.Width / numOffFrames);
            frameHeight = (asset.Height);
        }

        public Vector2 Position
        {
            get { return this.position; }
            set { this.position = value; }
        }

        public SpriteEffects Rotation
        {
            get { return this.rotation; }
            set { this.rotation = value; }
        }


        public int NumOffFrames
        {
            get { return this.numOffFrames; }
            set { this.numOffFrames = value; }
        }
        public int FrameWidth
        {
            get { return this.frameWidth; }
            set { frameWidth = value; }
        }
        public Texture2D Texture
        {
            get { return this.asset; }
            set { asset = value; }
        }

        public Rectangle Rect
        {
            get { return this.sourceRect; }
            set { sourceRect = value; }
        }
        public int FrameHeight
        {
            get { return this.frameHeight; }
            set { frameHeight = value; }
        }


        public void Update(GameTime gameTime)
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
            spriteBatch.Draw(asset, position, sourceRect, Color.White, 0f, new Vector2(0, 0), 1f, rotation, 0f);
    
        }
    }
}
