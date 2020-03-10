using DesignPatterns.MidSemester;
using Xunit;

namespace DesignPatterns.Test.MidSemester
{
    public class MidProblem1Test
    {
        [Fact]
        void Punch()
        {
            Ratul ratul = null;
            Assert.Equal("punch", ratul.ExecuteCloseAction(new Punch()));
        }

        [Fact]
        void Kick()
        {
            Ratul ratul = null;
            Assert.Equal("kick", ratul.ExecuteCloseAction(new Kick()));
        }

        [Fact]
        void Head()
        {
            Ratul ratul = null;
            Assert.Equal("head head", ratul.ExecuteCloseAction(new Head()));
        }

        [Fact]
        void Power()
        {
            Ratul ratul = null;
            Assert.Equal(new[] { "move", "pick up", "slam!" }, ratul.ExecuteDistantAction(new SkillDistantAction()));
        }

        [Fact]
        void Skill()
        {
            Ratul ratul = null;
            Assert.Equal(new[] { "move", "hold collar", "knee! knee!! knee!!!" }, ratul.ExecuteDistantAction(new PowerDistantAction()));
        }
    }
}
