using MetricsAgent.DAL.Network;
using MetricsAgent.Entities;
using MetricsAgent.Models.Request;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace MetricsAgent.Controllers
{
    [Route("api/MetricsAgent/network")]
    [ApiController]
    public class NetworkMetricsAgentController : ControllerBase
    {
        private readonly ILogger<NetworkMetricsAgentController> _logger;

        public NetworkMetricsAgentController(ILogger<NetworkMetricsAgentController> logger)
        {
            _logger = logger;
            _logger.LogDebug(1, "NLog встроен в NetworkMetricsAgentController");
        }

        private readonly INetworkMetricsRepository _networkMetricsRepository;

        public NetworkMetricsAgentController(INetworkMetricsRepository networkMetricsRepository)
        {
            _networkMetricsRepository = networkMetricsRepository;
        }

        [HttpPost("create")]
        public IActionResult Create([FromBody] NetworkMetricCreateRequest request)
        {
            _networkMetricsRepository.Create(new NetworkMetric
            {
                Time = request.Time,
                Value = request.Value
            });
            return Ok();
        }

        [HttpGet("api/metrics/network/from/{fromTime}/to/{toTime}")]
        public IActionResult GetMetricsFromMetricsAgent([FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime)
        {
            return Ok();
        }
    }
}
