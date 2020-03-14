using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester.Problemset_2
{
    public class Plain : IStatistics
    {
        string text;
        public Plain(string text)
        {
            this.text = text;
        }

      
        public string getString()
        {
            return text;
        }
    }
}
