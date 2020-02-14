using System.Collections.Generic;

namespace DesignPatterns.Reports.Kpis
{
    public interface IKpi
    {
        KpiResult Calculate();
    }
}