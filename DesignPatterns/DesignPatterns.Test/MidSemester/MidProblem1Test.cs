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
            Ratul ratul = new Ratul(action);
            Assert.Equal("punch", ratul.ExecuteCloseAction());
        }


        [Fact]
        void Kick()
        {
            ICloseAction action = new kick();
            Ratul ratul = new Ratul(action);
            Assert.Equal("kick", ratul.ExecuteCloseAction());
        }

        [Fact]
        void Head()
        {
            ICloseAction action = new head();
            Ratul ratul = new Ratul(action);
            Assert.Equal("head head", ratul.ExecuteCloseAction());
        }

        [Fact]
        void Power()
        {
            IDistantAction action = new Power();
            Ratul ratul = new Ratul(action);
            Assert.Equal(new[] { "move", "pick up", "slam!" }, ratul.ExecuteDistantAction());
        }

        [Fact]
        void Skill()
        {
            IDistantAction action = new Skill();
            Ratul ratul = new Ratul(action);
            Assert.Equal(new[] { "move", "hold collar", "knee! knee!! knee!!!" }, ratul.ExecuteDistantAction());
        }
    }
}
