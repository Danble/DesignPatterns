using System;
using System.Collections.Generic;
using System.Text;
using Liskov;

namespace Liskov
{
    class Project
    {
        private Liskov.Document[] documents;

        public Project(Liskov.Document[] documents)
        {
            this.documents = documents;
        }

        public void openAll()
        {
            foreach(Liskov.Document doc in documents)
            {
                Console.WriteLine(doc.open());
            }
        }

        public void saveAll()
        {
            foreach (Liskov.Document doc in documents)
            {
                doc.save();
            }
        }
    }
}
