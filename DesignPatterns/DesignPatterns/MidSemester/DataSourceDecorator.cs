using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    public class DataSourceDecorator : DataSource
    {
        DataSource source;
        public DataSourceDecorator(DataSource source)
        {
            this.source = source;
        }
        public string readData()
        {
            return source.readData();
        }

        public void writeData(string data)
        {
            source.writeData(data);
        }
    }
}
