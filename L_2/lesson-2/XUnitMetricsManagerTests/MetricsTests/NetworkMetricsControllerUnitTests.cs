using lesson_2.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace XUnitMetricsManagerTests
{
    public class NetworkMetricsControllerUnitTests
    {
        private readonly NetworkMetricsController controller;

        public NetworkMetricsControllerUnitTests()
        {
            controller = new NetworkMetricsController();
        }

        [Fact]
        public void GetMetricsFromAgent_ReturnsOk()
        {
            var agentId = 4;
            var fromTime = TimeSpan.FromSeconds(0);
            var toTime = TimeSpan.FromSeconds(100);

            var result = controller.GetMetricsFromAgent(agentId, fromTime, toTime);

            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }

    }
}
