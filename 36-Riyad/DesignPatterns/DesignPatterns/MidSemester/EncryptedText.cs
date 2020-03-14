using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    
    public class EncryptedText : DecoratedText
    {
        public string text;

        public EncryptedText(File text): base(text)
        {
            this.text = text.getFile().ToLower();
        }

        public override string getFile()
        {
            return text;
        }
    }
}
