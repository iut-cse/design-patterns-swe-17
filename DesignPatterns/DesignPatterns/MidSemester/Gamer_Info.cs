using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    public abstract class Info
    {
        public string text;
        public abstract string Convert();
    }

    public class Data : Info
    {
        public Data(string text)
        {
            base.text = text;
        }
        public override string Convert()
        {
            return text;
        }

    }



    public abstract class Security : Info
    {
        public Info component;
        public Security (Info component)
        {
            this.component = component;
        }

    }

    public class Encryption : Security
    {
        public Encryption(Info component) : base(component)
        {
        }

        public override string Convert()
        {
            base.text = component.Convert().ToLower();
            return text;
        }
    }
    public class Compressed : Security
    {
        public Compressed(Info component) : base(component) { }

        public override string Convert()
        {
            string converted = component.Convert();
            if (converted.Length >= 3)
            {
                base.text = converted.Remove(converted.Length - 2);
            }
            else
                base.text = converted;
            return base.text;

        }
    }
    public class Encoding : Security
    {
        public Encoding(Info component) : base(component) { }

        public override string Convert()
        {
            base.text = "(" + component.Convert() + ")";
            return base.text;
        }
    }

}
