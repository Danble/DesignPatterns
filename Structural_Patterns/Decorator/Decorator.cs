using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class DataSourceDecorator : DataSource
    {
        protected DataSource wrappee;
        public DataSourceDecorator(DataSource wrappee) { this.wrappee = wrappee; }
        public virtual void WriteData(string data) { wrappee.WriteData(data); }
        public virtual string ReadData() { return wrappee.ReadData(); }
    }

    class CompressionDecorator : DataSourceDecorator
    {
        private bool isCompressed = false;
        public CompressionDecorator(DataSource wrappee) : base(wrappee) {}
        public override void WriteData(string data)
        {
            wrappee.WriteData(wrappee.ReadData() + data + "_(c)");
            isCompressed = true;
        }
        //Another possibility here is to decompressed the data
        public override string ReadData()
        {
            if (isCompressed)
            {
                return $"The data has been compressed: {wrappee.ReadData()}";
            }
            else
            {
                return wrappee.ReadData();
            }
        }
    }

    class EncryptionDecorator : DataSourceDecorator
    {
        private bool isEncrypted = false;
        public EncryptionDecorator(DataSource wrappee) : base(wrappee) {}
        public override void WriteData(string data)
        {       
            string hash = Convert.ToString($"{wrappee.ReadData()}{data}".GetHashCode());
            wrappee.WriteData(hash);
            isEncrypted = true;
        }
        //Another possibility here is to decrypt the data
        public override string ReadData()
        {
            if (isEncrypted)
            {
                return $"The data has been encrypted: {wrappee.ReadData()}";
            }
            else
            {
                return wrappee.ReadData();
            }
        }
    }
}
