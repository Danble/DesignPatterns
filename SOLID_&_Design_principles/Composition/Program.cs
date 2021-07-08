using System;
using Composition;

namespace Composition
{
    class Program
    {
        static void Main(string[] args)
        {
            Composition.Engine gas_engine = new Composition.CombustionEngine();
            Composition.Driver manual = new Composition.Human();

            Composition.Transport truck = new Transport(gas_engine, manual);
            manual.Navigate();
            truck.deliver("Mexico City", "Pillows");
            gas_engine.Move();
        }
    }
}
