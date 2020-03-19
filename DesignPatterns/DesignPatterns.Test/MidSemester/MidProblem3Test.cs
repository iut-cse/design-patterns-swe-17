using DesignPatterns.MidSemester.Problem3;
using Xunit;

namespace DesignPatterns.Test.MidSemester.Problem3
{
    public class MidProblem3Test
    {
        [Fact]
        void DoTest()
        {
            Preference instance1 = Preference.getInstance(); // initialize correctly
            // set value "123" with key "abc"
            instance1.setPreference("abc","123");
            string abcValue = instance1.getPreference("abc"); // get with key "abc";
            Assert.Equal("123", abcValue);

            Preference instance2 = Preference.getInstance(); // initialize correctly
            instance1.setPreference("abc", "567"); // set value "567" with key "abc" in instance2.
            string abcvalue = instance1.getPreference("abc");// get value with key "abc" from instance1.
            Assert.Equal("567", abcvalue);// assert
        }
    }
}
