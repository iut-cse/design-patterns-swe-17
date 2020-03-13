using System;
using DesignPatterns.MidSemester;
using Xunit;
namespace DesignPatterns.MidSemesterTests
{
    public class Mid_problemTestCase
    {
        [Fact]
        void DoTest()
        {
            Preference case1 = Preference.getInstance(); 
            case1.SetPreference("170042044", "rafsan");
            string abcValue = case1.GetPreference("rafsan");
            Assert.Equal("170042044", abcValue);

          
            Preference case2 = Preference.getInstance();
            case2.SetPreference("1700420100", "rafsan");
            string Value = case1.GetPreference("rafsan");
            Assert.Equal("1700420100", Value);
        }
    }
}
}
