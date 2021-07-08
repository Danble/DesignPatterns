using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    class Director
    {
        //We are using the version of pass the builder as a method argument instead of passing in the constructor

        public string MakeSUV(CarBuilder b)
        {
            string message;
            //There's no need for try catch structures but I wanted to do it just for fun...
            try
            {
                b.Reset();
                b.SetSeats(2);
                b.SetEngine(new SUVEngine());
                b.SetTripComputer("None");
                message = "SUV car succesfully created!";
            }
            catch(Exception)
            {
                message = "There was an error in the production of the SUV car!";
            }
            return message;
        }
        public string MakeSportCar(CarBuilder b)
        {
            string message;
            try
            {
                b.Reset();
                b.SetSeats(2);
                b.SetEngine(new SportEngine());
                b.SetTripComputer("iCore7");
                b.SetGPS();
                message = "Sport car succesfully created!";
            }
            catch (Exception)
            {
                message = "There was an error in the production of the sport car!";
            }
            return message;
        }
    }
}
