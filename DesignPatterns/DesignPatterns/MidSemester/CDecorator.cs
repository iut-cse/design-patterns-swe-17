using System;
using System.Text;
using System.Collections.Generic;
namespace DesignPatterns.MidSemester
{
    public class CDecorator : IConv
    {
        private readonly IConv wrappee;

        public CDecorator(IConv wrappee)
        {
            this.wrappee = wrappee;
        }
        public virtual string Converter(string mydata)
        {
            return wrappee.Converter(mydata);
        }
    }
}