using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using ProjectGameDev.interfaces;

namespace ProjectGameDev.Animation
{
    public class Animatie
    {
        public AnimationFrame CurrectFrame { get; set; }
        private List<AnimationFrame> frames;

        private int counter;
        private double secondCounter = 0;

        public Animatie()
        {
            frames = new List<AnimationFrame>();
        }

        public void addFrame(AnimationFrame animationFrame)
        {
            frames.Add(animationFrame);
            CurrectFrame = frames[0];
        }

        public void Update(GameTime gametime)
        {
            CurrectFrame = frames[counter];

            secondCounter += gametime.ElapsedGameTime.TotalSeconds;
            int fps = 15;

            if (secondCounter >= 1d / fps)
            {
                counter++;
                secondCounter = 0;
            }

            if (counter >= frames.Count)
            {
                counter = 0;
            }
        }
    }
}
