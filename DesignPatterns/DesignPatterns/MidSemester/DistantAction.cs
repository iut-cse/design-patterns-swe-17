namespace DesignPatterns.MidSemester
{
    public abstract class DistantAction
    {
        public string move()

        {

            return "move";

        }

        public abstract string grab();

        public abstract string hit();



        public IEnumerable<string> execute()

        {

            return new[] { move(), grab(), hit() };

        }
    }
}