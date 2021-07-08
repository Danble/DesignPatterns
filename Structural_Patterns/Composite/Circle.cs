using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    class Circle : Dot
    {
        private int radius;
        public Circle(int x, int y, int radius) : base(x, y)
        {
            this.radius = radius;
        }
        public override string Draw()
        {
            return $"Moving x: {x} & y: {y} for drawing a circle with radius: {radius}"; ;
        }
    }
}
