using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    public abstract class DataConvertDecorator : DataConvertor
    {
        protected DataConvertor wrapee;

        public DataConvertDecorator(DataConvertor wrapee)
        {
            this.wrapee = wrapee;
        }
        public string DataConvert(string data)
        {
            data=Convert(data);
            return wrapee.DataConvert(data);
        }

        public abstract string Convert(string data);
        
    }
}
