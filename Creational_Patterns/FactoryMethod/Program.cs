using System;
using FactoryPattern;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryPattern.Company asilenbept = new SoftwareDevelopmentCompany("Asilenbept", "Software Development");
            asilenbept.CreateSoftware();
            FactoryPattern.Company fundamentally = new ShopCompany("Fundamentally", "Clothes Shop");
            fundamentally.CreateSoftware();
        }
    }
}
