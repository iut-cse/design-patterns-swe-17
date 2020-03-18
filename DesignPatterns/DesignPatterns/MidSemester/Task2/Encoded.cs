using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester.Task2
{
    public class Encoded : DecoratedTxt
    {
        public Encoded(IStatistics stat) : base(stat) {}

        public override string convertTxt(string stat)
        {
            return "("+ base.convertTxt(stat)+")";
      
        }
    }
}
