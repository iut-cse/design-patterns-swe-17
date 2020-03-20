namespace DesignPatterns.MidSemester.Problem2
{
    public class Compresser : Converter
    {
        public Compresser(IConverter wrappee)
            : base(wrappee)
        {
        }
        
        protected override string ConverSelf(string data)
        {
            if (data.Length >= 3)
                data = data.Substring(0, data.Length - 2);

            return data;
        }
    }
}
