using DesignPatterns.MidSemester;
using Xunit;

namespace DesignPatterns.Test.MidSemester
{
    public class MidProblem3Test
    {
        [Fact]
        void DoTest()
        {
            // initialize correctly
            Preference instance1 = Preference.Instance;
            // set value "123" with key "abc"
            instance1.setPreference("abc", "123");
            // get with key "abc";
            string abcValue = instance1.getPreference("abc"); 
            Assert.Equal("123", abcValue);


            // initialize correctly
            Preference instance2 = Preference.Instance;
            // set value "567" with key "abc" in instance2.
            instance2.setPreference("abc", "567");
            // get value with key "abc" from instance1.
            string abcValue2 = instance1.getPreference("abc"); 
            Assert.Equal("567", abcValue2);
        }
    }
}
