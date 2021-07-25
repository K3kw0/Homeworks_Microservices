using System.Collections.Generic;

namespace MetricsAgent.Models
{
    public class AllCpuMetricsResponse
    {
        public List<CpuMetricDto> Metrics { get; set; }
    }
}
