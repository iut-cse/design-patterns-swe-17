using System.Collections.Generic;

namespace DesignPatterns.Reports.Kpis
{
    public interface IKpi
    {
        IDictionary<string, double> Calculate();
    }
}