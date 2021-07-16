using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lesson_1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]                                      // инициализация листа
        public List<string> Get0()
        {
            Zxc w = new Zxc();
            return w.A;
        }

        [HttpPost]                                          // вывод строки по номеру 
        [Route("1")]
        public string Get1([FromQuery] int n)
        {
            Zxc w = new Zxc();
            if (n == w.A.Count) return w.Find(n);
            else return "Указано неверное кол-во строк";
        }

        [HttpDelete]                                          // отчистка листа      
        [Route("2")]
        public IActionResult Get2()
        {
            Zxc w = new Zxc();
            w.Clearr();
            return Ok();
        }

        [HttpPut]                                           // добавление строк в лист
        [Route("3")]
        public IActionResult Get3([FromQuery] int n)
        {
            Zxc w = new Zxc();
            w.Adda(n);
            return Ok();
        }
    }
}
