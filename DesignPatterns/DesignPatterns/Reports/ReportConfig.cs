namespace DesignPatterns.Reports
{
    public class ReportConfig
    {
        private static readonly object instanceLock = new object();
        private static ReportConfig instance;

        public static ReportConfig GetInstance()
        {
            if (instance == null)
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ReportConfig();
                    }
                }

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
