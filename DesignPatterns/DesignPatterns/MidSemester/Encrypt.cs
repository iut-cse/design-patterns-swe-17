namespace DesignPatterns.MidSemester
{
    public class Encrypt : ConvertionDecorator
    {
        public Encrypt(IConverter wrappee): base(wrappee)
        {
        }

        public override string Convert(string data)
        {
            data = data.ToLower();
            return base.Convert(data);
        }
    }
}
