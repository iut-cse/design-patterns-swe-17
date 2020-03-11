namespace DesignPatterns.MidSemester
{
    public class EncryptText : Statistics
    {
        public EncryptText(IStatistics component) : base(component)
        {
        }

        protected override string DoOperation(string data)
        {
            return data.ToLower();
        }
    }
}
