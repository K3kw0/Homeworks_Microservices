﻿using System;

namespace MetricsAgent.Models.Request
{
    public class CpuMetricCreateRequest
    {
        public TimeSpan Time { get; set; }
        public int Value { get; set; }
    }
}
