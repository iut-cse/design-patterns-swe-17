using DesignPatterns.MidSemester;
using Xunit;

namespace DesignPatterns.Test.MidSemester
{
    public class MidProblem1Test
    {
        [Fact]
        void Punch()
        {
<<<<<<< Updated upstream
            Ratul ratul = null;
=======
            Ratul ratul = new Ratul(new PunceAction(), new PowerAction());
>>>>>>> Stashed changes
            Assert.Equal("punch", ratul.ExecuteCloseAction());
        }

        [Fact]
        void Kick()
        {
<<<<<<< Updated upstream
            Ratul ratul = null;
=======
            Ratul ratul = new Ratul(new KickAction(), new PowerAction());
>>>>>>> Stashed changes
            Assert.Equal("kick", ratul.ExecuteCloseAction());
        }

        [Fact]
        void Head()
        {
<<<<<<< Updated upstream
            Ratul ratul = null;
=======
            Ratul ratul = new Ratul(new HeadAction(), new PowerAction());
>>>>>>> Stashed changes
            Assert.Equal("head head", ratul.ExecuteCloseAction());
        }

        [Fact]
        void Power()
        {
           Ratul ratul = null;

            Ratul ratul = new Ratul(new PunceAction(), new PowerAction());

            Assert.Equal(new[] { "move", "pick up", "slam!" }, ratul.ExecuteDistantAction());
        }

        [Fact]
        void Skill()
        {
<<<<<<< Updated upstream
            Ratul ratul = null;
=======
            Ratul ratul = new Ratul(new PunceAction(), new SkillAction());
>>>>>>> Stashed changes
            Assert.Equal(new[] { "move", "hold collar", "knee! knee!! knee!!!" }, ratul.ExecuteDistantAction());
        }
    }
}
