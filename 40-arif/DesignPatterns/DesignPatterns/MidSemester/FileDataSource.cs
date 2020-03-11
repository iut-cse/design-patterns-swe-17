using System;

namespace DesignPatterns.MidSemester
{
    public class FileDataSource : IDataSource
    {
        public string data;

        public FileDataSource(string path)
        {
            this.data = path;
        }
        public string writeData(string data)
        {
            this.data = data;
            return data+"no change";
        }
        public string readData()
        {
            //data from path
            return this.data;
        }

    }
}
