using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{

    public class Encoder : Decorator
    {
        public Encoder(IPlayerStatistics wrapee) : base(wrapee)
        {
            this.wrapee = wrapee;
        }
        public override string Convert(string score)
        {
            score = "(" + score + ")";
            return score;
        }
    }
}