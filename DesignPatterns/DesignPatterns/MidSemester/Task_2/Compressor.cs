using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester.Task_2
{
    public class Compressor : StatisticsDecorator
    {
        public IStatistics stat;

        public Compressor(IStatistics stat): base(stat)
        {
        }

        public override string conversion(string statictics)
        {
            if (statictics.Length < 3)
            {
                return base.conversion(statictics);
            }
            else
            {
                return base.conversion(statictics).Substring(0, statictics.Length - 2);
            }
        }
    }
}
