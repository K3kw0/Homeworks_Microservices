using lesson_2.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace XUnitMetricsManagerTests
{
    public class RamMetricsControllerUnitTests
    {
        private readonly RamMetricsController controller;

        public RamMetricsControllerUnitTests()
        {
            controller = new RamMetricsController();
        }

        [Fact]
        public void GetMetricsFromAgent_ReturnsOk()
        {
            var agentId = 5;
            var fromTime = TimeSpan.FromSeconds(0);
            var toTime = TimeSpan.FromSeconds(100);

            var result = controller.GetMetricsFromAgent(agentId, fromTime, toTime);

            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }

    }
}
