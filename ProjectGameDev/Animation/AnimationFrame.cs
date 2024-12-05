using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectGameDev.interfaces;

namespace ProjectGameDev.Animation
{
    public class AnimationFrame
    {
        public Rectangle SourceRectangle { get; set; }
        public Microsoft.Xna.Framework.Rectangle Rectangle { get; }

        public AnimationFrame(Rectangle rectangle)
        {
            SourceRectangle = rectangle;
        }

        public AnimationFrame(Microsoft.Xna.Framework.Rectangle rectangle)
        {
            Rectangle = rectangle;
        }
    }
}
