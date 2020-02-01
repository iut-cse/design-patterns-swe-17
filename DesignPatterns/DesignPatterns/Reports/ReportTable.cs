using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Reports
{
    public class ReportTable : IRenderable
    {
        private List<ReportColumn> cols;
        private ReportCell[,] cells;

        public ReportTable(List<ClassHour> classHours)
        {
            BuildComponents(classHours);
        }

        public void Render(StringBuilder builder)
        {
            for (int r = 0; r < cells.GetLength(0); r++)
            {
                builder.Append("|");
                for (int c = 0; c < cells.GetLength(1); c++)
                {
                    builder.Append(" ");
                    cells[r, c].Render(builder);
                    builder.Append(" |");
                }
                builder.Append("\n");
            }
        }

        private void BuildComponents(List<ClassHour> classHours)
        {
            var departments = classHours.ConvertAll(ch => ch.department).Distinct().ToList();

            var rowCount = 1 + departments.Count + 1;
            var colCount = 1 + 7 + 1;
            cols = Enumerable.Range(0, colCount).ToList().ConvertAll(n => new ReportColumn()); ;

            cells = new ReportCell[rowCount, colCount];

            BuildHeaderRow();

            for (var r = 1; r <= departments.Count; r++)
                BuildDepartmentRow(classHours, departments, r);

            BuildTotalRow(classHours, rowCount - 1);

            for (var r = 0; r < cells.GetLength(0); r++)
            {
                for (int c = 0; c < cells.GetLength(1); c++)
                {
                    cols[c].AddCell(cells[r, c]);
                }
            }
        }

        private void BuildTotalRow(List<ClassHour> classHours, int r)
        {
            int c = 0;
            cells[r, c] = new ReportCell("Total");
            var grandTotal = 0;
            for (c++; c <= 7; c++)
            {
                var dow = AllDaysOfWeek.FromMonday[c - 1];
                var value = classHours.FindAll(ch => ch.date.DayOfWeek == dow).Sum(ch => ch.durationHours);
                cells[r, c] = new ReportCell(value.ToString());
                grandTotal += value;
            }
            cells[r, c] = new ReportCell(grandTotal.ToString());
        }

        private void BuildDepartmentRow(List<ClassHour> classHours, List<string> departments, int r)
        {
            int c = 0;
            var department = departments[r - 1];
            cells[r, c] = new ReportCell(department);
            var total = 0;
            for (c++; c <= 7; c++)
            {
                var dow = AllDaysOfWeek.FromMonday[c - 1];
                var value = classHours.FindAll(ch => ch.date.DayOfWeek == dow && ch.department == department).Sum(ch => ch.durationHours);
                cells[r, c] = new ReportCell(value.ToString());
                total += value;
            }
            cells[r, c] = new ReportCell(total.ToString());
        }

        private void BuildHeaderRow()
        {
            int r = 0;
            var c = 0;
            cells[r, c] = new ReportCell("Department");

            for (c++; c <= 7; c++)
            {
                cells[r, c] = new ReportCell(AllDaysOfWeek.FromMonday[c - 1].ToString());
            }
            cells[r, c] = new ReportCell("Total");
        }
    }
}