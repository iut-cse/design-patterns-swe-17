namespace DesignPatterns.MidSemester
{
    public interface Statistics
    {
        public string getString();
    }

    public abstract class DecoratedText : Statistics
    {
        protected Statistics stat;
        public DecoratedText(Statistics stat)
        {
            this.stat = stat;
        }
        public abstract string getString();
    }

    public class PlainText : Statistics
    {
        string text;
        public PlainText(string text)
        {
            this.text = text;
        }

        public string getString()
        {
            return text;
        }
    }
    public class EncryptText : DecoratedText
    {
        string text;
        public EncryptText(Statistics stat) : base(stat)
        {
            this.text = stat.getString().ToLower();
        }

        public override string getString()
        {
            return text;
        }
    }
    public class CompressText : DecoratedText
    {
        string text;
        public CompressText(Statistics stat) : base(stat)
        {
            if (stat.getString().Length >= 3)
            {
                this.text = stat.getString().Remove(stat.getString().Length - 2);
            }
            else
            {
                this.text = stat.getString();
            }
        }
        public override string getString()
        {
            return text;
        }
    }
    public class EncodeText : DecoratedText
    {
        string text;
        public EncodeText(Statistics stat) : base(stat)
        {
            this.text = "(" + stat.getString() + ")";
        }
        public override string getString()
        {
            return text;
        }
    }
}
