using System;

namespace DesignPatterns.MidSemester.Problem2
{
    public class Encrypter : Converter
    {
        public Encrypter(IConverter wrappee) 
            : base(wrappee)
        {
        }

        public override string Convert(string data)
        {
            data = Encrypt(data);
            return base.Convert(data);
        }

        private string Encrypt(string data)
        {
            return data.ToLower();
        }
    }
}
