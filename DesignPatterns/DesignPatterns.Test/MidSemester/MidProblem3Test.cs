using DesignPatterns.MidSemester;
using Xunit;

namespace DesignPatterns.Test.MidSemester
{
    public class MidProblem3Test
    {
        [Fact]
        void DoTest()
        {
            Preference instance1 = Preference.getobject(); // initialize correctly
            instance1.setpreferecne("abc", "123");
            // set value "123" with key "abc"
            // get with key "abc";
            string abcValue = instance1.getpreference("abc");
            Assert.Equal("123", abcValue);

            Preference instance2 = Preference.getobject(); // initialize correctly
            instance1.setpreferecne("abc", "567");
            string abcValue2 = instance2.getpreference("abc"); // get with key "abc";
            Assert.Equal("567", abcValue2);
            // set value "567" with key "abc" in instance2.
            // get value with key "abc" from instance1.
            // assert
        }
    }
}
