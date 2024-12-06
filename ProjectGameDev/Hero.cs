using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
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

        private Vector2 positie = new Vector2(0, 0);
        private Vector2 snelheid = new Vector2(1, 1);


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
            Move();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(heroTexture, positie, animation.CurrectFrame.Rectangle, Color.White);
        }

        public void Move()
        {
            positie += snelheid;
        }
    }
}