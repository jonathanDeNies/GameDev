using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using ProjectGameDev.interfaces;

namespace ProjectGameDev.interfaces
{
    interface IGameObject
    {
        void Update();

        void Draw(SpriteBatch spriteBatch);
    }
}