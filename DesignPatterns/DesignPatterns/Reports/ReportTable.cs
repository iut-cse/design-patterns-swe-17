using System.Collections.Generic;
using System.Linq;
using System.Text;
using DesignPatterns.Reports.Alignments;

namespace DesignPatterns.Reports
{
    public class ReportTable : IRenderable
    {
        private List<ReportColumn> columns;
        private ReportCell[,] cells;
        private readonly List<string> departments;
        private readonly List<ClassInfo> classHours;
        private readonly IAlignment firstColumnAlignment;

        public ReportTable(List<ClassInfo> classHours, IAlignment firstColumnAlignment)
        {
            this.classHours = classHours;
            this.firstColumnAlignment = firstColumnAlignment;
            this.departments = classHours.ConvertAll(ch => ch.department).Distinct().ToList();
            BuildComponents();
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

        private void BuildComponents()
        {
            var rowCount = 1 + departments.Count + 1;
            var colCount = 1 + 7 + 1;
            columns = new List<ReportColumn>();
            columns.Add(new ReportColumn(firstColumnAlignment));
            columns.AddRange(Enumerable.Range(1, colCount).ToList().ConvertAll(n => new ReportColumn(new RightAlignment())));

            cells = new ReportCell[rowCount, colCount];

            BuildHeaderRow();

            for (var rowIndex = 1; rowIndex <= departments.Count; rowIndex++)
                BuildDepartmentRow(rowIndex);

            BuildTotalRow(rowCount - 1);

            for (var rowIndex = 0; rowIndex < rowCount; rowIndex++)
            {
                for (int colIndex = 0; colIndex < colCount; colIndex++)
                {
                    columns[colIndex].AddCell(cells[rowIndex, colIndex]);
                }
            }
        }

        private void BuildTotalRow(int rowIndex)
        {
            int colIndex = 0;
            cells[rowIndex, colIndex] = new ReportCell("Total");
            var grandTotal = 0.0;
            for (colIndex++; colIndex <= 7; colIndex++)
            {
                var dow = AllDaysOfWeek.FromMonday[colIndex - 1];
                var value = classHours.FindAll(ch => ch.date.DayOfWeek == dow).Sum(ch => ch.durationHours);
                cells[rowIndex, colIndex] = new ReportCell(value.ToString());
                grandTotal += value;
            }
            cells[rowIndex, colIndex] = new ReportCell(grandTotal.ToString());
        }

        private void BuildDepartmentRow(int rowIndex)
        {
            int colIndex = 0;
            var department = departments[rowIndex - 1];
            cells[rowIndex, colIndex] = new ReportCell(department);
            var total = 0.0;
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