using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class Car
    {
        private int seats;
        private IEngine engine;
        private string tripComputer;
        private bool GPS = false;

        public void SetSeats(int seats)
        {
            this.seats = seats;
        }
        public void SetEngine(IEngine engine)
        {
            this.engine = engine;
        }
        public void SetTripComputer(string tripComputer)
        {
            this.tripComputer = tripComputer;
        }
        public void SetGPS()
        {
            GPS = true;
        }

        public string GetEngine()
        {
            return $"I have {engine.GetHP()} HP";
        }
    }
}
