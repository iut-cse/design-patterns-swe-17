namespace DesignPatterns.MidSemester
{
    public abstract class Statistics : IStatistics
    {
        IStatistics component;

        protected Statistics(IStatistics component)
        {
            this.component = component;
        }

        public string Convert(string data)
        {
            string temp = component.Convert(data);
            return DoOperation(temp);
        }


        protected abstract string DoOperation(string data);
    }
}