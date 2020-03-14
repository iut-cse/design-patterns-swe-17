using DesignPatterns.MidSemester;
using Xunit;

namespace DesignPatterns.Test.MidSemester
{
    public class MidProblem3Test
    {
        [Fact]
        void DoTest()
        {
            Preference instance1 = Preference.getInstance();
            instance1.setPreference("abc", "123");
            
            string abcValue = instance1.getPreference("abc"); 
            Assert.Equal("123", abcValue);



            Preference instance2 = Preference.getInstance();
            instance2.setPreference("abc", "567");

            string abcValue2 = instance2.getPreference("abc");
            Assert.Equal("567", abcValue2);
            
        }
    }
}
