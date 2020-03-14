using DesignPatterns.MidSemester;
using Ext.Net;
using Xunit;

namespace DesignPatterns.Test.MidSemester
{
    public class MidProblem1Test
    {
        [Fact]
        void Punch()
        {
            CloseAction action = new Punch();
            Ratul ratul = new Ratul(action);
            Assert.Equal("punch", ratul.ExecuteCloseAction());
        }

        [Fact]
        void Kick()
        {
            CloseAction action = new Kick();
            Ratul ratul = new Ratul(action);
            Assert.Equal("kick", ratul.ExecuteCloseAction());
        }

        [Fact]
        void Head()
        {
            CloseAction action = new Head();
            Ratul ratul = new Ratul(action);
            Assert.Equal("head head", ratul.ExecuteCloseAction());
        }

        [Fact]
        void Power()
        {
            DistantAction action = new Power();
            Ratul ratul = new Ratul(action);
            Assert.Equal(new[] { "move", "pick up", "slam!" }, ratul.ExecuteDistantAction());
        }

        [Fact]
        void Skill()
        {
            DistantAction action = new Skill();
            Ratul ratul = new Ratul(action);
            Assert.Equal(new[] { "move", "hold collar", "knee! knee!! knee!!!" }, ratul.ExecuteDistantAction());
        }
    }
}
