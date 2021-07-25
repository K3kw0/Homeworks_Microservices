using MetricsAgent.Controllers;
using lesson_2.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Diagnostics;
using Xunit;

namespace XUnitMetricsManagerTests.MetricsAgentTests
{
    public class RamMetricsAgentControllerUnitTests
    {
        private readonly RamMetricsAgentController controller;

        public RamMetricsAgentControllerUnitTests()
        {
            controller = new RamMetricsAgentController();
        }

        [Fact]
        public void GetMetricsFromAgent_ReturnsOk()
        {
            var fromTime = TimeSpan.FromSeconds(0);
            var toTime = TimeSpan.FromSeconds(100);
            var info = new PerformanceCounter();

            var result = controller.GetMetricsFromMetricsAgent(fromTime, toTime, 25);

            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}
