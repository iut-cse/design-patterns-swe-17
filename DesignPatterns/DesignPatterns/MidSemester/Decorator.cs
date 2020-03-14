using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    public abstract class Decorator : IPlayerStatistics
    {
        protected IPlayerStatistics wrapee;
        public Decorator(IPlayerStatistics wrapee)
        {
            this.wrapee = wrapee;
        }

        public string Statistics(string statistics)
        {
            statistics = Convert(statistics);
            return wrapee.Statistics(statistics);
        }

        public abstract string Convert(string score);

        public string PlayerStatistics(string statistics)
        {
            throw new NotImplementedException();
        }
    }
}