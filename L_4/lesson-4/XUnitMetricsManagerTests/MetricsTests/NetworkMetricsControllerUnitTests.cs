using lesson_4.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using Xunit;

namespace XUnitMetricsManagerTests
{
    public class NetworkMetricsControllerUnitTests
    {
        private readonly NetworkMetricsController controller;
        private Mock<ILogger<NetworkMetricsController>> networkMetricsControllerMock;

        public NetworkMetricsControllerUnitTests()
        {
            networkMetricsControllerMock = new Mock<ILogger<NetworkMetricsController>>();
            controller = new NetworkMetricsController(networkMetricsControllerMock.Object);
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
