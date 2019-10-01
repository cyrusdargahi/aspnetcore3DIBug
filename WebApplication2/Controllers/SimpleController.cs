using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication2.Service;

namespace WebApplication2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SimpleController : ControllerBase
    {
        private readonly SimpleService simpleService;

        public SimpleController(SimpleService simpleService)
        {
            this.simpleService = simpleService;
        }

        [HttpGet]
        public decimal Get()
        {
            return simpleService.Value;
        }
    }
}
