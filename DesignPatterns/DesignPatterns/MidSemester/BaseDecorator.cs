namespace DesignPatterns.MidSemester
{
    public class BaseDecorator : IGamerStat
    {
        public IGamerStat ToBeCoated;
        public BaseDecorator(IGamerStat Base)
        {
            this.ToBeCoated = Base;
        }

        public virtual string statistics(string inStat)
        {
            return ToBeCoated.statistics(inStat);
        }
    }
}