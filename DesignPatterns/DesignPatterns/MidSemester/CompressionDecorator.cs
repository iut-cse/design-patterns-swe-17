using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    public class CompressionDecorator : DataSource
    {
        int length;
        string compressedString;
      //  public CompressionDecorator(DataSource source) : base(source)
       // {
      //  }
            public void writeData(string data)
            {
            length = data.Length;
            if (length >= 3)
            {
                compressedString = data.Remove(length - 2);
            }
                
            }

            public string readData()
            {
                return compressedString;
            }
        
    }
}
