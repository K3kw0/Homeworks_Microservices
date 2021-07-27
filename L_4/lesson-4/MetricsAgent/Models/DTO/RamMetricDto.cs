using System;

namespace MetricsAgent.Models.DTO
{
    public class RamMetricDto
    {
        public TimeSpan Time { get; set; }
        public float Value { get; set; }
        public int Id { get; set; }
    }
}
