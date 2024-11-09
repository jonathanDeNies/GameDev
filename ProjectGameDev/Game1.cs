using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ProjectGameDev
{
    public class Game1 : Game
    {
        Texture2D spriteSheet;

        private Rectangle _deelRectangle;

        private int schuifOp_X = 0;

        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            _deelRectangle = new Rectangle(schuifOp_X, 0, 32, 32);
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            spriteSheet = Content.Load<Texture2D>("characters");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            _spriteBatch.Begin();
            _spriteBatch.Draw(spriteSheet, new Vector2(0,0), _deelRectangle, Color.White);
            _spriteBatch.End();

            schuifOp_X += 32;
            if(schuifOp_X > 128)
            {
                schuifOp_X = 0;
            }
            _deelRectangle.X = schuifOp_X;

            base.Draw(gameTime);
        }
    }
}
