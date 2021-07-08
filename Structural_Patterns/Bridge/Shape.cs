using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    class Shape
    {
        private string name;
        private Color color;

        public Shape(string name, Color color)
        {
            this.name = name;
            this.color = color;
        }

        public string MakeShape()
        {
            return $"This {name} is {color.Paint()}";
        }
    }

    class Circle : Shape { public Circle(Color color) : base("circle", color) {} }
    class Square : Shape { public Square(Color color) : base("square", color) {} }
}
