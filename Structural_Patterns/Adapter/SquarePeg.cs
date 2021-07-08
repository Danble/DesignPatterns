using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class SquarePeg
    {
        private int width;

        public SquarePeg(int width) { this.width = width; }
        public int GetWidth() { return width; }
    }
}
