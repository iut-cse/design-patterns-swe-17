using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester.problem2
{
    public class CompressConversion : TextDecorator
    {


        string text;

        public CompressConversion(IConversion wrapee) : base(wrapee)
        {
            if (wrapee.GetString().Length >= 3)
            {
                this.text = wrapee.GetString().Remove(wrapee.GetString().Length - 2);
            }
            else
            {
                this.text = wrapee.GetString();
            }
        }

        public override string GetString()
        {
            return text;
        }
    }
}
