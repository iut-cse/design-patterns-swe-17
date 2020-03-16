using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
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
}
