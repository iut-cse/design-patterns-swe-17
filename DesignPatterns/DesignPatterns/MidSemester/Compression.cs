using System;
using System.Text;
using System.Collections.Generic;
namespace DesignPatterns.MidSemester
{
    public class Compresseion : CDecorator
    {
        public Compression(IConverter wrappee) : base(wrappee){
        }
        public override string Converter(string mydata)
        {
            if (mydata.length >= 3)
            {
                mydata = mydata.Substring(0, mydata.length - 2);
            }
            return base.Converter(mydata);
        }
    }
}