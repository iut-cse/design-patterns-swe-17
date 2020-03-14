using System;
using System.Collections.Generic;

namespace DesignPatterns.MidSemester.Problem_2
{
    public class PlainText : Statistics
    {
        protected Statistics wrappee;
        public PlainText(Statistics wrappee)
        {
            this.wrappee = wrappee;
        }
        public virtual string statistics(string data)
        {
            return wrappee.statistics(data);
        }
    }
}