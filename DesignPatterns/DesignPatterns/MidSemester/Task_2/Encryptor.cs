using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester.Task_2
{
    public class Encryptor : StatisticsDecorator
    {
        public IStatistics stat;
        public Encryptor(IStatistics stat) : base(stat)
        {
            this.stat = stat;
        }

        public override string conversion(string statistics)
        {
            return base.conversion(statistics).ToLower();
        }

    }
}
