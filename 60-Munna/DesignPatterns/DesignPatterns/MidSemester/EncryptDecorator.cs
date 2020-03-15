using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    public class EncryptDecorator : DecoratorClass
    {
        public EncryptDecorator(IStateSource stateSource) : base(stateSource)
        {

        }
        public override string Stat(string state)
        {
            return base.Stat(state).ToLower();
        }
    }
}
