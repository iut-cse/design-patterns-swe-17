using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.MidSemester
{
    public abstract class File
    {
        public string text;
        public abstract string Convert();
    }

    public class DataFile : File
    {
        public DataFile(string text)
        {
            base.text = text;
        }
        public override string Convert()
        {
            return text;
        }

    }



    public abstract class SecurityDecorator : File
    {
        public File component;
        public SecurityDecorator(File component)
        {
            this.component = component;
        }

    }

    public class Encrypt : SecurityDecorator
    {
        public Encrypt(File component) : base(component)
        {
        }

        public override string Convert()
        {
            base.text = component.Convert().ToLower();
            return text;
        }
    }
    public class Compress : SecurityDecorator
    {
        public Compress(File component) : base(component) { }

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
    public class Encode : SecurityDecorator
    {
        public Encode(File component) : base(component) { }

        public override string Convert()
        {
            base.text = "(" + component.Convert() + ")";
            return base.text;
        }
    }

}
