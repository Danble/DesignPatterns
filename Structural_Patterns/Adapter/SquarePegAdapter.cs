using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class SquarePegAdapter : RoundPeg
    {
        private SquarePeg peg;

        public SquarePegAdapter(SquarePeg peg) : base(peg.GetWidth())
        {
            this.peg = peg;
        }
        //It's fine without this because this is a trivial mocking! I really don't like that.
        public int GetRadius()
        {
            double converted = Math.Sqrt(Convert.ToDouble(peg.GetWidth())) / 2;
            Console.WriteLine($"radius is: {converted}");
            return (int)converted;
        }
    }
}
