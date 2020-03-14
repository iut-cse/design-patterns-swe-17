using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    public class EncodedText : DecoratedText
    {
        public string text;

        public EncodedText(File text): base(text)
        {
            this.text = "(" + text.getFile() + ")";
        }

        public override string getFile()
        {
            return text;
        }
    }
}
