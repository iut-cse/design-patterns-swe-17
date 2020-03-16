﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    public class EncodeDecorator : DataSourceDecorator
    {
        public EncodeDecorator(DataSource dataSourceDecorator) : base(dataSourceDecorator)
        {
            wrappee = dataSourceDecorator;
        }
        public string data;

        public string readData()
        {
            return data;
        }

        public void writeData(string data)
        {
            this.data = "(" + data + ")";
        }
    }
}
