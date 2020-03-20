namespace DesignPatterns.MidSemester
{
    public class Skill : DistantAction
    {
        protected override string Grab()
        {
            return "hold collar";
        }

        protected override string Hit()
        {
            return "knee! knee!! knee!!!";
        }
    }
}
