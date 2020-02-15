namespace DesignPatterns.Reports
{
    public class ReportConfig
    {
        public static readonly ReportConfig Instance = new ReportConfig();

        public string ColumnSeparator { get; set; }
    }
}
