using DesignPatterns.Reports;
using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Test.Reports.Kpis;
using Xunit;

namespace DesignPatterns.Test._Demos
{
    public class ReportDemo
    {
        [Fact]
        void Demo()
        {
            var data = TestData.CreateData();
            var table = new ReportTable(data, "left");
            var sb = new StringBuilder();
            table.Render(sb);
            new OutputFile().Write(sb.ToString());
        }
    }
}
