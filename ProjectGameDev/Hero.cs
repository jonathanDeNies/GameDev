using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ProjectGameDev.Animation;
using ProjectGameDev.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace ProjectGameDev
{
    public class Hero : IGameObject
    {

        private Texture2D heroTexture;
        private Animatie animation;
        private IInputReader inputReader;

        private Vector2 position;
        private Vector2 speed;


        public Hero(Texture2D texture, IInputReader inputReader)
        {
            this.heroTexture = texture;
            this.inputReader = inputReader;

            animation = new Animatie();
            animation.addFrame(new AnimationFrame(new Rectangle(0, 0, 32, 32)));
            animation.addFrame(new AnimationFrame(new Rectangle(32, 0, 32, 32)));
            animation.addFrame(new AnimationFrame(new Rectangle(64, 0, 32, 32)));
            animation.addFrame(new AnimationFrame(new Rectangle(96, 0, 32, 32)));
            animation.addFrame(new AnimationFrame(new Rectangle(128, 0, 32, 32)));

            position = new Vector2(250, 250);
            speed = new Vector2(4, 4);
        }

        public void Update(GameTime gametime)
        {

            Move();
            //MoveWithMouse();
            animation.Update(gametime);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(heroTexture, position, animation.CurrectFrame.Rectangle, Color.White);
        }

        public void Move()
        {
            Vector2 direction = inputReader.ReadInput();
            direction *= speed;
            position += direction;
        }

        public void MoveWithMouse()
        {
            MouseState state = Mouse.GetState();
            Vector2 mouseVector = new Vector2(state.X, state.Y);

            var richting = mouseVector - position;
            richting.Normalize();
            var afTeLeggenAftsand = richting * speed;
            position += afTeLeggenAftsand;
        }

        //public void MoveWithKeyBoard()
        //{
        //    if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
        //    {
        //        Exit();
        //    }
        //}
    }
}