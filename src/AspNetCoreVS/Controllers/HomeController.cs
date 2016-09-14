using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyCoreLib;

namespace AspNetCoreVS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger _logger;

        public HomeController(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<HomeController>();
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Some information log");
            _logger.LogWarning("This is a warning");
            _logger.LogError("This is an error");

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = $"Your application description page. {Hello.SayHello("David")}";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
