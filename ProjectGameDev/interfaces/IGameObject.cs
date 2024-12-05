using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ProjectGameDev.interfaces;

namespace ProjectGameDev.interfaces
{
    interface IGameObject
    {
        void Update(GameTime gametime);

        void Draw(SpriteBatch spriteBatch);
    }
}