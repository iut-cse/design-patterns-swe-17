using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester.Problemset_2
{
    public class Encode : Decorated
    {
        string text;
        public Encode(IStatistics stat) : base(stat)
        {
            this.text = "(" + stat.getString() + ")";
        }
        public override string getString()
        {
            return text;
        }
    }
}
