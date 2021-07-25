using lesson_3.Controllers;
using Moq;
using Microsoft.AspNetCore.Mvc;
using System;
using Xunit;
using Microsoft.Extensions.Logging;

namespace XUnitMetricsManagerTests
{
    public class CpuMetricsControllerUnitTests
    {
        private readonly CpuMetricsController controller;
        private Mock<ILogger<CpuMetricsController>> cpuMetricsControllerMock;

        public CpuMetricsControllerUnitTests()
        {
            cpuMetricsControllerMock = new Mock<ILogger<CpuMetricsController>>();
            controller = new CpuMetricsController(cpuMetricsControllerMock.Object);
        }

        [Fact]
        public void GetMetricsFromAgent_ReturnsOk()
        {
            var agentId = 1;
            var fromTime = TimeSpan.FromSeconds(0);
            var toTime = TimeSpan.FromSeconds(100);
                       
            var result = controller.GetMetricsFromAgent(agentId, fromTime, toTime);
                        
            _ = Assert.IsAssignableFrom<IActionResult>(result);
        }
    }

}
