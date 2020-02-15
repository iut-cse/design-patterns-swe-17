namespace DesignPatterns.Reports
{
    public class ReportConfig
    {
        public static readonly ReportConfig Instance = new ReportConfig();

        private ReportConfig() { }

        public string ColumnSeparator { get; set; }
    }
}
