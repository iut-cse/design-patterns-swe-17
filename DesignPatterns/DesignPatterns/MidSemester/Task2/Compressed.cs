using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester.Task2
{
    class Compressed : DecoratedTxt
    {
        public IStatistics stat;

        public Compressed(IStatistics stat) : base(stat)
        {
        }

        public override string convertTxt(string statictics)
        {
            if (statictics.Length < 3)
            {
                return base.convertTxt(statictics);
            }
            else
            {
                return base.convertTxt(statictics).Substring(0, statictics.Length - 2);
            }
        }
    }
}
