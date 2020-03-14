using DesignPatterns.MidSemester.Problem_3;
using Xunit;

namespace DesignPatterns.Test.MidSemester
{
    public class MidProblem3Test
    {
        [Fact]
        void DoTest()
        {
            Preference instance1 = Preference.getInstance(); // initialized correctly
            instance1.SetPreference("abc", "123");
            // set value "123" with key "abc"
            string abcValue = instance1.GetPreference("abc"); // get with key "abc";
            Assert.Equal("123", abcValue);

            Preference instance2 = Preference.getInstance();
            instance2.SetPreference("abc","567");// initialize correctly
            // set value "567" with key "abc" in instance2.
            string abcValue2 = instance1.GetPreference("abc");
            // get value with key "abc" from instance1.
            Assert.Equal("567", abcValue2);
            // assert
        }
    }
}
