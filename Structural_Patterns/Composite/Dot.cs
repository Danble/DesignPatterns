using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    class Dot : Graphic
    {
        protected int x, y;
        public Dot(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Move(int x, int y)
        {
            this.x += x;
            this.y += y;
        }
        public virtual string Draw()
        {
            return $"Moving x: {x} & y: {y} for drawing a dot";
        }
    }
}
