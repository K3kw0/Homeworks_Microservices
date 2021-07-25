using lesson_3.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;
using System;
using Xunit;

namespace XUnitMetricsManagerTests
{
    public class DotNetMetricsControllerUnitTests
    {
        private readonly DotNetMetricsController controller;
        private Mock<ILogger<DotNetMetricsController>> dotNetMetricsControllerMock;

        public DotNetMetricsControllerUnitTests()
        {
            dotNetMetricsControllerMock = new Mock<ILogger<DotNetMetricsController>>();
            controller = new DotNetMetricsController(dotNetMetricsControllerMock.Object);
        }

        [Fact]
        public void GetMetricsFromAgent_ReturnsOk()
        {
            var agentId = 2;
            var fromTime = TimeSpan.FromSeconds(0);
            var toTime = TimeSpan.FromSeconds(100);

            var result = controller.GetMetricsFromAgent(agentId, fromTime, toTime);

            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }
    }

}
