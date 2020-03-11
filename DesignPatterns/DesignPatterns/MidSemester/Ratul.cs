using System.Collections.Generic;

namespace DesignPatterns.MidSemester
{
    public class Ratul
    {
        CloseAction closeAction;
        DistantAction distantAction;
        public Ratul(string action)
        {

            if (action == "punch")
            {
                closeAction = new Punch();
            }
            if (action == "kick")
            {
                closeAction = new Kick();
            }
            if (action == "head")
            {
                closeAction = new Head();
            }
            if (action == "power")
            {
                distantAction = new Power();
            }
            if (action == "skill")
            {
                distantAction = new Skill();
            }
        }
        public string ExecuteCloseAction()
        {
            return closeAction.execute(); ;
        }

        public IEnumerable<string> ExecuteDistantAction()
        {
            return distantAction.actionTemplate(); ;
        }
    }

    public interface CloseAction
    {
        public string execute();
    }

    class Punch : CloseAction
    {
        public string execute()
        {
            return "punch";
        }
    }
    public class Kick : CloseAction
    {
        public string execute()
        {
            return "kick";
        }
    }
    public class Head : CloseAction
    {
        public string execute()
        {
            return "head head";
        }
    }

    public abstract class DistantAction
    {
        public IEnumerable<string> actionTemplate()
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
