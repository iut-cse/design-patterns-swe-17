using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    class Decorator
    {
    }

    public interface DataSource
    {
        public string writeData();
    }

    public class StringDataSource : DataSource
    {
        String data;
        public StringDataSource(string data)
        {
            this.data = data;
        }
        public String writeData()
        {
            return data;
        }
    }
    public class DataSourceDecorator : DataSource
    {
        public String source;
        public DataSource wrapeer;
        public DataSourceDecorator(DataSource source)
        {
            wrapeer = source;
        }
        public virtual string writeData()
        {
            source = wrapeer.writeData();
            return source;
        }
    }
    public class EncryptionDecorator : DataSourceDecorator
    {
        public EncryptionDecorator(DataSource source) : base(source)
        {

        }
        public override string writeData()
        {
            source = wrapeer.writeData();
            return source.ToLower();
        }
    }
    public class CompresssionDecorator : DataSourceDecorator
    {
        public CompresssionDecorator(DataSource source) : base(source)
        {

        }
        public override string writeData()
        {
            source = wrapeer.writeData();
            if (source.Length >= 3)
            {
                return source.Remove(source.Length - 2);
            }
            else
            {
                return source;
            }
        }
    }
    public class EncodeDecorator : DataSourceDecorator
    {
        public EncodeDecorator(DataSource source) : base(source)
        {

        }
        public override string writeData()
        {
            source = wrapeer.writeData();
            return "(" + source + ")";
        }
    }
}
