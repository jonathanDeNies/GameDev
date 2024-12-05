using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ProjectGameDev.Animation;
using ProjectGameDev.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProjectGameDev
{
    public class Hero:IGameObject
    {

        Texture2D heroTexture;
        Animatie animatie;

        public Hero(Texture2D texture)
        {
            heroTexture = texture;
            animatie = new Animatie();
            animatie.addFrame(new AnimationFrame(new Rectangle(0,0,32,32)));
            animatie.addFrame(new AnimationFrame(new Rectangle(32, 0, 32, 32)));
            animatie.addFrame(new AnimationFrame(new Rectangle(64, 0, 32, 32)));
            animatie.addFrame(new AnimationFrame(new Rectangle(96, 0, 32, 32)));
            animatie.addFrame(new AnimationFrame(new Rectangle(128, 0, 32, 32)));
        }

        public void Update(GameTime gametime)
        {
            animatie.Update(gametime);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(heroTexture, new Vector2(0, 0), animatie.CurrectFrame.Rectangle, Color.White);
        }
    }
}
