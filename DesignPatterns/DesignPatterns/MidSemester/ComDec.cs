using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    public class ComDec : BaseDecorator
    {
        public ComDec(IGamerStat DecoratorGamerStat) : base(DecoratorGamerStat)
        { }

        public override string stat(string stat)
        {
            var len = base.stat(stat).Length;
            string x = base.stat(stat);
            string ans = null;

            for (var i = 0; i < len - 2; i++)
                ans += x[i];
            return ans;
        }
    }
}
