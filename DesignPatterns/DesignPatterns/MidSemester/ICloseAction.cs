namespace DesignPatterns.MidSemester
{
    public interface ICloseAction
    {
        string action();
    }


    public class Punch : ICloseAction
    {
        public string action()
        {
            return "punch";
        }
    }

    public class Kick : ICloseAction
    {
        public string action()
        {
            return "kick";
        }
    }

    public class Head : ICloseAction
    {
        public string action()
        {
            return "head head";
        }
    }
}