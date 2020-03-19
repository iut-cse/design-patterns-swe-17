using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public class Ratul
    {
        IdistantAction disact;
        IcloseAction closeact;


        public Ratul(IdistantAction disact)
        {
            this.disact = disact;
        }
        public Ratul(IcloseAction closeact)
        {
            this.closeact = closeact;
        }


        public string ExecuteCloseAction()
        {
            return closeact.action();
        }

        public IEnumerable<string> ExecuteDistantAction()
        {
            // you can return a array or list of string. Both array and list are subtypes of IEnumerable
            // However, there is a thing called `yield return` in C#.
            // Using it would be "cool"
            // Make sure you understand it if you choose to use it.
            return disact.TemAction();
        }
    }

    public interface IcloseAction
    {
        public string action();
    }

    public class kick : IcloseAction
    {
        public string action()
        {
            return "kick";
        }

    }
    public class punch : IcloseAction
    {
        public string action()
        {
            return "punch";
        }

    }
    public class head : IcloseAction
    {
        public string action()
        {
            return "head head";
        }

    }
    public interface IdistantAction
    {
        public IEnumerable<string> TemAction()
        {
            yield return this.move();
            yield return this.grab();
            yield return this.hit();
        }

        public string move()
        {
            return "move";
        }

        public abstract string grab();
        public abstract string hit();
    }

    public class skillact : IdistantAction
    {
        public string grab()
        {
            return "hold collar";

        }
        public string hit()
        {
            return "knee! knee!! knee!!!";
        }


    }

    public class poweract : IdistantAction
    {
        public string grab()
        {
            return "pick up";

        }
        public string hit()
        {
            return "slam!";
        }
    }
}
