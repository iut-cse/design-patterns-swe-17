using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester.Problem_2
{
    public class CompressionDecorator : BaseDecorator
    {
        public CompressionDecorator(IStatistics statistics) : base(statistics)
        {

        }
        public override string statistics(string data)
        {
            if (wrappee.statistics(data).Length >= 3)
                return wrappee.statistics(data).Substring(0, (wrappee.statistics(data).Length) - 2);
            else
                return wrappee.statistics(data);
        }
    }
}
