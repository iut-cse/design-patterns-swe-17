namespace DesignPatterns.MidSemester
{
    public class Power : IDistantAction
    {
        public override string grab()
        {
            return "pick up";
        }

        public override string hit()
        {
            return "slam";
        }
    }

}