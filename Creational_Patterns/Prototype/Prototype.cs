using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    public abstract class Shape
    {
        protected internal int x, y;
        protected internal string color;

        public Shape() {}
        //I don't really understand why I should contruct 2 shapes 
        public Shape(Shape source) : this()
        {
            x = source.x;
            y = source.y;
            color = source.color;
        }

        public abstract Shape Clone();
    }

    public class Rectangle : Shape
    {
        protected internal int width, height;

        public Rectangle() {}
        public Rectangle(Rectangle source) : base(source)
        {
            width = source.width;
            height = source.height;
        }

        public override Shape Clone()
        {
            return new Rectangle(this);
        }
    }

    public class Circle : Shape
    {
        protected internal int radius;

        public Circle() {}
        public Circle(Circle source) : base(source)
        {
            radius = source.radius;
        }

        public override Shape Clone()
        {
            return new Circle(this);
        }
    }
}
