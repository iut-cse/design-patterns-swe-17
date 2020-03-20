namespace DesignPatterns.MidSemester.Problem2
{
    public class Encoder : Converter
    {
        public Encoder(IConverter wrappee)
            : base(wrappee)
        {
        }

        protected override string ConverSelf(string data)
        {
            return "(" + data + ")";
        }
    }
}
