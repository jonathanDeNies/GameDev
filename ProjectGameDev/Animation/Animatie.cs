using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectGameDev.interfaces;

namespace ProjectGameDev.Animation
{
    public class Animatie
    {
        public AnimationFrame CurrectFrame { get; set; }

        private List<AnimationFrame> frames;

        private int counter;

        public Animatie()
        {
            frames = new List<AnimationFrame>();
        }

        public void addFrame(AnimationFrame animationFrame)
        {
            frames.Add(animationFrame);
            CurrectFrame = frames[0];
        }

        public void Update()
        {
            CurrectFrame = frames[counter];
            counter++;

            if (counter >= frames.Count)
                counter = 0;
        }
    }
}
