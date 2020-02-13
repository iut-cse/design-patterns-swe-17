using System.Text;

namespace DesignPatterns.Reports
{
    public class ReportCell : IRenderable
    {
        public readonly string content;
        public ReportColumn Column { get; set; }

        public ReportCell(string content)
        {
            this.content = content;
        }

        public void Render(StringBuilder builder)
        {
            var alignedContent = Column.alignment.Align(content, Column.Width);
            builder.Append(alignedContent);
        }
    }
}