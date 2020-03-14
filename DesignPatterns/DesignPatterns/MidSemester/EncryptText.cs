namespace DesignPatterns.Test.MidSemester
{
    internal class EncryptText
    {
        private CompressText compressText;

        public EncryptText(CompressText compressText)
        {
            this.compressText = compressText;
        }
    }
}