using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    public abstract class DecoratorClass : IStateSource
    {
        public IStateSource StateSource;

        public DecoratorClass(IStateSource stateSource)
        {
            this.StateSource = stateSource;
        }
        public virtual string Stat(string state)
        {
            return StateSource.Stat(state);
        }
    }
}