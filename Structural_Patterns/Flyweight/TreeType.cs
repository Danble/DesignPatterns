using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    class TreeType
    {
        protected string name, color, texture;

        public TreeType(string name, string color, string texture)
        {
            this.name = name;
            this.color = color;
            this.texture = texture;
        }
        public void Draw(string canvas, int x, int y)
        {
            Console.WriteLine($"Drawing {canvas} at x: {x} & y: {y}. Tree: {name}, color & texture: {color}, {texture}");
        }
        public string GetFields()
        {
            return $"{name}|{color}|{texture}";
        } 
    }
}
