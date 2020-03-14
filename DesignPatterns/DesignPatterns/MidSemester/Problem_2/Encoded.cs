using System;
using System.Collections.Generic;

namespace DesignPatterns.MidSemester.Problem_2
{

    public class Encoded : PlainText
    {
        public Encoded(Statistics statistics) : base(statistics)
        {

        }
        public override string statistics(string data)
        {
            return "(" + wrappee.statistics(data) + ")";
        }
    }

}
