namespace DesignPatterns.MidSemester
{

	public class SkillDistantAction: DistantAction
	{
        public override string Grab()
        {
            return "hold collar";
        }

        public override string Hit()
        {
            return "knee! knee!! knee!!!";
        }
    }
}
