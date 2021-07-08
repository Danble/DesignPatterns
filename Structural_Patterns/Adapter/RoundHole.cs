using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class RoundHole
    {
        private int radius;

        public RoundHole(int radius)
        {
            this.radius = radius;
        }
        public int GetRadius()
        {
            return radius;
        }
        public bool Fit(RoundPeg peg)
        {
            return radius >= peg.GetRadius();
        }
    }
}
