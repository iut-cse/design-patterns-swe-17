namespace DesignPatterns.MidSemester
{
    public class Compresser : ConvertionDecorator
    {
        public Compresser(IConverter wrappee) : base(wrappee)
        {

        }

        public override string Convert(string data)
        {
            if (data.Length>=3)
            {
                data = data.Substring(0, data.Length - 2);
            }
            return base.Convert(data);
        }
    }
}
