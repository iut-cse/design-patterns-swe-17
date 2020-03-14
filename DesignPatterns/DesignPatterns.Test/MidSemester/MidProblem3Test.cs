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
            // set value "123" with key "abc"
           
            instance1.SetPreference("abc", "123"); // get with key "abc";
            string abcValue = instance1.GetPreference("abc");
            Assert.Equal("123", abcValue);

            Preference instance2 = Preference.GetInstance(); // initialize correctly
            // set value "567" with key "abc" in instance2.
            // get value with key "abc" from instance1.
            // assert
            instance2.SetPreference("abc", "567");
            string abcValue2 = instance2.GetPreference("abc");
            Assert.Equal("567", abcValue2);
        }
    }
}
