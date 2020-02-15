namespace DesignPatterns.Reports
{
    public class ReportConfig
    {
        private static ReportConfig instance;

        public static ReportConfig GetInstance()
        {
            lock (instance)
            {
                if (instance == null)
                    instance = new ReportConfig();
            }

            return instance;
        }

        private ReportConfig()
        {
            ColumnSeparator = "|";
        }

        public string ColumnSeparator { get; set; }
    }
}
