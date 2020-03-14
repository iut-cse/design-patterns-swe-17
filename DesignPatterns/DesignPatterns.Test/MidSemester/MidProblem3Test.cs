using Xunit;
using DesignPatterns.MidSemester.Task3;

namespace DesignPatterns.Test.MidSemester
{
    public class MidProblem3Test
    {
        [Fact]
        void DoTest()
        {
            Preference instance1 = Preference.GetInstance(); // initialize correctly
            // set value "123" with key "abc"
            instance1.SetPreference("abc", "123");
            string value1 = instance1.GetPreference("abc"); // get with key "abc";
            Assert.Equal("123", value1);

            Preference instance2 = Preference.GetInstance(); // initialize correctly
            // set value "567" with key "abc" in instance2.
            // get value with key "abc" from instance1.
            // assert
            instance2.SetPreference("abc", "567");
            string value2 = instance1.GetPreference("abc"); // get with key "abc";
            Assert.Equal("567", value2);
        }
    }
}
