using System.Collections.Generic;
using System;

namespace DesignPatterns._00_Mohayemin.Reports
{
    public class ReportColumn
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
}
