using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class RoundPeg
    {
        private int radius;

        public RoundPeg(int radius) { this.radius = radius; }
        public int GetRadius() { return radius; }
    }
}
