using System;
using System.Collections.Generic;

namespace DesignPatterns.Reports
{
    public class ReportColumn
    {
        private readonly List<ReportCell> cells;
        public readonly string alignment;
        public int Width { get; private set; }

        public ReportColumn(string alignment)
        {
            this.alignment = alignment;
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