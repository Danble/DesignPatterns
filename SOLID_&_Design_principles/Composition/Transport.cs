using System;
using System.Collections.Generic;
using System.Text;

namespace Composition
{
    public class Transport
    {
        private Engine engine;
        private Driver driver;

        public Transport(Engine engine, Driver driver)
        {
            this.engine = engine;
            this.driver = driver;
        }

        public void deliver(string destination, string cargo)
        {
            Console.WriteLine($"To {destination} with {cargo}.");
        }
    }

    public interface Engine
    {
        void Move();
    }

    public interface Driver
    {
        void Navigate();
    }

    public class CombustionEngine : Engine
    {
        public void Move()
        {
            Console.WriteLine("I work with gas!");
        }
    }

    public class ElectricEngine : Engine
    {
        public void Move()
        {
            Console.WriteLine("I work with electricity!");
        }
    }

    public class Robot : Driver
    {
        public void Navigate()
        {
            Console.WriteLine("Automatic navigation");
        }
    }

    public class Human : Driver
    {
        public void Navigate()
        {
            Console.WriteLine("Manual navigation");
        }
    }
}
