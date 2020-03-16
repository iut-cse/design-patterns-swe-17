using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
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
}
