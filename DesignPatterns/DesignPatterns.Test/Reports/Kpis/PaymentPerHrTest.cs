using DesignPatterns.Reports.Kpis;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DesignPatterns.Test.Reports.Kpis
{
    public class PaymentPerHrTest
    {
        [Fact]
        public void Monday()
        {
            var data = TestData.CreateData();
            var tch = new PaymentPerHrKPI(data, DayOfWeek.Monday);
            var output = tch.Calculate();

            Assert.Equal(577.7777777777778, output["Physics"]);
           
        }
    }
}
