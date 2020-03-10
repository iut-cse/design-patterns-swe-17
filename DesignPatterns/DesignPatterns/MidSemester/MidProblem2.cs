using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    public interface DataSource
    {
        String printline();
    }

    public class RawData : DataSource
    {
        String text;
        public RawData(String newText)
        {
            text = newText;
        }
        public string printline()
        {
           return text;
        }
    }

    public class DataSourceDecorator : DataSource
    {
        public String source;
        public DataSource dataSourceDecorator;
        public DataSourceDecorator(DataSource newDataSource)
        {
            dataSourceDecorator = newDataSource;
        }
        public string printline()
        {
            return dataSourceDecorator.printline();
        }
    }

    public class Compressor : DataSourceDecorator
    {
        public Compressor(DataSource newDataSource) : base(newDataSource)
        {

        }
        public string printline()
        {
            source = dataSourceDecorator.printline();
            if (source.Length > 2)
            {
                source = source.Substring(0, source.Length - 2);
            }
            return source;
        }
    }

    public class Encrypter : DataSourceDecorator
    {
        public Encrypter(DataSource newDataSource) : base(newDataSource)
        {

        }
        public string printline()
        {
            source = dataSourceDecorator.printline();
            source = source.ToLower();
            return source;
        }
    }

    public class Encoder : DataSourceDecorator
    {
        public Encoder(DataSource newDataSource) : base(newDataSource)
        {

        }
        public string printline()
        {
            source = dataSourceDecorator.printline();
            source ="(" + source + ")";
            return source;
        }
    }
}
