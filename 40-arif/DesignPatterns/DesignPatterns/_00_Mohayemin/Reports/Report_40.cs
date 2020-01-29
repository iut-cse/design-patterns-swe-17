using static System.DayOfWeek;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Text;

namespace DesignPatterns._00_Mohayemin.Reports
{
    class ReportTable : IRenderable
    {
        internal List<ReportColumn> cols;
        internal ReportCell[,] cells;
        int pad, row;

        public ReportTable(List<ClassHour> classHours, int Al, int row)
        {
            BuildComponents(classHours);
            this.pad = Al;
            this.row = row;
        }

        public void Render(StringBuilder builder, int a)
        {
            for (int r = 0; r < cells.GetLength(0); r++)
            {
                builder.Append("|");
                for (int c = 0; c < cells.GetLength(1); c++)
                {
                    builder.Append(" ");

                    if ((c == 0|| c==8) && this.pad==0 )
                    {
                        cells[r, c].Render(builder,0);
                    }
                    else if ((r == 5) && this.row == 0)
                    {
                        cells[r, c].Render(builder, 0);
                    }
                    else
                    {
                        cells[r, c].Render(builder, 1);
                    }

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

            BuildHeaderRow(0);

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
            cell.Column = this;
            Width = Math.Max(Width, cell.content.Length);
        }

    }

    class ReportCell : IRenderable
    {
        public readonly string content;
        public ReportColumn Column { get; set; }

        public ReportCell(string content)
        {
            this.content = content;
        }

        public void Render(StringBuilder builder,int a)
        {
            
            if (a==0)
            {
                builder.Append(content.PadRight(Column.Width));
            }
            else if(a==1)
            {
                builder.Append(content.PadLeft(Column.Width));
            }
        }
    }

    interface IRenderable
    {
        void Render(StringBuilder builder, int a);
    }

    static class AllDaysOfWeek
    {
        public static DayOfWeek[] FromMonday = new[] { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };
    }

    class ClassHour
    {
        public readonly string department;
        public readonly DateTime date;
        public readonly int durationHours;

        public ClassHour(string department
            , DateTime date
            , int durationHours)
        {
            this.department = department;
            this.date = date;
            this.durationHours = durationHours;
        }
    }
}

/**
 * Your Student ID:170042040
 * Your Nick Name: Arif
 */

/** 
 * Place an x in the empty box below when the corresponding task is done.
 * [X] Task 1
 * [X] Task 2
 * [X] Task 3
 */
