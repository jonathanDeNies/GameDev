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

        Texture2D heroTexture;
        static Animatie animation;

        private Vector2 positie = new Vector2(250, 250);
        private Vector2 snelheid = new Vector2(5, 5);

        Vector2 v1 = new Vector2(1, 2);
        Vector2 v2 = new Vector2(3, 4);


        public Hero(Texture2D texture)
        {
            heroTexture = texture;
            animation = new Animatie();
            animation.addFrame(new AnimationFrame(new Rectangle(0, 0, 32, 32)));
            animation.addFrame(new AnimationFrame(new Rectangle(32, 0, 32, 32)));
            animation.addFrame(new AnimationFrame(new Rectangle(64, 0, 32, 32)));
            animation.addFrame(new AnimationFrame(new Rectangle(96, 0, 32, 32)));
            animation.addFrame(new AnimationFrame(new Rectangle(128, 0, 32, 32)));
        }

        public void Update(GameTime gametime)
        {
            animation.Update(gametime);
            MoveWithMouse();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(heroTexture, positie, animation.CurrectFrame.Rectangle, Color.White);
        }

        public void Move()
        {
            positie += snelheid;
            if(positie.X > 800 -24 || positie.X < 0 -16)
                snelheid.X *= -1;
            if (positie.Y > 480 -32 || positie.Y < 0 -16)
                snelheid.Y *= -1;
        }

        public void MoveWithMouse() 
        {
            MouseState state = Mouse.GetState();
            Vector2 mouseVector = new Vector2(state.X, state.Y);

            var richting = mouseVector - positie;
            richting.Normalize();
            var afTeLeggenAftsand = richting * snelheid;
            positie += afTeLeggenAftsand;
        }
    }
}