using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Traveler.Service.AdminService;
using Traveler.Helper;

namespace Traveler.Controllers.Api
{
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        private readonly IAdminService _Admin;
        public HomeController(IAdminService s)
        {
            _Admin = s;
        }

        public IActionResult Index()
        {
            var data = _Admin.TampilSemuaPesawat();

            return Ok(BanyakBantuan.BuatResponAPI("Sukses", 200, "Berhasil menampilkan semua data blog", data));
        }
    }
}
