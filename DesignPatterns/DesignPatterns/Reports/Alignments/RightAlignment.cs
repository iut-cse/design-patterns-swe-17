namespace DesignPatterns.Reports.Alignments
{
    public class RightAlignment : IAlignment
    {
        public string Align(string text, int width)
        {
            return text.PadLeft(width);
        }
    }
}