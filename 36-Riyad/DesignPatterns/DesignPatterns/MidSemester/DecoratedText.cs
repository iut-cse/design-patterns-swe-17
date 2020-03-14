using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    public abstract class DecoratedText : File
    {
        public File text;

        public DecoratedText(File text)
        {
            this.text = text;
        }
        public abstract string getFile();
        
    }
}
