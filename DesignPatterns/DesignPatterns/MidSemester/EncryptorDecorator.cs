using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    public class EncryptorDecorator : BaseDecorator
    {
        public EncryptorDecorator(IGamerStat _decoratorGamerStat) : base(_decoratorGamerStat)
        {
        }

        public override string Stat(string stat)
        {
            return base.Stat(stat).ToLower();
        }
    }
}
