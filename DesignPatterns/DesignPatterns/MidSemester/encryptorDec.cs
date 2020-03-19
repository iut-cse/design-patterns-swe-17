using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    public class encryptorDec: BaseDecorator
    {
        public encryptorDec(IGamerStat DecoratorGamerStat) : base(DecoratorGamerStat)
        { }

        public override string stat(string stat)
        {
            return base.stat(stat).ToLower();
        }
    }
}
