namespace DesignPatterns.MidSemester.Problem_2
{
    public class EncodeDecorator : GamerDataDecorator
    {
        public EncodeDecorator(GamerData stat) : base(stat)
        {
        }

        public override string writeData(string data)
        {
            return "("+base.writeData(data)+")";
        }
    }
}


