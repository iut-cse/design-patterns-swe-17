namespace DesignPatterns.MidSemester
{
    public class PlainText : Statistics
    {
        string text;
        public PlainText(string text)
        {
            this.text = text;
        }

        public override string getString()
        {
            return text;
        }
    }
}
