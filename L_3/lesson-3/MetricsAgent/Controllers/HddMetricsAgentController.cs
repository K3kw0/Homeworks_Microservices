using MetricsAgent.DAL.Hdd;
using MetricsAgent.Entities;
using MetricsAgent.Models.Request;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace MetricsAgent.Controllers
{
    [Route("api/MetricsAgent/hdd")]
    [ApiController]
    public class HddMetricsAgentController : ControllerBase
    {
        private readonly ILogger<HddMetricsAgentController> _logger;

        public HddMetricsAgentController(ILogger<HddMetricsAgentController> logger)
        {
            _logger = logger;
            _logger.LogDebug(1, "NLog встроен в HddMetricsAgentController");
        }

        private readonly IHddMetricsRepository _hddMetricsRepository;

        public HddMetricsAgentController(IHddMetricsRepository hddMetricsRepository)
        {
            _hddMetricsRepository = hddMetricsRepository;
        }

        [HttpPost("create")]
        public IActionResult Create([FromBody] HddMetricCreateRequest request)
        {
            _hddMetricsRepository.Create(new HddMetric
            {
                Time = request.Time,
                Value = request.Value
            });
            return Ok();
        }

        [HttpGet("api/metrics/hdd/left/{TotalFreeSpace}")]
        public IActionResult GetMetricsFromMetricsAgent([FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime, [FromRoute] long TotalFreeSpace)
        {
            return Ok();
        }
    }
}
