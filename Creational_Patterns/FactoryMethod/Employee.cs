using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public interface Employee
    {
        void DoWork();
    }

    public class Designer : Employee
    {
        public void DoWork()
        {
            Console.WriteLine("I'm designin an amazing web site!");
        }
    }

    public class Programmer : Employee
    {
        public void DoWork()
        {
            Console.WriteLine("I'm coding a super eficient web site!");
        }
    }

    public class Tester : Employee
    {
        public void DoWork()
        {
            Console.WriteLine("I'm testing the web site doesn't have any problems!");
        }
    }
}
