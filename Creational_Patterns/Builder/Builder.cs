using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    interface IBuilder
    {
        void Reset();
        void SetSeats(int number);
        void SetEngine(IEngine engine);
        void SetTripComputer(string tripComputer);
        void SetGPS();
    }

    public class CarBuilder : IBuilder
    {
        private Car car;

        public void Reset()
        {
            car = new Car();
        }
        public void SetSeats(int number)
        {
            car.SetSeats(number);
        }
        public void SetEngine(IEngine engine)
        {
            car.SetEngine(engine);
        }
        public void SetTripComputer(string tripComputer)
        {
            car.SetTripComputer(tripComputer);
        }
        public void SetGPS()
        {
            car.SetGPS();
        }
        public Car GetCar()
        {
            return car;
        }
    }

    //TODO ManualBuilder here...
}
