using static System.DayOfWeek;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace DesignPatterns._00_Mohayemin.Reports
{
    class ReportTable: IRenderable
    {
        private readonly List<ReportRow> rows;

        public ReportTable(List<ClassHour> classHours)
        {
            var departments = classHours.ConvertAll(ch => ch.department).Distinct().ToList();
            rows = departments.ConvertAll(d => new ReportRow(d, classHours.FindAll(ch => ch.department == d)));
        }

        public void Render(StringBuilder builder)
        {
            foreach (var row in rows)
            {
                row.Render(builder);
                builder.Append("\n");
            }
        }
    }

    class ReportRow: IRenderable
    {
        private readonly ReportCell departmentCell;
        private readonly List<ReportCell> dayCells;
        private readonly ReportCell totalCell;

        public ReportRow(string department, List<ClassHour> classHours)
        {
            departmentCell = new ReportCell(department);
            dayCells = new List<ReportCell>();
            var groupedClassHours = classHours.GroupBy(ch => ch.date.DayOfWeek).ToDictionary(g => g.Key, g => g.Sum(ch => ch.durationHours));
            foreach (var dow in AllDaysOfWeek.FromMonday)
            {
                var cellValue = groupedClassHours.ContainsKey(dow) ? groupedClassHours[dow] : 0;
                dayCells.Add(new ReportCell(cellValue.ToString()));
            }

            totalCell = new ReportCell(classHours.Sum(ch => ch.durationHours).ToString());
        }

        public void Render(StringBuilder builder)
        {
            builder.Append("|");
            departmentCell.Render(builder);
            foreach (var dc in dayCells)
                dc.Render(builder);

            totalCell.Render(builder);
        }
    }

    class ReportCell: IRenderable
    {
        public string Content { get; }
        public ReportCell(string content)
        {
            Content = content;
        }

        public void Render(StringBuilder builder)
        {
            builder.Append($" {Content} |");
        }
    }

    interface IRenderable
    {
        void Render(StringBuilder builder);
    }

    static class AllDaysOfWeek
    {
        public static DayOfWeek[] FromMonday = new[] { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };
    }
}
