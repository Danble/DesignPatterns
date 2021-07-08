using System;
using System.Collections.Generic;
using System.Text;
using DependencyInversion;

namespace DependencyInversion
{
    class BudgetReport
    {
        private Database database;

        public BudgetReport(Database database)
        {
            this.database = database;
        }

        public bool open(string date)
        {
            Console.WriteLine(date);
            return true;
        }

        public void save()
        {
            database.insert();
        }
    }

    interface Database
    {
        void insert();

        void update();

        void delete();
    }
}
