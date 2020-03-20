namespace DesignPatterns.MidSemester.Problem2
{
    public class Compresser : Converter
    {
        public Compresser(IConverter wrappee)
            : base(wrappee)
        {
        }

        public override string Convert(string data)
        {
            data = Compress(data);
            return base.Convert(data);
        }

        private string Compress(string data)
        {
            if (data.Length >= 3)
                data = data.Substring(0, data.Length - 2);

            return data;
        }
    }
}
