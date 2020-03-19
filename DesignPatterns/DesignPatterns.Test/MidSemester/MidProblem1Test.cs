using DesignPatterns.MidSemester;
using Xunit;

namespace DesignPatterns.Test.MidSemester
{
    public class MidProblem1Test
    {
        [Fact]
        void Punch()
        {
            IcloseAction act = new punch();
            Ratul ratul = new Ratul(act);
            Assert.Equal("punch", ratul.ExecuteCloseAction());
        }

        [Fact]
        void Kick()
        {
            IcloseAction act = new kick();
            Ratul ratul = new Ratul(act);
            Assert.Equal("kick", ratul.ExecuteCloseAction());
        }

        [Fact]
        void Head()
        {
            IcloseAction act = new head();
            Ratul ratul = new Ratul(act);
            Assert.Equal("head head", ratul.ExecuteCloseAction());
        }

        [Fact]
        void Power()
        {
            IdistantAction act = new poweract();
            Ratul ratul = new Ratul(act);
            Assert.Equal(new[] { "move", "pick up", "slam!" }, ratul.ExecuteDistantAction());
        }

        [Fact]
        void Skill()
        {
            IdistantAction act = new skillact();
            Ratul ratul = new Ratul(act);
            Assert.Equal(new[] { "move", "hold collar", "knee! knee!! knee!!!" }, ratul.ExecuteDistantAction());
        }
    }
}
