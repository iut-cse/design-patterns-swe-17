namespace DesignPatterns.MidSemester
{
    public class CompressText : Statistics
    {
        string text;
        public CompressText(Statistics stat)
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
}
