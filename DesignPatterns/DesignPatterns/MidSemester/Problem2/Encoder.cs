using System;
using System.Text;
using System.Collections.Generic;
namespace DesignPatterns.MidSemester.Problem2
{
    public class Encoder : CDecorator
    {
        public Encoder(IConverter wrappee) : base(wrappee)
        {
        }
        public override string Converter(string mydata)
        {
            mydata = "(" + data + ")";
            return base.Converter(mydata);
        }
    }
}