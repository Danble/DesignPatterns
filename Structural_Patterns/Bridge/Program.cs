using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle blue_circle = new Circle( new Blue());
            Console.WriteLine(blue_circle.MakeShape());
        }
    }
}
