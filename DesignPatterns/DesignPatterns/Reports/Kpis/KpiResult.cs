using System.Collections.Generic;

namespace DesignPatterns.Reports.Kpis
{
    public class KpiResult
    {
        private readonly IDictionary<string, double> rawResult;

        public KpiResult(IDictionary<string, double> rawResult)
        {
            this.rawResult = rawResult;
            this.Departments = rawResult.Keys;
        }

        public double this[string department] => rawResult.ContainsKey(department) ? rawResult[department] : 0.0;

        public IEnumerable<string> Departments { get; }
    }
}