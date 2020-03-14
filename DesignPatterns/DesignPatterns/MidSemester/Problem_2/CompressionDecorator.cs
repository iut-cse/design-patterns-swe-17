namespace DesignPatterns.MidSemester.Problem_2
{
    public class CompressionDecorator : GamerDataDecorator
    {
        public CompressionDecorator(GamerData stat) : base(stat)
        {

        }

        public override string writeData(string data)
        {
            if (data.Length < 3)
            {
                return base.writeData(data);
            }
            else
            {
                return base.writeData(data).Substring(0, data.Length - 2);
            }
        }

    }
}


