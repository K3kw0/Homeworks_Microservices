using MetricsAgent.Controllers;
using MetricsAgent.DAL.Network;
using MetricsAgent.Entities;
using Moq;
using System;
using Xunit;

namespace XUnitMetricsManagerTests.MetricsAgentTests
{
    public class NetworkMetricsAgentControllerUnitTests
    {
        private readonly NetworkMetricsAgentController controller;
        private Mock<INetworkMetricsRepository> mock;

        public NetworkMetricsAgentControllerUnitTests()
        {
            mock = new Mock<INetworkMetricsRepository>();
            controller = new NetworkMetricsAgentController(mock.Object);
        }

        [Fact]
        public void GetMetricsFromAgent_ReturnsOk()
        {
            mock.Setup(repository => repository.Create(It.IsAny<NetworkMetric>())).Verifiable();
            var result = controller.Create(new MetricsAgent.Models.Request.NetworkMetricCreateRequest { Time = TimeSpan.FromSeconds(1), Value = 50 });
            mock.Verify(repository => repository.Create(It.IsAny<NetworkMetric>()), Times.AtMostOnce());
        }
    }
}
