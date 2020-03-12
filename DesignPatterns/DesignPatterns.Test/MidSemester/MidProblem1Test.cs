using DesignPatterns.MidSemester;
using Xunit;

namespace DesignPatterns.Test.MidSemester
{
    public class MidProblem1Test
    {
        [Fact]
        void Punch()
        {
            ICloseAction punch =new Punch();
            Ratul ratul = new Ratul(punch,null);
            Assert.Equal("punch", ratul.ExecuteCloseAction());
        }

        [Fact]
        void Kick()
        {
            ICloseAction kick = new Kick();
            Ratul ratul = new Ratul(kick, null);
            Assert.Equal("kick", ratul.ExecuteCloseAction());
        }

        [Fact]
        void Head()
        {
            ICloseAction head = new Head();
            Ratul ratul = new Ratul(head, null);
          
            Assert.Equal("head head", ratul.ExecuteCloseAction());
        }

        [Fact]
        void Power()
        {
            DistantAction power = new Power();
            Ratul ratul = new Ratul(null,power);
            Assert.Equal(new[] { "move", "pick up", "slam!" }, ratul.ExecuteDistantAction());
        }

        [Fact]
        void Skill()
        {
            DistantAction skill = new Skill();
            Ratul ratul = new Ratul(null, skill);
            Assert.Equal(new[] { "move", "hold collar", "knee! knee!! knee!!!" }, ratul.ExecuteDistantAction());
        }
    }
}
