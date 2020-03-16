using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    public interface DataSource
    {
        public void writeData(string data);
        public string readData();
    }
    public class FileDataSource : DataSource
    {
        public string data;
        public FileDataSource(string data)
        {
            this.data = data;
        }

        public string readData()
        {
            return data;
        }

        public void writeData(string data)
        {
            this.data = data;
        }
    }
    public class DataSourceDecorator : DataSource
    {
        public DataSource wrappee;
        public DataSourceDecorator(DataSource source)
        {
            wrappee = source;
            wrappee.writeData(source.readData());
        }
        public string readData()
        {
            return wrappee.readData();

        }

        public void writeData(string data)
        {
            wrappee.readData();
        }
    }
    public class EncryptionDecorator : DataSourceDecorator
    {

        public EncryptionDecorator(DataSource dataSourceDecorator) : base(dataSourceDecorator)
        {
            wrappee = dataSourceDecorator;
        }


        public string data;

        public string readData()
        {
            return data;
        }

        public void writeData(string data)
        {
            this.data = data.ToLower();
        }
    }
    public class CompressDecorator : DataSourceDecorator
    {
        public CompressDecorator(DataSource dataSourceDecorator) : base(dataSourceDecorator)
        {
            wrappee = dataSourceDecorator;
        }

        public string data;

        public string readData()
        {
            return data;
        }

        public void writeData(string data)
        {
            if (data.Length >= 3)
            {
                this.data = data.Substring(0, data.Length - 2);
            }
            else
            {
                this.data = data;
            }
        }
    }
    public class EncodeDecorator : DataSourceDecorator
    {
        public EncodeDecorator(DataSource dataSourceDecorator) : base(dataSourceDecorator)
        {
            wrappee = dataSourceDecorator;
        }
        public string data;

        public string readData()
        {
            return data;
        }

        public void writeData(string data)
        {
            this.data = "(" + data + ")";
        }
    }
}
