using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //We can change whatever variant of product we want
            IAbstractfactory pedido = new ModernFurnitureFactory();

            Console.WriteLine(pedido.CreateChair().SitOn());
            CoffeeTable segundo_pedido = pedido.CreateCoffeeTable();
            Console.WriteLine(segundo_pedido.GetLegs());
        }
    }
}
