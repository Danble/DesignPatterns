using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creation of Airport and vehicles
            Airport new_airport = new Airport();
            Helicopter first_helicopter = new Helicopter(99);
            Car personal_car = new Car();

            Object[] vehicles = { first_helicopter, personal_car };

            foreach(Object vehicle in vehicles)
            {
                try
                {
                    IFlyingTransport flying_vehicle = vehicle as IFlyingTransport;
                    new_airport.accept(flying_vehicle);
                    flying_vehicle.fly("Mexico City", "Atlanta", 12);
                }
                catch
                {
                    Console.WriteLine("This vehicle can't fly or is not avoid to do it!");
                }
            }
        }
    }

    public class Airport
    {
        protected int size = 142;
        private bool accepted = false;

        public void accept(IFlyingTransport vehicle)
        {
            if (vehicle is IFlyingTransport)
            {
                accepted = true;
            }
        }

        public bool getAcceptance()
        {
            return accepted;
        }
    }

    public interface IFlyingTransport
    {
        void fly(string origin, string destination, int passengers);
    }

    public class Helicopter : IFlyingTransport
    {
        private double velocity;

        public Helicopter(double velocity)
        {
            this.velocity = velocity;
        }

        public void fly(string origin, string destination, int passengers)
        {
            Console.WriteLine("From " + origin + " to " + destination + " with " + passengers + " passengers.");
            Console.WriteLine("We are flying to " + velocity + " km/h and we can rotate 360°.");
        }
    }

    public class Car
    {
        private double velocity;
    }
}
