namespace DesignPatterns.MidSemester
{
    public class Power : DistantAction
    {
        public override string grab()
        {
            return "pick up";
        }

        public override string hit()
        {
            return "slam!";
        }
    }
}
