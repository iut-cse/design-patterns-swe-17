using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    public class Encrypt : DataConvertDecorator
    {
        public Encrypt(DataConvertor wrapee) : base(wrapee)
        {
            this.wrapee= wrapee;
        }

        public override string Convert(string data)
        {
            data = data.ToLower();
            return data;
        }
    }
}
