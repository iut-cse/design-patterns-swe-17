namespace DesignPatterns.MidSemester
{
    public class BaseDecor : IStatSaver
    {
        public IStatSaver ToBeCoated;
        public BaseDecor(IStatSaver Base)
        {
            this.ToBeCoated = Base;
        }
        
        public virtual string statistics(string inStat)
        {
            return ToBeCoated.statistics(inStat);
        }
    }
}
