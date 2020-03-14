using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester.Problemset_2
{
   public class Encrypt : Decorated
    {
        string text;
        public Encrypt(IStatistics stat) : base(stat)
        {
            this.text = stat.getString().ToLower();
        }

        public override string getString()
        {
            return text;
        }

    }
}
