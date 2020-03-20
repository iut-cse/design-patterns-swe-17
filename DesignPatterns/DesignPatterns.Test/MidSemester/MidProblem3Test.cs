using DesignPatterns.MidSemester;
using Xunit;

namespace DesignPatterns.Test.MidSemester
{
    public class MidProblem3Test
    {
        [Fact]
        void DoTest()
        {
            Preference instance1 = Preference.getInstance();
            instance1.SetPreference("123","abc");
            string abcValue = instance1.GetPreference("abc");
            Assert.Equal("123", abcValue);
        }
    }
}
