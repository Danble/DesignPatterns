using System;
using System.Collections.Generic;
using System.Text;
using DependencyInversion;

namespace DependencyInversion
{
    class MySQLDatabase : DependencyInversion.Database
    {
        public void insert()
        {
            Console.WriteLine("Inserting in MySQL Database...");
        }

        public void update()
        {
            Console.WriteLine("Updating in MySQL Database...");
        }

        public void delete()
        {
            Console.WriteLine("Deleting in MySQL Database...");
        }
    }

    class MongoLDatabase : DependencyInversion.Database
    {
        public void insert()
        {
            Console.WriteLine("Inserting in Mongo Database...");
        }

        public void update()
        {
            Console.WriteLine("Updating in Mongo Database...");
        }

        public void delete()
        {
            Console.WriteLine("Deleting in Mongo Database...");
        }
    }
}
