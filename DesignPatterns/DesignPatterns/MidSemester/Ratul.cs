using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public class Ratul
    {
        private ICloseAction closeAction;
        private IDistinctAction distinctAction;

        public Ratul(ICloseAction closeAction)
        {
            this.closeAction = closeAction;
        }

        public Ratul(IDistinctAction distinctAction)
        {
            this.distinctAction = distinctAction;
        }

        public string ExecuteCloseAction()
        {
            return closeAction.execute();
        }

        public IEnumerable<string> ExecuteDistantAction()
        {
            // you can return a array or list of string. Both array and list are subtypes of IEnumerable
            // However, there is a thing called `yield return` in C#.
            // Using it would be "cool"
            // Make sure you understand it if you choose to use it.
            return distinctAction.execute();
        }
    }

    public interface ICloseAction
    {
        public string execute();
    }

    public abstract class IDistinctAction
    {
        public abstract string grab();
        public abstract string hit();

        public string move()
        {
            return "move";
        }
        public abstract List<string> execute();
    }

    public class Punch : ICloseAction
    {
        public string execute()
        {
            return "punch";
        }
    }

    public class Kick : ICloseAction
    {
        public string execute()
        {
            return "kick";
        }
    }

    public class Head : ICloseAction
    {
        public string execute()
        {
            return "head head";
        }
    }

    public class Power : IDistinctAction
    {
        public override string grab()
        {
            return "pick up";
        }

        public override string hit()
        {
            return "slam!";
        }

        public override List<string> execute()
        {
            List<string> list1 = new List<string>();
            list1.Add(move());
            list1.Add(grab());
            list1.Add(hit());

            return list1;
        }
    }

    public class Skill : IDistinctAction
    {
        public override string grab()
        {
            return "hold collar";
        }

        public override string hit()
        {
            return "knee! knee!! knee!!!";
        }

        public override List<string> execute()
        {

            List<string> list1 = new List<string>();
            list1.Add(move());
            list1.Add(grab());
            list1.Add(hit());
            return list1;
        }
    }

}