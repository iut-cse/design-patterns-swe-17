using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester.Problem_2
{
    public class ConversionDecorator: IConversion
    {
        private readonly IConversion datawrappee;

        public ConversionDecorator(IConversion datawrappee)
        {
            this.datawrappee = datawrappee;
        }

        public virtual string Convert(string data)
        {
            
            return datawrappee.Convert(data);
        }

       
    }
}
