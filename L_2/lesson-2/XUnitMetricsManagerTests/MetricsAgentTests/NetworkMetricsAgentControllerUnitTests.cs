using MetricsAgent.Controllers;
using lesson_2.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;

namespace XUnitMetricsManagerTests.MetricsAgentTests
{
    public class NetworkMetricsAgentControllerUnitTests
    {
        private readonly NetworkMetricsAgentController controller;

        public NetworkMetricsAgentControllerUnitTests()
        {
            controller = new NetworkMetricsAgentController();
        }

        [Fact]
        public void GetMetricsFromAgent_ReturnsOk()
        {
            var fromTime = TimeSpan.FromSeconds(0);
            var toTime = TimeSpan.FromSeconds(100);

            var result = controller.GetMetricsFromMetricsAgent(fromTime, toTime);

            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }
    }
}
