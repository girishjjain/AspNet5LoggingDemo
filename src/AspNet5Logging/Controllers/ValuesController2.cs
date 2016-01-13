using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNet5Logging.Controllers
{
    [Route("api/values2")]
    public class ValuesController2 : Controller
    {
        private readonly ILogger logger;

        public ValuesController2(ILoggerFactory loggerFactory)
        {
            this.logger = loggerFactory.CreateLogger("AspNet5LoggingService");
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            logger.LogInformation("Processing GET request for values.");
            return new string[] { "value1", "value2" };
        }
    }
}
