using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    interface DataSource
    {
        void WriteData(string data);
        string ReadData();
    }
}
