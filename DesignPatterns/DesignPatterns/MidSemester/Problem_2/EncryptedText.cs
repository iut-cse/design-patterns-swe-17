using System;
using System.Collections.Generic;



namespace DesignPatterns.MidSemester.Problem_2
{
    public class Encrypted : PlainText
    {
        public Encrypted(Statistics statistics) : base(statistics)
        {
        }

        public override string statistics(string data)
        {
            return wrappee.statistics(data).ToLower();
        }
    }
}