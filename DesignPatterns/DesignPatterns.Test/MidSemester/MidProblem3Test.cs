using DesignPatterns.MidSemester;
using Xunit;

namespace DesignPatterns.Test.MidSemester
{
    public class MidProblem3Test
    {
        [Fact]
        void DoTest()
        {
            Preference instance1 = Preference.getInstance(); // initialize correctly
            // set value "123" with key "abc"
            instance1.setPreferance("123", "abc");
            string abcValue = instance1.getPreferance("abc"); // get with key "abc";
            Assert.Equal("123", abcValue);

            Preference instance2 = Preference.setPreferance(); // initialize correctly
            // set value "567" with key "abc" in instance2.
            // get value with key "abc" from instance1.
            // assert
        }
    }
}
