using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester.Problemset_2
{
   public class Compress: Decorated
    {
        string text;
        public Compress(IStatistics stat) : base(stat)
        {
            if (stat.getString().Length >= 3)
            {
                this.text = stat.getString().Remove(stat.getString().Length - 2);
            }
            else
            {
                this.text = stat.getString();
            }
        }
        public override string getString()
        {
            return text;
        }
    }
}
