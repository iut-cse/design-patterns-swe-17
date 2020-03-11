﻿namespace DesignPatterns.MidSemester
{
    public class EncryptionDecorator : DataDecorator
    {
        public string data;
        public EncryptionDecorator(DataDecorator source)
        {
            this.data = source.getData().ToLower();
        }

        public override string getData()
        {
            return this.data;
        }
    }
}
