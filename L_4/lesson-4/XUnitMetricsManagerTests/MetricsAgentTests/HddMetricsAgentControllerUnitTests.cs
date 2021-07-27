using MetricsAgent.Controllers;
using MetricsAgent.DAL.Interfaces;
using MetricsAgent.Entities;
using Moq;
using System;
using Xunit;

namespace XUnitMetricsManagerTests.MetricsAgentTests
{
    public class HddMetricsAgentControllerUnitTests
    {
        private readonly HddMetricsAgentController controller;
        private Mock<IHddMetricsRepository> mock;

        public HddMetricsAgentControllerUnitTests()
        {
            mock = new Mock<IHddMetricsRepository>();
            controller = new HddMetricsAgentController(mock.Object);
        }

        [Fact]
        public void GetMetricsFromAgent_ReturnsOk()
        {
            mock.Setup(repository => repository.Create(It.IsAny<HddMetric>())).Verifiable();
            var result = controller.Create(new MetricsAgent.Models.Request.HddMetricCreateRequest { Time = TimeSpan.FromSeconds(1), Value = 50 });
            mock.Verify(repository => repository.Create(It.IsAny<HddMetric>()), Times.AtMostOnce());
        }

    }
}
