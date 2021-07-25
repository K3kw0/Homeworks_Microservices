using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MetricsAgent.Controllers
{
    [Route("api/MetricsAgent/hdd")]
    [ApiController]
    public class HddMetricsAgentController : ControllerBase
    {
        [HttpGet("api/metrics/hdd/left/{TotalFreeSpace}")]
        public IActionResult GetMetricsFromMetricsAgent([FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime, [FromRoute] long TotalFreeSpace)
        {
            return Ok();
        }

        [HttpGet("api/metrics/cluster/from/{fromTime}/to/{toTime}")]
        public IActionResult GetMetricsFromAllCluster([FromRoute] TimeSpan fromTime, [FromRoute] TimeSpan toTime)
        {
            return Ok();
        }
    }
}
