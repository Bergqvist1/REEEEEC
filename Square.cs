using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace REEEEEC
{
    public abstract class Square
    {
        protected Vector2 position;

        protected Square hitbox;

        protected Color color; 
    }
}