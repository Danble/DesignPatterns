using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            RoundHole hole = new RoundHole(5);
            SquarePeg peg = new SquarePeg(10);

            bool result = hole.Fit(new SquarePegAdapter(peg));
            Console.WriteLine(result);
        }
    }
}
