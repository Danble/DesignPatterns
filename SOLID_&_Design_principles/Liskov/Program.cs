using System;
using Liskov;

namespace Liskov
{
    class Program
    {
        static void Main(string[] args)
        {
            Liskov.Document doc1 = new Document("I'm a single document and this is my data.", "doc1");
            Liskov.Document doc2 = new Document("I'm a little more complex document and this is my data.", "doc2");
            Liskov.Document doc3 = new Document("I'm just data, jerks.", "doc3");
            Liskov.Document doc4 = new ReadOnlyDocument("I'm a jerk.", "doc4");
            Liskov.Project my_project = new Project(new Document[] { doc1, doc2, doc3, doc4 });
            my_project.saveAll();
        }
    }
}
