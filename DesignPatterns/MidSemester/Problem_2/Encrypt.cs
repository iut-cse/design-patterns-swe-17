using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester.Problem_2
{
    public class Encrypt : ConversionDecorator
    {
        public Encrypt(IConversion datawrappee) : base(datawrappee)
        {
            
        }

        public override string Convert(string data)
        {
            data = data.ToLower();
            return base.Convert(data);
        }
    }
}
