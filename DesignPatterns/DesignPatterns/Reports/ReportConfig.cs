namespace DesignPatterns.Reports
{
    public class ReportConfig
    {
        private static ReportConfig instance;

        public static ReportConfig GetInstance()
        {
            if (instance == null) 
                instance = new ReportConfig();

            return instance;
        }

        private ReportConfig() { }

        

        public string ColumnSeparator { get; set; }
    }
}
