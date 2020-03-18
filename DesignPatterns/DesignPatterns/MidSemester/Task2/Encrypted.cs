using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester.Task2
{
    public class Encrypted : DecoratedTxt
    {
        public IStatistics stat;
        public Encrypted(IStatistics stat) : base(stat)
        {
            this.stat = stat;
        }

        public override string convertTxt(string statistics)
        {
            return base.convertTxt(statistics).ToLower();
        }
    }
}
