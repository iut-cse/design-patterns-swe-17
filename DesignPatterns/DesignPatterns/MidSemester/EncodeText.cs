namespace DesignPatterns.MidSemester
{
    public class EncodeText : Statistics
    {
        string text;
        public EncodeText(Statistics stat)
        {
            this.text = "("+stat.getString()+")";  
        }

        public override string getString()
        {
            return text;
        }
    }
}
