using System;
using DesignPatterns.MidSemester;
using Xunit;
namespace DesignPatterns.MidSemesterTests
{
    public class Mid_problem1TesCase
    {
        [Fact]
        void Punch()
        {
            IClose_action action = new punch();
            Ratul ratul = new Ratul(action);
            Assert.Equal("punch_enemy", ratul.ExecuteCloseAction());
        }


        [Fact]
        void Kick()
        {
            IClose_action action = new kick();
            Ratul ratul = new Ratul(action);
            Assert.Equal("kick_enemy", ratul.ExecuteCloseAction());
        }

        [Fact]
        void Head()
        {
            IClose_action action = new head();
            Ratul ratul = new Ratul(action);
            Assert.Equal("headHit_enemy", ratul.ExecuteCloseAction());
        }

        [Fact]
        void Power()
        {
            IDistant_action action = new Power();
            Ratul ratul = new Ratul(action);
            Assert.Equal(new[] { "move", "pickUp_enemy", "slam_enemy" }, ratul.ExecuteDistantAction());
        }

        [Fact]
        void Skill()
        {
            IDistant_action action = new Skill();
            Ratul ratul = new Ratul(action);
            Assert.Equal(new[] { "move", "hold collar", "knee_enemy" }, ratul.ExecuteDistantAction());
        }
    }
}
