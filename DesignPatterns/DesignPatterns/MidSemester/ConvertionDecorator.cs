using System;
using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public abstract class ConvertionDecorator : IConverter
    {

        private readonly IConverter wrappee;

        public ConvertionDecorator(IConverter wrappee)
        {
            this.wrappee = wrappee;
        }

        public string Convert(string data)
        {
            data = SelfConvert(data);
            return wrappee.Convert(data);
        }

        protected abstract string SelfConvert(string data);
    }
}
