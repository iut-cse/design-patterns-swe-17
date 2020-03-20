namespace DesignPatterns.MidSemester
{
    public class CompressorDecorator : BaseDecorator
    {
        public CompressorDecorator(IGamerStat _decoratorGamerStat) : base(_decoratorGamerStat)
        {

        }

        public override string Stat(string stat)
        {
            var len = base.Stat(stat).Length;
            string x = base.Stat(stat);
            string ans = null;

            for (var i = 0; i < len - 2; i++)
                ans += x[i];

            return ans;
        }
    }
}