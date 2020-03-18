using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester.Task2
{
    abstract class DecoratedTxt : IStatistics
    {
        private IStatistics stats;
        public DecoratedTxt(IStatistics stats)
    {
            this.stats = stats;
    }
        public virtual string convertTxt(string stat)
        {
            return stats.convertTxt(stat);
        }
    }
}
