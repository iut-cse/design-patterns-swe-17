using DesignPatterns.MidSemester;
using Xunit;

namespace DesignPatterns.Test.MidSemester
{
    public class MidProblem1Test
    {
        [Fact]
        void Punch()
        {
            IcloseAction action = new Punchclose();
            Ratul ratul = new Ratul(action);
            Assert.Equal("punch", ratul.ExecuteCloseAction());
        }

        [Fact]
        void Kick()
        {
            IcloseAction action = new Kickclose();
            Ratul ratul = new Ratul(action);
            Assert.Equal("kick", ratul.ExecuteCloseAction());
        }

        [Fact]
        void Head()
        {
            IcloseAction action = new Headclose();
            Ratul ratul = new Ratul(action);
            Assert.Equal("head head", ratul.ExecuteCloseAction());
        }

        [Fact]
        void Power()
        {
            DistantAction action = new Powerdistant();
            Ratul ratul = new Ratul(action);
            Assert.Equal(new[] { "move", "pick up", "slam!" }, ratul.ExecuteDistantAction());
        }

        [Fact]
        void Skill()
        {
            DistantAction action = new Skilldistant();
            Ratul ratul = new Ratul(action);
            Assert.Equal(new[] { "move", "hold collar", "knee! knee!! knee!!!" }, ratul.ExecuteDistantAction());
        }
    }
}
