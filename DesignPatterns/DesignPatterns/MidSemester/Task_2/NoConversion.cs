using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester.Task_2
{
    public class NoConversion : IConversion
    {
        public string Convert(string data)
        {
            return data;
        }
    }
}
