using DesignPatterns.MidSemester;
using Xunit;

namespace DesignPatterns.Test.MidSemester
{
    public class MidProblem3Test
    {
        [Fact]
        void DoTest()
        {
            Preference instance1 = Preference.GetInstance();        // initialize correctly
            instance1.setPreference("abc", "123");                  // set value "123" with key "abc"
            string abcValue = instance1.getPreference("abc");       // get with key "abc";
            Assert.Equal("123", abcValue);

            Preference instance2 = Preference.GetInstance();        // initialize correctly
            instance2.setPreference("abc", "567");                  // set value "567" with key "abc" in instance2.
            string new_abcValue = instance1.getPreference("abc");   // get value with key "abc" from instance1.
            Assert.Equal("567", new_abcValue);                      // assert
        }
    }
}
