using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    class Color
    {
        private string name;

        public Color(string name) { this.name = name; }
        public string Paint() { return $"painted in color {name}"; }
    }

    class Red : Color { public Red() : base("red") {} }
    class Blue : Color { public Blue() : base("blue") {} }
}
