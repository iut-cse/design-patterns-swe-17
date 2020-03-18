using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester.Problem_2
{
    public class BaseDecorator : IStatistics
    {
        protected IStatistics wrappee;
        public BaseDecorator(IStatistics wrappee)
        {
            this.wrappee = wrappee;
        }
        public virtual string statistics(string data)
        {
            return wrappee.statistics(data);
        }
    }
}
