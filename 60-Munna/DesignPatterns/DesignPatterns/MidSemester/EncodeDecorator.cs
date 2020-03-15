using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    public class EncodeDecorator : DecoratorClass
    {
        public EncodeDecorator(IStateSource stateSource) : base(stateSource)
        {
        }

        public override string Stat(string stat)
        {
            return "(" + base.Stat(stat) + ")";
        }
    }
}
