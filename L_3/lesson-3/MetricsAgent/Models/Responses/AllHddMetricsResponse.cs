using MetricsAgent.Models.DTO;
using System.Collections.Generic;

namespace MetricsAgent.Models
{
    public class AllHddMetricsResponse
    {
        public List<HddMetricDto> Metrics { get; set; }
    }
}
