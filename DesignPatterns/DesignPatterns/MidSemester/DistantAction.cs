namespace DesignPatterns.MidSemester
{
    public abstract class DistantAction
    {
        public string Move()
        {
            return "move";
        }

        public abstract string Grab();
        public abstract string Hit();
    }
}