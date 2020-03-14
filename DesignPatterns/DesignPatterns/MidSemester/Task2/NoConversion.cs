namespace DesignPatterns.MidSemester
{
    public class NoConversion : IConverter
    {
        public string Convert(string data)
        {
            return data;
        }
    }
}
