using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            DataSource myData_toCompressed = new FileDataSource("hello");
            DataSource compressDecorator = new CompressionDecorator(myData_toCompressed);

            DataSource myData_toEncrypt = new FileDataSource("secret_password");
            DataSource encrypted = new EncryptionDecorator(myData_toEncrypt);

            //Before compression
            Console.WriteLine(compressDecorator.ReadData());
            compressDecorator.WriteData("");
            Console.WriteLine(compressDecorator.ReadData());

            encrypted.WriteData("pepper");
            Console.WriteLine(encrypted.ReadData());
        }
    }
}
