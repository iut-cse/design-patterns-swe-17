using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public class Ratul
    {
        IcloseAction closeaction;
        DistantAction distantaction;

        public Ratul(IcloseAction closeaction)
        {
            this.closeaction = closeaction;
        }
        public Ratul(DistantAction distantaction)
        {
            this.distantaction = distantaction;
        }
        public string ExecuteCloseAction()
        {
            return closeaction.Action();
        }

        public IEnumerable<string> ExecuteDistantAction()
        {
            // you can return a array or list of string. Both array and list are subtypes of IEnumerable
            // However, there is a thing called `yield return` in C#.
            // Using it would be "cool"
            // Make sure you understand it if you choose to use it.
            return distantaction.TemplateAction();
        }
    }

    public interface IcloseAction
    {
        public string Action();
      
    }
    public class Punchclose : IcloseAction
    {
        public string Action()
        {
            return "punch";
        }
    }
    public class Kickclose:IcloseAction
    {
        public string Action()
        {
            return "kick";
        }
    }
    public class Headclose : IcloseAction
    {
        public string Action()
        {
            return "head head";
        }
    }
    public abstract class DistantAction
    {
        public IEnumerable<string> TemplateAction()
        {
            yield return this.Move();
            yield return this.Grab();
            yield return this.Hit();
        }
        public string Move()
        {
            return "move";
        }
        public abstract string Grab();
        public abstract string Hit();
    }
    public class Powerdistant : DistantAction
    {
        public override string Grab()
        {
            return "pick up";
        }
        public override string Hit()
        {
            return "slam!";
        }
    }
    public class Skilldistant:DistantAction
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
