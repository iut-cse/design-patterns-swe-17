using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public class Ratul
    {
        ICloseAction closeAction;
        DistantAction distantAction;

        public Ratul(ICloseAction closeAction,DistantAction distantAction)
        {
            this.closeAction = closeAction;
            this.distantAction = distantAction;



        }
        public string ExecuteCloseAction()
        {
            return closeAction.PerformCloseAction();
        }

        public IEnumerable<string> ExecuteDistantAction()
        {
            // you can return a array or list of string. Both array and list are subtypes of IEnumerable
            // However, there is a thing called `yield return` in C#.
            // Using it would be "cool"
            // Make sure you understand it if you choose to use it.
            return distantAction.templateMethodAction() ;
        }
    }
    public interface ICloseAction
    {
        public string PerformCloseAction();

    }
    public class Punch : ICloseAction
    {
        public string PerformCloseAction()
        {
            return "punch";
        }
    }
    public class Kick : ICloseAction
    {
        public string PerformCloseAction()
        {
            return "kick";
        }
    }
    public class Head : ICloseAction
    {
        public string PerformCloseAction()
        {
            return "head head";
        }
    }
    public abstract class DistantAction
    {
        public  IEnumerable<string> templateMethodAction() {
            IEnumerable<string> action = new string[] {move(),grab(),hit() };
            return action;
            

        }
         public string move()
        {
            return "move";
        }
        abstract public string grab();
        abstract public string hit();
    }
    public class Power : DistantAction
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
    public class Skill : DistantAction
    {
        public override string grab()
        {
            return "hold collar";
        }

        public override string hit()
        {
            return "knee! knee!! knee!!!";
        }


    }

}
