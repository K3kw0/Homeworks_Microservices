using lesson_3.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using Xunit;

namespace XUnitMetricsManagerTests
{
    public class HddMetricsControllerUnitTests
    {
        private readonly HddMetricsController controller;
        private Mock<ILogger<HddMetricsController>> hddNetMetricsControllerMock;

        public HddMetricsControllerUnitTests()
        {
            hddNetMetricsControllerMock = new Mock<ILogger<HddMetricsController>>();
            controller = new HddMetricsController(hddNetMetricsControllerMock.Object);
        }

        [Fact]
        public void GetMetricsFromAgent_ReturnsOk()
        {
            var agentId = 3;
            var fromTime = TimeSpan.FromSeconds(0);
            var toTime = TimeSpan.FromSeconds(100);

            var result = controller.GetMetricsFromAgent(agentId, fromTime, toTime);

            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }

    }
}
