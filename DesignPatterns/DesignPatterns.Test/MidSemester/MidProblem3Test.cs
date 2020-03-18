﻿using DesignPatterns.MidSemester;
using DesignPatterns.MidSemester.Task3;
using Xunit;

namespace DesignPatterns.Test.MidSemester
{
    public class MidProblem3Test
    {
        [Fact]
        void DoTest()
        {
            Preference pref1 = Preference.getInstance(); // initialize correctly
            // set value "123" with key "abc"
            pref1.setPreference("abc", "123");
            string abcValue = pref1.getPreference("abc"); // get with key "abc";
            Assert.Equal("123", abcValue);

            //Preference instance2 = null; // initialize correctly
            // set value "567" with key "abc" in instance2.
            // get value with key "abc" from instance1.
            // assert
        }
    }
}
