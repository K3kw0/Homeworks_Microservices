using MetricsAgent.Models.DTO;
using System.Collections.Generic;

namespace MetricsAgent.Models
{
    public class AllDotNetMetricsResponse
    {
        public List<DotNetMetricDto> Metrics { get; set; }
    }
}
