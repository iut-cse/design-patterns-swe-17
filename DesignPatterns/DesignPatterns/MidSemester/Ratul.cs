using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public class Ratul
    {
        public ICloseAction CurrentCloseAction;
        public DistantAction CurrentDistantAction;


        public Ratul(ICloseAction currentCloseAction, DistantAction currentDistantAction)
        {
            this.CurrentCloseAction = currentCloseAction;
            this.CurrentDistantAction = currentDistantAction;
        }

        public string ExecuteCloseAction()
        {
            return CurrentCloseAction.DoAction();
        }

        public IEnumerable<string> ExecuteDistantAction()
        { 
            return CurrentDistantAction.AllDistantAction();
        }
    }
    public interface ICloseAction
    {
        string DoAction();
    }
    public class Punch : ICloseAction
    {
        public string DoAction()
        {
            return "PUNCH";
        }
    }
    public class Kick : ICloseAction
    {
        public string DoAction()
        {
            return "KICK";
        }
    }
    public class Head : ICloseAction
    {
        public string DoAction()
        {
            return "HEAD HEAD";
        }
    }
    public abstract class DistantAction
    {
        public List<string> ActionList = new List<string>();

        public IEnumerable<string> AllDistantAction()
        {
            ActionList.Add(Move());
            ActionList.Add(Grab());
            ActionList.Add(Hit());

            return ActionList;
        }

        public string Move()
        {
            return "move";
        }

        public abstract string Grab();
        public abstract string Hit();
    }
    public class Power : DistantAction
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
    public class Skill : DistantAction
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
