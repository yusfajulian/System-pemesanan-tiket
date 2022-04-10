using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Traveler.Data;
using Traveler.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace QUERY.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult FromAPI() => View();
        public IActionResult Index() => View();

    }
}
