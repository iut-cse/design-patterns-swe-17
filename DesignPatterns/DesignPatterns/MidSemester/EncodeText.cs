namespace DesignPatterns.MidSemester
{
    public class EncodeText : Statistics
    {
        public EncodeText(IStatistics component) : base(component)
        {
        }

        protected override string DoOperation(string data)
        {
            return "(" + data + ")";
        }
    }
}