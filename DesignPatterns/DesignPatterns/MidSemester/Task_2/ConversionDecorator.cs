using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester.Task_2
{
    public abstract class ConversionDecorator : IConversion
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

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public abstract string SelfConvert(string data);

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
