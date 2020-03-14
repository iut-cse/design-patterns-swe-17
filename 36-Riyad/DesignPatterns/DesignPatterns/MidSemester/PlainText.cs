using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    public class PlainText : File
    {
        public string text;

        public PlainText(string text)
        {
            this.text = text;
        }
        public string getFile()
        {
            return text;
        }
    }
}
