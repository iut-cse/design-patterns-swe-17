using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester.Task_2
{
    public class Encoder : StatisticsDecorator
    {

        public Encoder(IStatistics stat) : base(stat)
        {
        }

        public override string conversion(string statictics)
        {
            return "("+base.conversion(statictics)+")";
        }
    }
}
