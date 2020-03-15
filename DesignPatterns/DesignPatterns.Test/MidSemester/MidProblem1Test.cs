using DesignPatterns.MidSemester;
using Xunit;

namespace DesignPatterns.Test.MidSemester
{
    [Fact]

    void Punch()

    {

        Ratul ratul = new Ratul(new punch(), new skill());

        Assert.Equal("punch", ratul.ExecuteCloseAction());

    }



    [Fact]

    void Kick()

    {

        Ratul ratul = new Ratul(new Kick(), new skill());

        Assert.Equal("kick", ratul.ExecuteCloseAction());

    }



    [Fact]

    void head()

    {

        Ratul ratul = new Ratul(new head(), new skill());

        Assert.Equal("head head", ratul.ExecuteCloseAction());

    }



    [Fact]

    void Power()

    {

        Ratul ratul = new Ratul(new Kick(), new Power());

        Assert.Equal(new[] { "move", "pick up", "slam!" }, ratul.ExecuteDistantAction());

    }



    [Fact]

    void skill()

    {

        Ratul ratul = new Ratul(new Kick(), new skill());

        Assert.Equal(new[] { "move", "hold collar", "knee! knee!! knee!!!" }, ratul.ExecuteDistantAction());

    }

}
}
