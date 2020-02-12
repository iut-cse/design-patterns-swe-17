using DesignPatterns.Reports;
using DesignPatterns.Reports.Kpis;
using System;
using System.Collections.Generic;
using Xunit;


namespace DesignPatterns.Test.Reports.Kpis
{
    public class PaymentperHourTest
    {
        [Fact]
        public void Monday()
        {
            var data = TestData.CreateData();
            var tch = new PaymentperHour(data, DayOfWeek.Monday);
            var output = tch.Calculate();

            Assert.Equal(5200.0/9, output["Physics"]);
            Assert.Equal(2100.0/6, output["Bangla"]);
        }


        [Fact]
        public void Tuesday()
        {
            var data = TestData.CreateData();
            var tch = new PaymentperHour(data, DayOfWeek.Tuesday);
            var output = tch.Calculate();

            Assert.Equal(400.0/5, output["Physics"]);
            Assert.Equal(100.0/2, output["Chemistry"]);
        }
    }
}
