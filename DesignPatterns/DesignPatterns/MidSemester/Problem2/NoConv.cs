using System;
using System.Text;
using System.Collections.Generic;
namespace DesignPatterns.MidSemester
{
    public class NoConv : IConv
    {
        public string Converter(string mydata)
        {
            return mydata;
        }
    }
}