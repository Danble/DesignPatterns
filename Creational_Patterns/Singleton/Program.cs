using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Singleton example = Singleton.GetInstance();
                Console.WriteLine(example);
                Singleton reference = Singleton.GetInstance();
                Console.WriteLine(reference);
                Console.WriteLine(example == reference);
            }
            catch (Exception)
            {
                Console.WriteLine("Singleton can not be created!");
            }
        }
    }
}
