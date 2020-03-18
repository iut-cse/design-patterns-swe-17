namespace DesignPatterns.MidSemester
{
    public class CompressText : Statistics
    {

        public CompressText(IStatistics component) : base(component)
        {
        }

        protected override string DoOperation(string data)
        {
            if (data.Length >= 3)
            {
                data = data.Remove(data.Length - 2);
            }
            return data;
        }
    }
}