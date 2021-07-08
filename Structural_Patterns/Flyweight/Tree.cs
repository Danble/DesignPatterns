using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    class Tree
    {
        private int x, y;
        private TreeType type;

        public Tree(int x, int y, TreeType type)
        {
            this.x = x;
            this.y = y;
            this.type = type;
        }
        public void Draw(string canvas)
        {
            type.Draw(canvas, x, y);
        }
    }
}
