using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Preparation of the cars requests
            CarBuilder b1 = new CarBuilder();
            CarBuilder b2 = new CarBuilder();
            //Initializing director
            Director dir = new Director();
            //Creating cars
            Console.WriteLine(dir.MakeSUV(b1));
            Console.WriteLine(dir.MakeSportCar(b2));
            //Delivering Cars
            Car SUVCar = b1.GetCar();
            Car sportCar = b2.GetCar();
            //Starting cars
            Console.WriteLine(SUVCar.GetEngine());
            Console.WriteLine(sportCar.GetEngine());
        }
    }
}
