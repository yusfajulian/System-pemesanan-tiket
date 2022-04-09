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
    public class ApiController : Controller
    {
        private readonly IAdminService _Admin;
        public ApiController(IAdminService s)
        {
            _Admin = s;
        }

        [Route("Pesawat")]
        public IActionResult Index()
        {
            object data = _Admin.TampilSemuaPesawat();

            return Ok(BanyakBantuan.BuatResponAPI("Sukses", 200, "Berhasil menampilkan semua data blog", data));
        }      
    }
}
