using DesignPatterns.MidSemester.Problem3;
using Xunit;

namespace DesignPatterns.Test.MidSemester
{
    public class MidProblem3Test
    {
        [Fact]
        void DoTest()
        {
            Preference instance1 = Preference.GetInstance();
            instance1.SetPreference("abc", "123");
            string abcValue = instance1.GetPreference("abc");
            Assert.Equal("123", abcValue);

            Preference instance2 = Preference.GetInstance();
            instance2.SetPreference("abc", "567");
            var newAbcValue = instance1.GetPreference("abc");
            Assert.Equal("567", newAbcValue);
        }
    }
}
