using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester.Problemset_2
{
   public abstract class Decorated :IStatistics
    {
       private IStatistics stat;
        public Decorated(IStatistics stat)
        {
            this.stat = stat;
        }
        public abstract string getString();
    }
}
