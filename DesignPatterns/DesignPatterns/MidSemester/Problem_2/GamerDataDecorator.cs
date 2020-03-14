namespace DesignPatterns.MidSemester.Problem_2
{
    public class GamerDataDecorator : GamerData
    {
        GamerData stat;

        public GamerDataDecorator(GamerData stat)
        {
            this.stat = stat;
        }

        public virtual string writeData(string data)
        {
            return stat.writeData(data);
        }
    }
}


