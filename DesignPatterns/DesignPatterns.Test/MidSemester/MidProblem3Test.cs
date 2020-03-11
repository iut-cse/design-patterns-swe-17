using DesignPatterns.MidSemester;
using Xunit;

namespace DesignPatterns.Test.MidSemester
{
    public class MidProblem3Test
    {
        [Fact]
        void DoTest()
        {
            Preference instance1 = Preference.GetInstance(); // initialize correctly
            instance1.SetPreference("abc", "123");
            // set value "123" with key "abc"
            string abcValue = instance1.GetPreference("abc"); // get with key "abc";
            Assert.Equal("123", abcValue);

            Preference instance2 = Preference.GetInstance(); // initialize correctly
            // set value "567" with key "abc" in instance2.
            instance2.SetPreference("abc", "567");
            // get value with key "abc" from instance1.
            string abcValue2 = instance1.GetPreference("abc");
            // assert
            Assert.Equal("567", abcValue2);
        }
    }
}
