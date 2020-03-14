﻿namespace DesignPatterns.MidSemester.Task2
{
    public class Encode : ConversionDecorator
    {
        public Encode(IConverter wrapee) : base(wrapee)
        {
            this.wrapee = wrapee;
        }
        public override string SelfConvert(string data)
        {
            data = "(" + data + ")";
            return data;
        }
    }
}
