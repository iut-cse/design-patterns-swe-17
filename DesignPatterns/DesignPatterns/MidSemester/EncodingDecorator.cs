using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    public class EncodingDecorator : BaseDecorator
    {
        public EncodingDecorator(IStatistics statistics):base(statistics)
        {

        }
        public override string statistics(string data)
        {
            return "("+wrappee.statistics(data)+")";
        }
    }
}
