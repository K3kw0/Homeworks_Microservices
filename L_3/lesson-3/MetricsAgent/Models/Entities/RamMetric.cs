using System;

namespace MetricsAgent.Entities
{
    public class RamMetric
    {
        public int Id { get; set; }
        public float Value { get; set; }
        public TimeSpan Time { get; set; }
    }
}
