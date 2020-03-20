namespace DesignPatterns.MidSemester.Problem2
{
    public abstract class Converter : IConverter
    {
        private readonly IConverter wrappee;

        public Converter(IConverter wrappee)
        {
            this.wrappee = wrappee;
        }

        public virtual string Convert(string data)
        {
            if (wrappee != null)
                data = wrappee.Convert(data);

            return data;
        }
    }
}
