using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester.Problem_2
{
    public abstract class ConversionDecorator: IConversion
    {
        protected IConversion datawrappee;

        public ConversionDecorator(IConversion datawrappee)
        {
            this.datawrappee = datawrappee;
        }

        public string Convert(string data)
        {
            data = SelfConvert(data);
            return datawrappee.Convert(data);
        }

        public abstract string SelfConvert(string data);
    }
}
