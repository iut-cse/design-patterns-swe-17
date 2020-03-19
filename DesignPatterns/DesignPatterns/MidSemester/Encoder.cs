using System;
using System.Text;
using System.Collections.Generic;
namespace DesignPatterns.MidSemester
{
    public class Encoder : CDecorator
    {
        public Encoder(IConverter wrappee) : base(wrappee)
        {
        }
        public override string Convert(string mydata)
        {
            mydata = "(" + data + ")";
            return base.Converter(mydata);
        }
    }
}