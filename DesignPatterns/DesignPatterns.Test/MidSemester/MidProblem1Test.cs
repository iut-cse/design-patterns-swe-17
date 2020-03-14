using DesignPatterns.MidSemester;
using Xunit;

namespace DesignPatterns.Test.MidSemester
{
    public class MidProblem1Test
    {
        [Fact]
        void Punch()
        {
            Ratul ratul = new Ratul(new Punch(), new PowerAction());
            Assert.Equal("punch", ratul.ExecuteCloseAction());
        }

        [Fact]
        void Kick()
        {
            Ratul ratul = new Ratul(new Kick(), new SkillAction());
            Assert.Equal("kick", ratul.ExecuteCloseAction());
        }

        [Fact]
        void Head()
        {
            Ratul ratul = new Ratul(new Head(), new PowerAction());
            Assert.Equal("head head", ratul.ExecuteCloseAction());
        }

        [Fact]
        void Power()
        {
            Ratul ratul = new Ratul(new Head(), new PowerAction());
            Assert.Equal(new[] { "move", "pick up", "slam!" }, ratul.ExecuteDistantAction());
        }

        [Fact]
        void Skill()
        {
            Ratul ratul = new Ratul(new Head(), new SkillAction());
            Assert.Equal(new[] { "move", "hold collar", "knee! knee!! knee!!!" }, ratul.ExecuteDistantAction());
        }
    }
}
