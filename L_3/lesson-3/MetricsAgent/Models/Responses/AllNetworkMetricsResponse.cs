using MetricsAgent.Models.DTO;
using System.Collections.Generic;

namespace MetricsAgent.Models
{
    public class AllNetworkMetricsResponse
    {
        public List<NetworkMetricDto> Metrics { get; set; }
    }
}
