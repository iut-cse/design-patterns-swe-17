using System;
using System.Collections.Generic;


namespace DesignPatterns.MidSemester.Problem_2
{
    public class Compressed : PlainText
    {
        public Compressed(Statistics statistics) : base(statistics)
        {

        }
        public override string statistics(string data)
        {
            if (wrappee.statistics(data).Length >= 3)
                return wrappee.statistics(data).Substring(0, wrappee.statistics(data).Length - 2);
            else
                return wrappee.statistics(data);
        }
    }
}
