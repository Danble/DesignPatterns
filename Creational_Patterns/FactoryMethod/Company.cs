using System;
using System.Collections.Generic;
using System.Text;
using FactoryPattern;

namespace FactoryPattern
{
	public abstract class Company
	{
		string name;
		string area;
		public Company(string name, string area)
		{
			this.name = name;
			this.area = area;
		}

		//This is the factory method
		public abstract FactoryPattern.Employee[] GetEmployees();

		public void CreateSoftware()
        {
			FactoryPattern.Employee[] employees = GetEmployees();
			Console.WriteLine($"At {name}:");
			foreach(Employee employee in employees)
            {
				employee.DoWork();
            }
        }
	}

	public class SoftwareDevelopmentCompany : Company
    {
		public SoftwareDevelopmentCompany(string name, string area) : base(name, area)
        {
        }
		//Here is where the factory method is implemented
		public override FactoryPattern.Employee[] GetEmployees()
        {
			FactoryPattern.Employee[] employees = { new Designer(), new Programmer(), new Tester() };
			return employees;
        }
    }

	public class ShopCompany : Company
	{
		public ShopCompany(string name, string area) : base(name, area)
		{
		}
		//Here is where the factory method is implemented
		public override FactoryPattern.Employee[] GetEmployees()
		{
			FactoryPattern.Employee[] employees = { new Designer() };
			return employees;
		}
	}
}
