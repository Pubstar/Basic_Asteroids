using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Asteroids
{
    class GameScene : Game
    {
        public Texture2D BackgroundTexture;
        public Rectangle BackgroundBounds;
        private GraphicsDeviceManager graphics;
        private SpriteBatch spriteBatch;
        private Camera camera;

        /// <summary>
        /// Base Constructor
        /// </summary>
        public GameScene()
            : this(null)
        {

        }

        public GameScene(GraphicsDeviceManager graphics)
            : this(graphics, new Camera())
        {
            
        }

        public GameScene(GraphicsDeviceManager graphics, Camera camera)
        {
            if (graphics != null)
                this.graphics = graphics;
            else
                this.graphics = new GraphicsDeviceManager(this);

            Content.RootDirectory = "Content";
            this.camera = camera;
        }

        protected override void Initialize()
        {
            BackgroundTexture = Content.Load<Texture2D>("spacebackground");
            BackgroundBounds = BackgroundTexture.Bounds;

            base.Initialize();
        }

        protected void Initialize(Texture2D backgroundTexture)
        {
            BackgroundTexture = backgroundTexture;
            BackgroundBounds = BackgroundTexture.Bounds;

            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
        }

        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }
        
        protected override void Update(GameTime gameTime)
        {
            // Change this to player speed
            camera.Move(new Vector2(-3, 0));

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.White);

            Matrix viewMatrix = camera.GetMatrix();
            spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.NonPremultiplied, null, null, null, null, viewMatrix);
            spriteBatch.Draw(BackgroundTexture, BackgroundBounds, Color.White);
            spriteBatch.End();

            base.Draw(gameTime);
        }
}
}
