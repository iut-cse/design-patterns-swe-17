using DesignPatterns.MidSemester;
using Xunit;

namespace DesignPatterns.Test.MidSemester
{
    public class MidProblem3Test
    {
        [Fact]
        void DoTest()
        {
            Preference instance1 = Preference.getObj(); // Done initialize correctly
            instance1.setPreference("abc","123");// Done set value "123" with key "abc"
            string abcValue = instance1.getPreference("abc"); // Done get with key "abc";
            Assert.Equal("123", abcValue);

            Preference instance2 = Preference.getObj(); // Done initialize correctly
            instance2.setPreference("abc","567");
            string abcValue2 = instance1.getPreference("abc");
            Assert.Equal("567", abcValue2);
        }
    }
}
