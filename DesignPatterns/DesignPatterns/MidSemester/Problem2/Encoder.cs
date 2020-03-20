namespace DesignPatterns.MidSemester.Problem2
{
    public class Encoder : Converter
    {
        public Encoder(IConverter wrappee)
            : base(wrappee)
        {
        }

        public override string Convert(string data)
        {
            data = Encode(data);
            return base.Convert(data);
        }

        private string Encode(string data)
        {
            return "(" + data + ")";
        }
    }
}
