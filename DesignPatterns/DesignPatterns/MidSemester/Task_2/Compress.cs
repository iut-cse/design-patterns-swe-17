using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester.Task_2
{
    public class Compress : ConversionDecorator
    {
        public Compress(IConversion datawrappee) : base(datawrappee)
        {
            this.datawrappee = datawrappee;
        }

        public override string SelfConvert(string data)
        {
            if (data.Length >= 3)
            {
                data = data.Substring(0, data.Length - 2);
            }
            return data;
        }
    }
}
