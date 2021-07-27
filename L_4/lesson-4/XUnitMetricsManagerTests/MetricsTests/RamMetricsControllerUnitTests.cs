using lesson_4.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using Xunit;

namespace XUnitMetricsManagerTests
{
    public class RamMetricsControllerUnitTests
    {
        private readonly RamMetricsController controller;
        private Mock<ILogger<RamMetricsController>> ramMetricsControllerMock;

        public RamMetricsControllerUnitTests()
        {
            ramMetricsControllerMock = new Mock<ILogger<RamMetricsController>>();
            controller = new RamMetricsController(ramMetricsControllerMock.Object);
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
