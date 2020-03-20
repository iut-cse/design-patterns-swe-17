using System;

namespace DesignPatterns.MidSemester.Problem2
{
    public class Encrypter : Converter
    {
        public Encrypter(IConverter wrappee) 
            : base(wrappee)
        {
        }

        protected override string ConverSelf(string data)
        {
            return data.ToLower();
        }
    }
}
