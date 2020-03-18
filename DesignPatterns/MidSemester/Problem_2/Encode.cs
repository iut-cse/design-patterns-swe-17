using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester.Problem_2
{
    public class Encode : ConversionDecorator
    {
        public Encode(IConversion datawrappee) : base(datawrappee)
        {
            
        }

        public override string Convert(string data)
        {
            data = "(" + data + ")";
            return base.Convert(data);
        }
    }
}
