using MetricsAgent.Models.DTO;
using System.Collections.Generic;

namespace MetricsAgent.Models
{
    public class AllRamMetricsResponse
    {
        public List<RamMetricDto> Metrics { get; set; }
    }
}
