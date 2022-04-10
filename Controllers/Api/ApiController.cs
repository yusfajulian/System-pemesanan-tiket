using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Traveler.Service.AdminService;
using Traveler.Helper;
using Traveler.Migrations;
using Traveler.Models;
using Microsoft.AspNetCore.Http;

namespace Traveler.Controllers.Api
{
    [Route("api/[controller]")]
    public class ApiController : Controller
    {
        // service
        private readonly IAdminService _service;
        public ApiController(IAdminService s)
        {
            _service = s;
        }

        [Route("pesawat")]
        public IActionResult Index()
        {
            var data = _service.TampilSemuaPesawat();

            return Ok(BanyakBantuan.Respon("Sukses", 200, "Berhasil menampilkan semua data blog", data));
        }

        [Route("Kereta")]
        public IActionResult TampilSemuaKereta()
        {
            var data = _service.TampilSemuaKereta();

            return Ok(BanyakBantuan.Respon("Sukses", 200, "Berhasil menampilkan semua data blog", data));
        }
        [Route("Travel")]
        public IActionResult TampilSemuaTravel()
        {
            var data = _service.TampilSemuaTravel();

            return Ok(BanyakBantuan.Respon("Sukses", 200, "Berhasil menampilkan semua data blog", data));
        }

        [Route("Pelanggan")]
        public IActionResult TampilSemuaPelanggan()
        {
            var data = _service.TampilSemuaPelanggan();

            return Ok(BanyakBantuan.Respon("Sukses", 200, "Berhasil menampilkan semua data blog", data));
        }
    }
}
