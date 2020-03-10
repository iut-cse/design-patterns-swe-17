namespace DesignPatterns.MidSemester
{
    public class EncryptText : Statistics
    {
        string text;
        public EncryptText(Statistics stat)
        {
            this.text = stat.getString().ToLower();
        }

        public override string getString()
        {
            return text;
        }
    }
}
