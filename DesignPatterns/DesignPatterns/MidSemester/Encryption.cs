using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    public class Encryption : Decorator
    {
        public Encryption(IPlayerStatistics wrapee) : base(wrapee)
        {
            this.wrapee = wrapee;
        }

        public override string Convert(string score)
        {
            score = score.ToLower();
            return score;
        }

    }
}