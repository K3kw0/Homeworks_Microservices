using MetricsAgent.Controllers;
using MetricsAgent.DAL;
using MetricsAgent.Entities;
using Moq;
using System;
using Xunit;

namespace XUnitMetricsManagerTests.MetricsAgentTests
{
    public class CpuMetricsAgentControllerUnitTests
    {
        private readonly CpuMetricsAgentController controller;
        private Mock<ICpuMetricsRepository> mock;

        public CpuMetricsAgentControllerUnitTests()
        {
            mock = new Mock<ICpuMetricsRepository>();
            controller = new CpuMetricsAgentController(mock.Object);
        }

        [Fact]
        public void GetMetricsFromAgent_ReturnsOk()
        {
            mock.Setup(repository => repository.Create(It.IsAny<CpuMetric>())).Verifiable();
            var result = controller.Create(new MetricsAgent.Models.Request.CpuMetricCreateRequest { Time = TimeSpan.FromSeconds(1), Value = 50 });
            mock.Verify(repository => repository.Create(It.IsAny<CpuMetric>()), Times.AtMostOnce());
        }
    }
}
