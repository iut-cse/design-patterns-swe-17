using DesignPatterns.MidSemester;
using Xunit;

namespace DesignPatterns.Test.MidSemester
{
    public class MidProblem3Test
    {
        [Fact]
        void DoTest()
        {

            Preference obj1 = Preference.GetpreferenceInstance(); // initialize correctly
            obj1.setPreference("abc", "123");// set value "123" with key "abc"
            string abckey1 = obj1.getPreference("abc"); // get with key "abc";
            Assert.Equal("123", abckey1);

            Preference obj2 = Preference.GetpreferenceInstance(); // initialize correctly.
            obj2.setPreference("abc", "567"); // set value "567" with key "abc" in instance2
            string abckey2 = obj1.getPreference("abc");// get value with key "abc" from instance1.
            Assert.Equal("567", abckey2);// assert
        }
    }
}
