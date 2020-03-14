using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    public class Compression : Decorator
    {
        public Compression(IPlayerStatistics wrapee) : base(wrapee)
        {
            this.wrapee = wrapee;
        }
        public override string Convert(string score)
        {
            if (score.Length >= 3)
            {
                score = score.Substring(0, score.Length - 2);
            }
            return score;
        }
    }
}