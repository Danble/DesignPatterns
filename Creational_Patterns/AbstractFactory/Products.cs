using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public interface Chair
    {
        bool HasLegs();
        string SitOn();
    }

    public interface Sofa
    {
        bool HasLegs();
        string SitOn();
        double GetWidth();
    }

    public interface CoffeeTable
    {
        int GetLegs();
        string GetShape();
    }

    public class VictorianChair : Chair
    {
        public bool HasLegs()
        {
            return true;
        }

        public string SitOn()
        {
            return "Comfortable";
        }
    }

    public class VictorianSofa : Sofa
    {
        private double width;

        public VictorianSofa(double width)
        {
            this.width = width;
        }
        public bool HasLegs()
        {
            return true;
        }

        public string SitOn()
        {
            return "Very Comfortable";
        }

        public double GetWidth()
        {
            return width;
        }
    }

    public class VictorianCoffeeTable : CoffeeTable
    {
        private int legs;
        private string shape;
        public VictorianCoffeeTable(int legs, string shape)
        {
            this.legs = legs;
            this.shape = shape;
        }

        public int GetLegs()
        {
            return legs;
        }

        public string GetShape()
        {
            return shape;
        }
    }

    public class ModernChair : Chair
    {
        public bool HasLegs()
        {
            return false;
        }

        public string SitOn()
        {
            return "Heavenly Comfortable";
        }
    }

    public class ModernSofa : Sofa
    {
        private double width;

        public ModernSofa(double width)
        {
            this.width = width;
        }
        public bool HasLegs()
        {
            return false;
        }

        public string SitOn()
        {
            return "Very Comfortable";
        }

        public double GetWidth()
        {
            return width;
        }
    }

    public class ModernCoffeeTable : CoffeeTable
    {
        private int legs;
        private string shape;
        public ModernCoffeeTable(int legs, string shape)
        {
            this.legs = legs;
            this.shape = shape;
        }

        public int GetLegs()
        {
            return legs;
        }

        public string GetShape()
        {
            return shape;
        }
    }
}
