using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
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
}
