namespace DesignPatterns.MidSemester.Problem2
{
    public abstract class Converter : IConverter
    {
        private readonly IConverter wrappee;

        public Converter(IConverter wrappee)
        {
            this.wrappee = wrappee;
        }

        public string Convert(string data)
        {
            data = ConverSelf(data);

            if (wrappee != null)
                data = wrappee.Convert(data);

            return data;
        }

        protected abstract string ConverSelf(string data);
    }
}
