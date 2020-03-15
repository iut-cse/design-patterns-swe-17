using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester.Task_2
{
    public class Uppercase : ConversionDecorator
    {
        public Uppercase(IConversion datawrappee) : base(datawrappee)
        {
            this.datawrappee = datawrappee;
        }

        public override string SelfConvert(string data)
        {
            data.ToUpper();
            return data;
        }
    }
}
