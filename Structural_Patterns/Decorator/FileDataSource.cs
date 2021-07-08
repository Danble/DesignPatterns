using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class FileDataSource : DataSource
    {
        private string data = "";

        public FileDataSource(string data)
        {
            this.data = data;
        }
        public void WriteData(string data)
        {
            this.data = data;
        }
        public string ReadData()
        {
            return data;
        }
    }
}
