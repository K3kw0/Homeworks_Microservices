using MetricsAgent.Controllers;
using lesson_2.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using Xunit;

namespace XUnitMetricsManagerTests.MetricsAgentTests
{
    public class HddMetricsAgentControllerUnitTests
    {
        private readonly HddMetricsAgentController controller;

        public HddMetricsAgentControllerUnitTests()
        {
            controller = new HddMetricsAgentController();
        }

        [Fact]
        public void GetMetricsFromAgent_ReturnsOk()
        {
            var fromTime = TimeSpan.FromSeconds(0);
            var toTime = TimeSpan.FromSeconds(100);

            var result = controller.GetMetricsFromMetricsAgent(fromTime, toTime, 25346);

            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }

    }
}
