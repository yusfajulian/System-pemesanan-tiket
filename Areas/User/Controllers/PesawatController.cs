using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traveler.Areas.User.Controllers
{
    public class PesawatController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
