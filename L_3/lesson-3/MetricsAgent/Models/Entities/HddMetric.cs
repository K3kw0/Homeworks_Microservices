using System;

namespace MetricsAgent.Entities
{
    public class HddMetric
    {
        public int Id { get; set; }
        public long Value { get; set; }
        public TimeSpan Time { get; set; }
    }
}
