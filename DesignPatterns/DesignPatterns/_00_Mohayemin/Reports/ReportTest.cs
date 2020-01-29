using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Xunit.Abstractions;

namespace DesignPatterns._00_Mohayemin.Reports
{
    public class ReportTableTest
    {
        private readonly ITestOutputHelper output;
        private readonly List<ClassHour> data;

        public ReportTableTest(ITestOutputHelper output)
        {
            this.output = output;
            
            data = new List<ClassHour>
            {
                new ClassHour("Physics", new DateTime(2020, 1, 20), 4),
                new ClassHour("Physics", new DateTime(2020, 1, 27), 5),
                new ClassHour("Chemistry", new DateTime(2020, 1, 21), 2),
                new ClassHour("Math", new DateTime(2020, 1, 22), 6),
                new ClassHour("English", new DateTime(2020, 1, 23), 6),
                new ClassHour("English", new DateTime(2020, 1, 16), 1),
            };
        }

        [Fact]
        void PrintOutput()
        {
            ReportTable table = new ReportTable(data);
            StringBuilder sb = new StringBuilder();
            table.Render(sb);
            output.WriteLine("\n" + sb.ToString());
            Assert.True(false);
        }

        [Fact]
        void ColumnWidth()
        {
            ReportTable table = new ReportTable(data);
            var width = table.cols[0].Width;
            Assert.Equal(10, width);
        }
    }
}


/**
 * Your Student ID:
 * Your Nick Name:
 */
