using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    public class CompressDecorator : DecoratorClass
    {
        public CompressDecorator(IStateSource stateSource) : base(stateSource)
        {
        }

        public override string Stat(string stat)
        {
            var len = base.Stat(stat).Length;
            string x = base.Stat(stat);
            string ans = null;

            for (var i = 0; i < len - 2; i++)
                ans += x[i];

            return ans;
        }
    }
}
