
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    public interface IConversion
    {
        public string conversion(string text);

    }

    public class plaintext : IConversion
    {
        public string conversion(string text)
        {
            return text;
        }
    }
    public class Decorator : IConversion
    {
        IConversion stat;
        public Decorator(IConversion stat)
        {
            this.stat = stat;
        }
        public virtual string conversion(string text)
        {
            return stat.conversion(text);
        }
    }
    public class Encryption : Decorator
    {
        public Encryption(IConversion stat) : base(stat)
        {
        }
        public override string conversion(string text)
        {
            return base.conversion(text).ToLower();
        }
    }

    public class Compression : Decorator
    {
        public Compression(IConversion stat) : base(stat)
        {
        }
        public override string conversion(string text)
        {
            if (text.Length < 3)
            {
                return base.conversion(text);
            }
            else
            {
                return base.conversion(text).Substring(0, text.Length - 1);
            }

        }
    }
    public class Base_64_encodeing : Decorator
    {
        public Base_64_encodeing(IConversion stat) : base(stat)
        {
        }
        public override string conversion(string text)
        {
            return "(" + base.conversion(text) + ")";
        }
    }
}
