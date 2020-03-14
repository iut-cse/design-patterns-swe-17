using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    public class Compress : DataConvertDecorator
    {
        public Compress(DataConvertor wrapee) : base(wrapee)
        {
            this.wrapee = wrapee;
        }

        public override string Convert(string data)
        {
            if (data.Length >= 3)
            {
                data = data.Substring(0, data.Length - 2);
            }
            return data;
        }
    }
}
