using System;
using System.Collections.Generic;
using System.Text;

namespace Liskov
{
    class Document
    {
        private string data;
        private string filename;

        public Document(string data, string filename)
        {
            this.data = data;
            this.filename = filename;
        }

        public string open()
        {
            return data;
        }

        public virtual void save(string new_data="")
        {
            data += new_data;
            Console.WriteLine($"changes in {filename} saved!");
        }
    }

    class ReadOnlyDocument : Document
    {
        public ReadOnlyDocument(string data, string filename) : base(data, filename) {}

        public override void save(string new_data = "")
        {
            throw new Exception("Unable to save read-only file.");
        }
    }
}
