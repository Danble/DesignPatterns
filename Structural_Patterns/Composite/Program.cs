using System;
using System.Collections.Generic;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            //These can be declared as their interface or as their real class
            Graphic circle = new Circle(3,4,6);
            Graphic dot1 = new Dot(10, 48);
            Graphic dot2 = new Dot(21, 68);

            CompoundGraphic cG = new CompoundGraphic();
            cG.AddG(new Dot(3,4));

            CompoundGraphic drawing = new CompoundGraphic();
            drawing.AddG(dot1);
            drawing.AddG(circle);
            drawing.AddG(dot2);
            drawing.AddG(cG);

            drawing.Move(1, 1);
            Console.WriteLine(drawing.Draw());
        }
    }
}
