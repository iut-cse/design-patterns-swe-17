using System;
using System.Text;
using System.Collections.Generic;
namespace DesignPatterns.MidSemester.Problem2
{
    public class NoConv : IConv
    {
        public string Converter(string mydata)
        {
            return mydata;
        }
    }
}