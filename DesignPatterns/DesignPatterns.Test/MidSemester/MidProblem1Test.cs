using DesignPatterns.MidSemester;
using Xunit;

namespace DesignPatterns.Test.MidSemester
{
    public class MidProblem1Test
    {
        [Fact]
        void Punch()
        {
            Ratul ratul = new Ratul(new Punch(), new Power());
            Assert.Equal("PUNCH", ratul.ExecuteCloseAction());
        }

        [Fact]
        void Kick()
        {
            Ratul ratul = new Ratul(new Kick(), new Power());
            Assert.Equal("KICK", ratul.ExecuteCloseAction());
        }

        [Fact]
        void Head()
        {
            Ratul ratul = new Ratul(new Head(), new Power());
            Assert.Equal("HEAD HEAD", ratul.ExecuteCloseAction());
        }

        [Fact]
        void Power()
        {
            Ratul ratul = new Ratul(new Head(), new Power());
            Assert.Equal(new[] { "move", "pick up", "slam!" }, ratul.ExecuteDistantAction());
        }

        [Fact]
        void Skill()
        {
            Ratul ratul = new Ratul(new Head(), new Skill());
            Assert.Equal(new[] { "move", "hold collar", "knee! knee!! knee!!!" }, ratul.ExecuteDistantAction());
        }
    }
}
