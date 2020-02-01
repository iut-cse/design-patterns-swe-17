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

            for (var rowIndex = 1; rowIndex <= departments.Count; rowIndex++)
                BuildDepartmentRow(classHours, departments, rowIndex);

            BuildTotalRow(classHours, rowCount - 1);

            for (var rowIndex = 0; rowIndex < rowCount; rowIndex++)
            {
                for (int colIndex = 0; colIndex < colCount; colIndex++)
                {
                    cols[colIndex].AddCell(cells[rowIndex, colIndex]);
                }
            }
        }

        private void BuildTotalRow(List<ClassHour> classHours, int rowIndex)
        {
            int colIndex = 0;
            cells[rowIndex, colIndex] = new ReportCell("Total");
            var grandTotal = 0;
            for (colIndex++; colIndex <= 7; colIndex++)
            {
                var dow = AllDaysOfWeek.FromMonday[colIndex - 1];
                var value = classHours.FindAll(ch => ch.date.DayOfWeek == dow).Sum(ch => ch.durationHours);
                cells[rowIndex, colIndex] = new ReportCell(value.ToString());
                grandTotal += value;
            }
            cells[rowIndex, colIndex] = new ReportCell(grandTotal.ToString());
        }

        private void BuildDepartmentRow(List<ClassHour> classHours, List<string> departments, int rowIndex)
        {
            int colIndex = 0;
            var department = departments[rowIndex - 1];
            cells[rowIndex, colIndex] = new ReportCell(department);
            var total = 0;
            for (colIndex++; colIndex <= 7; colIndex++)
            {
                var dow = AllDaysOfWeek.FromMonday[colIndex - 1];
                var value = classHours.FindAll(ch => ch.date.DayOfWeek == dow && ch.department == department).Sum(ch => ch.durationHours);
                cells[rowIndex, colIndex] = new ReportCell(value.ToString());
                total += value;
            }
            cells[rowIndex, colIndex] = new ReportCell(total.ToString());
        }

        private void BuildHeaderRow()
        {
            int rowIndex = 0;
            var colIndex = 0;
            cells[rowIndex, colIndex] = new ReportCell("Department");

            for (colIndex++; colIndex <= 7; colIndex++)
            {
                cells[rowIndex, colIndex] = new ReportCell(AllDaysOfWeek.FromMonday[colIndex - 1].ToString());
            }
            cells[rowIndex, colIndex] = new ReportCell("Total");
        }
    }
}