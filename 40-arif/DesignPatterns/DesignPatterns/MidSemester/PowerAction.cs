namespace DesignPatterns.MidSemester
{
    public class PowerAction : DistantAction
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
