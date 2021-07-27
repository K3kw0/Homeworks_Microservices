using System;

namespace MetricsAgent.Models.DTO
{
    public class HddMetricDto
    {
        public TimeSpan Time { get; set; }
        public long Value { get; set; }
        public int Id { get; set; }
    }
}
