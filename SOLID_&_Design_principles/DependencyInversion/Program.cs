using System;
using DependencyInversion;

namespace DependencyInversion
{
    class Program
    {
        static void Main(string[] args)
        {
            BudgetReport report = new BudgetReport(new MySQLDatabase());
            report.save();
        }
    }
}
