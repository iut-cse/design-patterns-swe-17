using DesignPatterns.MidSemester;
using Xunit;

namespace DesignPatterns.Test.MidSemester
{
    public class MidProblem1Test
    {
        [Fact]
        void Punch()
        {
            ICloseAction action = new punch();
            Ratul ratun = new Ratul(action);
            Assert.Equal("punch", ratun.ExecuteCloseAction());
        }


        [Fact]
        void Kick()
        {
            ICloseAction action = new kick();
            Ratul ratun = new Ratul(action);
            Assert.Equal("kick", ratun.ExecuteCloseAction());
        }

        [Fact]
        void Head()
        {
            ICloseAction action = new head();
            Ratul ratun = new Ratul(action);
            Assert.Equal("head head", ratun.ExecuteCloseAction());
        }

        [Fact]
        void Power()
        {
            IDistantAction action = new Power();
            Ratul ratun = new Ratul(action);
            Assert.Equal(new[] { "move", "pick up", "slam!" }, ratun.ExecuteDistantAction());
        }

        [Fact]
        void Skill()
        {
            IDistantAction action = new Skill();
            Ratul ratun = new Ratul(action);
            Assert.Equal(new[] { "move", "hold collar", "knee! knee!! knee!!!" }, ratun.ExecuteDistantAction());
        }
    }
}
