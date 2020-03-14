using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    public abstract class Decorator : IScoreConversion
    {
        protected IScoreConversion wrapee;
        public Decorator(IScoreConversion wrapee)
        {
            this.wrapee = wrapee;
        }
        public string ScoreConvert(string score)
        {
            score = Convert(score);
            return wrapee.ScoreConvert(score);
        }
        public abstract string Convert(string score);
    }
}
