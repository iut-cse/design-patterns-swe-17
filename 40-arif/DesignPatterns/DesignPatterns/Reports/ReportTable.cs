using System.Collections.Generic;
using System.Linq;
using System.Text;
using DesignPatterns.Reports.Kpis;

namespace DesignPatterns.Reports
{
    public class ReportTable : IRenderable
    {
        private List<ReportColumn> columns;
        private ReportCell[,] cells;
        private readonly List<string> departments;
        private readonly IKpi kpi;
        private readonly List<ClassInfo> classInfos;
        private readonly string firstColumnAlignment;

        public ReportTable(IKpi kpi, List<ClassInfo> classInfos, string firstColumnAlignment)
        {
            this.kpi = kpi;
            this.classInfos = classInfos;
            this.firstColumnAlignment = firstColumnAlignment;
            this.departments = classInfos.ConvertAll(ci => ci.department).Distinct().ToList();
            BuildComponents();
        }

        public void Render(StringBuilder builder)
        {
            for (var r = 0; r < cells.GetLength(0); r++)
            {
                builder.Append("|");
                for (var c = 0; c < cells.GetLength(1); c++)
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
            columns.AddRange(Enumerable.Range(1, colCount).ToList().ConvertAll(n => new ReportColumn("right")));

            cells = new ReportCell[rowCount, colCount];

            BuildHeaderRow();

            for (var rowIndex = 1; rowIndex <= departments.Count; rowIndex++)
                BuildDepartmentRow(rowIndex);

            BuildTotalRow(rowCount - 1);

            for (var rowIndex = 0; rowIndex < rowCount; rowIndex++)
            {
                for (var colIndex = 0; colIndex < colCount; colIndex++)
                {
                    columns[colIndex].AddCell(cells[rowIndex, colIndex]);
                }
            }
        }

        private void BuildTotalRow(int rowIndex)
        {
            var colIndex = 0;
            cells[rowIndex, colIndex] = new ReportCell("Total");
            for (colIndex++; colIndex <= 7; colIndex++)
            {
                var dow = AllDaysOfWeek.FromMonday[colIndex - 1];
                var value = kpi.Calculate(classInfos, ci => ci.date.DayOfWeek == dow);
                cells[rowIndex, colIndex] = new ReportCell(value.ToString());
            }

            var grandTotal = kpi.Calculate(classInfos, ci => true);
            cells[rowIndex, colIndex] = new ReportCell(grandTotal.ToString());
        }

        private void BuildDepartmentRow(int rowIndex)
        {
            var colIndex = 0;
            var department = departments[rowIndex - 1];
            cells[rowIndex, colIndex] = new ReportCell(department);
            for (colIndex++; colIndex <= 7; colIndex++)
            {
                var dow = AllDaysOfWeek.FromMonday[colIndex - 1];

                var value = kpi.Calculate(classInfos, ci => ci.date.DayOfWeek == dow && ci.department == department);
                cells[rowIndex, colIndex] = new ReportCell(value.ToString());
            }
            var total = kpi.Calculate(classInfos, ci => ci.department == department);
            cells[rowIndex, colIndex] = new ReportCell(total.ToString());
        }

        private void BuildHeaderRow()
        {
            var rowIndex = 0;
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