using System;
using System.Collections.Generic;
using System.Text;


namespace DesignPatterns.MidSemester.Task2
{
    class GamerStats { }

    public interface IDataSource
    {
        public String writeData();
    }

    public class DataSource : IDataSource
    {
        String data;
        public DataSource(string data)
        {
            this.data = data;
        }

        public String writeData()
        {
            return data;
        }
    }

    public class DataSourceDecorator : IDataSource
    {
        public String source;
        protected IDataSource wrapee;
        public DataSourceDecorator(IDataSource source)
        {
            wrapee = source;
        }

        public virtual string writeData()
        {
            source = wrapee.writeData();
            return source;
        }
    }

    public class EncryptionDecorator : DataSourceDecorator
    {
        public EncryptionDecorator(IDataSource source) : base(source) { }

        public override string writeData()
        {
            source = wrapee.writeData();
            return source.ToLower();
        }
    }

    public class CompresssionDecorator : DataSourceDecorator
    {
        public CompresssionDecorator(IDataSource source) : base(source) { }

        public override string writeData()
        {
            source = wrapee.writeData();
            if (source.Length >= 3)
            {
                return source.Remove(source.Length-2);
            }
            else
            {
                return source;
            }
        }
    }

    public class EncodeDecorator : DataSourceDecorator
    {
        public EncodeDecorator(IDataSource source) : base(source) { }

        public override string writeData()
        {
            source = wrapee.writeData();
            return "(" + source + ")";
        }
    }
}