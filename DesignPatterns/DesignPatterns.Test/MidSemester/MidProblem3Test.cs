using DesignPatterns.MidSemester;
using Xunit;

namespace DesignPatterns.Test.MidSemester
{
    public class MidProblem3Test
    {
        [Fact]
        void DoTest()
        {
            Preference instance1 = Preference.Instantiate(); // initialize correctly
            instance1.setPreference("abc", "123");
            string abcValue = instance1.getPreference("abc"); // get with key "abc";
            Assert.Equal("123", abcValue);

            Preference instance2 = Preference.Instantiate(); // initialize correctly
            instance1.setPreference("abc", "567");
            abcValue = instance1.getPreference("abc"); // get with key "abc";
            Assert.Equal("567", abcValue);
        }
    }
}
