using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    public abstract class BaseDecorator : IGamerStat
    {
        public IGamerStat DecoratorGamerStat;

        public BaseDecorator(IGamerStat _decoratorGamerStat)
        {
            this.DecoratorGamerStat = _decoratorGamerStat;
        }
        public virtual string Stat(string stat)
        {
            return DecoratorGamerStat.Stat(stat);
        }
    }
}
