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
            instance1.setPreference("abc", "123");
            // set value "123" with key "abc"
            string abcValue = instance1.getPrefence("abc"); // get with key "abc";
            Assert.Equal("123", abcValue);

            Preference instance2 = Preference.getInstance();
            instance2.setPrefence("abc", "567");
            string abcValue1 = instance2.getPrefence("abc");
            Assert.Equal("567", abcValue1);
            // initialize correctly
            // set value "567" with key "abc" in instance2.
            // get value with key "abc" from instance1.
            // assert
        }
    }
}
