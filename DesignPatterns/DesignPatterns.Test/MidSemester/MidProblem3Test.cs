﻿using DesignPatterns.MidSemester;
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
            instance1.setPreference("abc", "123");
            string abcValue = instance1.getPreference("abc"); // get with key "abc";
            Assert.Equal("123", abcValue);

            Preference instance2 = Preference.GetInstance(); // initialize correctly
            instance2.setPreference("abs", "576"); // set value "567" with key "abc" in instance2.
            string abcVAL = instance2.getPreference("abs"); // get value with key "abc" from instance1.*/
            Assert.Equal("576", abcVAL);

           
        }
    }
}
