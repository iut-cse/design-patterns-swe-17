using DesignPatterns.Reports;
using System;
using System.Collections.Generic;
using System.Text;
using DesignPatterns.Reports.Alignments;
using Xunit;

namespace DesignPatterns.Test._Demos
{
    public class ReportDemo
    {
        [Fact]
        void Demo()
        {
            var data = new List<ClassInfo>
            {
                new ClassInfo("Physics", new DateTime(2020, 1, 20), 4),
                new ClassInfo("Physics", new DateTime(2020, 1, 27), 5),
                new ClassInfo("Chemistry", new DateTime(2020, 1, 21), 2),
                new ClassInfo("Math", new DateTime(2020, 1, 22), 6),
                new ClassInfo("English", new DateTime(2020, 1, 23), 6),
                new ClassInfo("English", new DateTime(2020, 1, 16), 1),
            };
            ReportTable table = new ReportTable(data, new LeftAlignment());
            StringBuilder sb = new StringBuilder();
            table.Render(sb);
            new OutputFile().Write(sb.ToString());
        }
    }
}
