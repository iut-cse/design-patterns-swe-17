
namespace DesignPatterns.Reports.Alignments
{
    public class LeftAlignment: IAlignment
    {
        public string Align(string text, int width)
        {
            return text.PadRight(width);
        }
    }
}
