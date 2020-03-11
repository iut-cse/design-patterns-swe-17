using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    class GamerStatistics
    {
    }
    public interface DataSource
    {
        public String writeData();
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
        protected DataSource wrapee;
        public DataSourceDecorator(DataSource source)
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
        public EncryptionDecorator(DataSource source) : base(source)
        {

        }
        public override string writeData()
        {
            source = wrapee.writeData();
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
            source = wrapee.writeData();
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
            source = wrapee.writeData();
            return "(" + source + ")";
        }
    }
}
