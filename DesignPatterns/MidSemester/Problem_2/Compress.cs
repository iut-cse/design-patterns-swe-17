using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester.Problem_2
{
    public class Compress : ConversionDecorator
    {
        public Compress(IConversion datawrappee) : base(datawrappee)
        {
            
        }

        public override string Convert(string data)
        {
            if(data.Length>=3)
            {
                data = data.Substring(0, data.Length - 2);
            }
            return base.Convert(data);
        }
    }
}
