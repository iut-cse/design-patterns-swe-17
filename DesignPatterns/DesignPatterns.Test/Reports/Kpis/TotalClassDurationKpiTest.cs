using DesignPatterns.Reports;
using DesignPatterns.Reports.Kpis;
using System;
using System.Collections.Generic;
using Xunit;

namespace DesignPatterns.Test.Reports.Kpis
{
    public class TotalClassDurationKpiTest
    {
        [Fact]
        public void Monday()
        {
            var data = TestData.CreateData();
            var tch = new TotalClassDurationKpi(data, DayOfWeek.Monday);
            var output = tch.Calculate();

            Assert.Equal(9, output["Physics"]);
            Assert.Equal(6, output["Bangla"]);
        }


        [Fact]
        public void Tuesday()
        {
            var data = TestData.CreateData();
            var tch = new TotalClassDurationKpi(data, DayOfWeek.Tuesday);
            var output = tch.Calculate();

            Assert.Equal(5, output["Physics"]);
            Assert.Equal(2, output["Chemistry"]);
        }
    }
}
