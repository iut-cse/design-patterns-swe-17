using DesignPatterns.MidSemester;
using Xunit;

namespace DesignPatterns.Test.MidSemester
{
    public class MidProblem3Test
    {
        [Fact]
        void DoTest()
        {
            Preference instance1 = Preference.getObject(); // initialize correctly
            // set value "123" with key "abc"
            string abcValue = "123"; // get with key "abc";
            instance1.setPreference("abc", "123");
            Assert.Equal(abcValue, instance1.getPreference("abc"));

            Preference instance2 = Preference.getObject();// initialize correctly
            string abcValue2 = "567";// set value "567" with key "abc" in instance2.
            instance2.setPreference("abc", "567");// get value with key "abc" from instance1.
            Assert.Equal(abcValue2, instance2.getPreference("abc"));// assert
        }
    }
}
