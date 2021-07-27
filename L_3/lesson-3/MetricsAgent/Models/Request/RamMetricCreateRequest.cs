using System;

namespace MetricsAgent.Models.Request
{
    public class RamMetricCreateRequest
    {
        public TimeSpan Time { get; set; }
        public float Value { get; set; }
    }
}
