using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester.Task_2
{
    public class StatisticsDecorator : IStatistics
    {
        public IStatistics stat;

        public StatisticsDecorator(IStatistics stat)
        {
            this.stat = stat;
        }

        public virtual string conversion(string statictics)
        {
            return stat.conversion(statictics);
        }
    }
}
