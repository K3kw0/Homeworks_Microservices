using MetricsAgent.Controllers;
using lesson_2.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace XUnitMetricsManagerTests.MetricsAgentTests
{
    public class CpuMetricsAgentControllerUnitTests
    {
        private readonly CpuMetricsAgentController controller;

        public CpuMetricsAgentControllerUnitTests()
        {
            controller = new CpuMetricsAgentController();
        }

        [Fact]
        public void GetMetricsFromAgent_ReturnsOk()
        {
            var fromTime = TimeSpan.FromSeconds(0);
            var toTime = TimeSpan.FromSeconds(100);

            var result1 = controller.GetMetricsFromMetricsAgent(fromTime, toTime);
            var result2 = controller.GetMetricsFromMetricsAgentP(fromTime, toTime, 25);

            _ = Assert.IsAssignableFrom<IActionResult>(result1);
            _ = Assert.IsAssignableFrom<IActionResult>(result2);
        }

    }
}
