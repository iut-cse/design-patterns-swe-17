namespace DesignPatterns.Test.MidSemester
{
    internal class CompressText
    {
        private PlainText plainText;
        private PlainText plainText1;

        public CompressText(PlainText plainText)
        {
            this.plainText = plainText;
        }

        public CompressText(PlainText plainText1)
        {
            this.plainText1 = plainText1;
        }
    }
}