﻿namespace DesignPatterns.MidSemester
{
    public class Encrypt : ConversionDecorator
    {
        public Encrypt(IConverter wrapee) : base(wrapee)
        {
            this.wrapee = wrapee;
        }
        public override string SelfConvert(string data)
        {
            data = data.ToLower();
            return data;
        }
    }
}
