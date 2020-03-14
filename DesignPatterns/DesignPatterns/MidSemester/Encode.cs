using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    public class Encode : DataConvertDecorator
    {
        public Encode(DataConvertor wrapee) : base(wrapee)
        {
            this.wrapee = wrapee;
        }

        public override string Convert(string data)
        {
            data = "(" + data + ")";
            return data;
        }
    }
}
