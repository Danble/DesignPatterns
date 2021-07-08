using System;
using System.Collections.Generic;

namespace Prototype
{
    class Program
    {
        //The pattern most unclear at this moment, but in general I understand
        class Application
        {
            public List<Shape> shapes = new List<Shape>();

            public Application()
            {
                //Shapes needs to be declared as their concrete classes in order to modify thier own fields
                //but when you copy them you need to declare them as Shape.
                Circle circle = new Circle();
                circle.x = 10;
                circle.y = 10;
                circle.radius = 20;
                shapes.Add(circle);

                Shape anotherCircle = circle.Clone();
                shapes.Add(anotherCircle);

                Rectangle rectangle = new Rectangle();
                rectangle.width = 10;
                rectangle.height = 20;
                shapes.Add(rectangle);
            }
        }
        static void Main(string[] args)
        {
            List<Shape> copyShapes = new List<Shape>();
            Application app = new Application();
            foreach(Shape shape in app.shapes)
            {
                copyShapes.Add(shape.Clone());
            }
            for(int i = 0; i < app.shapes.Count; i++)
            {
                Console.WriteLine($"This is from the first list of shapes: {app.shapes[i]}");
                Console.WriteLine($"This is from the copy of the list of shapes: {copyShapes[i]}");
            }
        }
    }
}
