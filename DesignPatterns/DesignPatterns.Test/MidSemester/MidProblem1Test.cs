using DesignPatterns.MidSemester;
using DesignPatterns.MidSemester.task_1;
using Xunit;

namespace DesignPatterns.Test.MidSemester
{
    public class MidProblem1Test
    {
        [Fact]
        void Punch()
        {
            Ratul ratul = new Ratul(new Punch(), null);
            Assert.Equal("punch", ratul.ExecuteCloseAction());
        }

        [Fact]
        void Kick()
        {
            Ratul ratul = new Ratul(new Head(), null);
            Assert.Equal("kick", ratul.ExecuteCloseAction());
        }

        [Fact]
        void Head()
        {
            Ratul ratul = new Ratul(new Head(), null);
            Assert.Equal("head head", ratul.ExecuteCloseAction());
        }

        [Fact]
        void Power()
        {
            Ratul ratul = new Ratul(null, new DesignPatterns.MidSemester.task_1.Power());
            Assert.Equal(new[] { "move", "pick up", "slam!" }, ratul.ExecuteDistantAction());
        }

        [Fact]
        void Skill()
        {
            Ratul ratul = new Ratul(null, new Skill());
            Assert.Equal(new[] { "move", "hold collar", "knee! knee!! knee!!!" }, ratul.ExecuteDistantAction());
        }
    }
}
