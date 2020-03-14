using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester.problem2
{
    class EncodeConversion : TextDecorator
    {
        string text;

       

        public EncodeConversion(IConversion wrapee) : base(wrapee)
        {
           
        }

        public override string GetString()
        {
            return "(" + wrapee.GetString() + ")";
        }
    }
}
