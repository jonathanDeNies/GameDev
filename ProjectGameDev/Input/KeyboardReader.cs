using Microsoft.Xna.Framework.Input;
using ProjectGameDev.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectGameDev.Input
{
    class KeyboardReader : IInputReader
    {
        public Vector2 ReadInput()
        {
            KeyboardState state = Keyboard.GetState();
            Vector2 direction = Vector2.Zero;

            //nog te implementeren
            //positie += snelheid;
            //if (positie.X > 800 - 24 || positie.X < 0 - 16)
            //    snelheid.X *= -1;
            //if (positie.Y > 480 - 32 || positie.Y < 0 - 16)
            //    snelheid.Y *= -1;

            if (state.IsKeyDown(Keys.Left))
            {
                direction.X -= 1;
            }
            if (state.IsKeyDown(Keys.Right))
            {
                direction.X += 1;
            }
            if (state.IsKeyDown(Keys.Up))
            {
                direction.Y -= 1;
            }
            if (state.IsKeyDown(Keys.Down))
            {
                direction.Y += 1;
            }
            return direction;
        }
    }
}
