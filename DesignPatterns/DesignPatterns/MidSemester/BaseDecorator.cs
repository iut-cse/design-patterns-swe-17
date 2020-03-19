using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
     public abstract class BaseDecorator : IGamerStat
    {
        public IGamerStat DecoratorGamerStat;

        public BaseDecorator(IGamerStat DecoratorGamerStat )
        {
            this.DecoratorGamerStat = DecoratorGamerStat;
        }

        public virtual string stat(string stat)
        {
            return DecoratorGamerStat.stat(stat);
        }
    }
}
