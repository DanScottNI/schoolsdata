using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Logging;

namespace angularnetcore.Controllers
{
    [Route("api/[controller]")]
    public class TestApiController : Controller
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return new ObjectResult(new string[] { "Test1", "Test2", "Test3" });
        }

        [HttpGet("{id}", Name = "GetItem")]
        public IActionResult GetById(int id)
        {
            if (id > 3 || id < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            return new ObjectResult($"Test{id.ToString()}");
        }
    }
}