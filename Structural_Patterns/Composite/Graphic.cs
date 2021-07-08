using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    interface Graphic
    {
        public void Move(int x, int y);
        public string Draw();
    }
}
