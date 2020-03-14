using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester.Problem_2
{
    public class EncryptionDecorator : BaseDecorator
    {
        public EncryptionDecorator(IStatistics statistics) : base(statistics)
        {
        }

        public override string statistics(string data)
        {
            return wrappee.statistics(data).ToLower();
        }
    }
}
