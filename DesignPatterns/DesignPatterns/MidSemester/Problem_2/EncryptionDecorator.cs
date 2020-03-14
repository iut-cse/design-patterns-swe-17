namespace DesignPatterns.MidSemester.Problem_2
{
    public class EncryptionDecorator : GamerDataDecorator
    {
        public EncryptionDecorator(GamerData stat) : base(stat)
        {
        }

        public override string writeData(string data)
        {
            return base.writeData(data).ToLower();
        }

    }
}


