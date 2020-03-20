namespace DesignPatterns.MidSemester
{
    public class Power : DistantAction
    {
        protected override string Grab()
        {
            return "pick up";
        }

        protected override string Hit()
        {
            return "slam!";
        }
    }
}
