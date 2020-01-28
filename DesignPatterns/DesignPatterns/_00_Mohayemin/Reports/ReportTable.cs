using static System.DayOfWeek;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace DesignPatterns._00_Mohayemin.Reports
{
    class ReportTable : IRenderable
    {
        internal List<ReportRow> rows;
        internal List<ReportColumn> cols;
        internal ReportCell[,] cells;

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
            rows = Enumerable.Range(0, rowCount).ToList().ConvertAll(n => new ReportRow());
            cols = Enumerable.Range(0, colCount).ToList().ConvertAll(n => new ReportColumn()); ;

            cells = new ReportCell[rowCount, colCount];

            BuildHeaderRow(0);

            for (var r = 1; r <= departments.Count; r++)
                BuildDepartmentRow(classHours, departments, r);

            BuildTotalRow(classHours, rowCount - 1);


            for (var r = 0; r < cells.GetLength(0); r++)
            {
                for (int c = 0; c < cells.GetLength(1); c++)
                {
                    rows[r].AddCell(cells[r, c]);
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

        private void BuildHeaderRow(int r)
        {
            var c = 0;
            cells[r, c] = new ReportCell("Department");

            for (c++; c <= 7; c++)
            {
                cells[r, c] = new ReportCell(AllDaysOfWeek.FromMonday[c - 1].ToString());
            }
            cells[r, c] = new ReportCell("Total");
        }
    }

    class ReportRow
    {
        private List<ReportCell> cells;
        public ReportRow()
        {
            cells = new List<ReportCell>();
        }

        public void AddCell(ReportCell cell)
        {
            cells.Add(cell);
            cell.Row = this;
        }
    }

    class ReportColumn
    {
        private readonly List<ReportCell> cells;
        public int Width { get; private set; }
        public ReportColumn()
        {
            cells = new List<ReportCell>();
            Width = 0;
        }

        public void AddCell(ReportCell cell)
        {
            cells.Add(cell);
            cell.Col = this;
            Width = Math.Max(Width, cell.content.Length);
        }
    }

    class ReportCell : IRenderable
    {
        public readonly string content;
        public ReportRow Row { get; set; }
        public ReportColumn Col { get; set; }

        public ReportCell(string content)
        {
            this.content = content;
        }

        public void Render(StringBuilder builder)
        {
            builder.Append(content.PadLeft(Col.Width));
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
