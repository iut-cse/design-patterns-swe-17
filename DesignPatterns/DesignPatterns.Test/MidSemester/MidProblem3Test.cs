﻿using DesignPatterns.MidSemester;
using Xunit;

namespace DesignPatterns.Test.MidSemester
{
    public class MidProblem3Test
    {
        [Fact]
        void DoTest()
        {
            Preference instance1 = Preference.getInstance(); // initialize correctly
            instance1.setPreference("123","abc");// set value "123" with key "abc"
            string abcValue = instance1.getPreference("abc"); // get with key "abc";
            Assert.Equal("123", abcValue);

           // Preference instance2 = null; // initialize correctly
                                         // set value "567" with key "abc" in instance2.
                                         // get value with key "abc" from instance1.
                                         // assert
            Preference instance2 = Preference.getInstance(); 
            instance2.setPreference("567", "abc");
            string Value = instance1.getPreference("abc"); 
            Assert.Equal("567", Value);
        }
    }
}