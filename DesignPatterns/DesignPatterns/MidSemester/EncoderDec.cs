using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    public class EncoderDec:BaseDecorator
    {
        public EncoderDec(IGamerStat DecoratorGamerStat) : base(DecoratorGamerStat)
        { }

        public override string stat(string stat)
        {
            return "(" + base.stat(stat) + ")";
        }
    }
}
