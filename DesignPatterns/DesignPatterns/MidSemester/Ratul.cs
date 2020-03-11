using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public class Ratul
    {
        IcloseAction icloseaAction;
        distantAction distantA;
        public void setCloseAction(IcloseAction iclose)
        {
            icloseaAction = iclose;
        }
        public void setDistantAction(distantAction distant)
        {
            distantA = distant;
        }
        public string ExecuteCloseAction()
        {
            return icloseaAction.doCloseAction();
        }

        public IEnumerable<string> ExecuteDistantAction()
        {
            // you can return a array or list of string. Both array and list are subtypes of IEnumerable
            // However, there is a thing called `yield return` in C#.
            // Using it would be "cool"
            // Make sure you understand it if you choose to use it.
            return distantA.TemplateAction();
        }
    }
    public interface IcloseAction
    {
        public string doCloseAction();
    }
    public class Punch : IcloseAction
    {
        public string doCloseAction()
        {
            return "punch";
        }
    }
    public class Kick : IcloseAction
    {
        public string doCloseAction()
        {
            return "kick";
        }
    }
    public class Head : IcloseAction
    {
        public string doCloseAction()
        {
            return "head head";
        }
    }
    public abstract class distantAction
    {
        public IEnumerable<string> TemplateAction()
        {
            yield return move();
            yield return grab();
            yield return hit();
        }
        private string move()
        {
            return "move";
        }
        protected abstract string grab();
        protected abstract string hit();


    }
    public class Power : distantAction
    {
        protected override string grab()
        {
            return "pick up";
        }

        protected override string hit()
        {
            return "slam!";
        }
    }

    public class Skill : distantAction
    {
        protected override string grab()
        {
            return "hold collar";
        }

        protected override string hit()
        {
            return "knee! knee!! knee!!!";
        }
    }
}
