using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public interface IAbstractfactory
    {
        Chair CreateChair();
        Sofa CreateSofa();
        CoffeeTable CreateCoffeeTable();
    }

    public class VictorianFurnitureFactory : IAbstractfactory
    {
        public Chair CreateChair()
        {
            return new VictorianChair();
        }

        public Sofa CreateSofa()
        {
            return new VictorianSofa(2);
        }

        public CoffeeTable CreateCoffeeTable()
        {
            return new VictorianCoffeeTable(4, "Rounded Square");
        }
    }

    public class ModernFurnitureFactory : IAbstractfactory
    {
        public Chair CreateChair()
        {
            return new ModernChair();
        }

        public Sofa CreateSofa()
        {
            return new ModernSofa(1.5);
        }

        public CoffeeTable CreateCoffeeTable()
        {
            return new ModernCoffeeTable(3, "Oval");
        }
    }
}
