using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    
    public class CompressedText : DecoratedText
    {
        public string text;

        public CompressedText(File text): base(text)
        {
            if(text.getFile().Length >= 3)
            {
                this.text = text.getFile().Remove(text.getFile().Length - 2);

            }
            else
            {
                this.text = text.getFile();
            }
        }

        public override string getFile()
        {
            return text;
        }
    }
}
