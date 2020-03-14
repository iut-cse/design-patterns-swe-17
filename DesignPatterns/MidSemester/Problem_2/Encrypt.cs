using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester.Problem_2
{
    public class Encrypt : ConversionDecorator
    {
        public Encrypt(IConversion datawrappee) : base(datawrappee)
        {
            this.datawrappee = datawrappee;
        }

        public override string SelfConvert(string data)
        {
            data = data.ToLower();
            return data;
        }
    }
}
