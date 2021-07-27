using System;

namespace MetricsAgent.Models.Request
{
    public class HddMetricCreateRequest
    {
        public TimeSpan Time { get; set; }
        public long Value { get; set; }
    }
}
