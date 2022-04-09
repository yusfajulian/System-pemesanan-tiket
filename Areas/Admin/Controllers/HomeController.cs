using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Traveler.Data;
using Traveler.Models;
using Traveler.Service.AdminService;
using Traveler.Service.EmailService;

namespace Traveler.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IAdminService _Admin;
        public HomeController(IAdminService s, AppDbContext c)
        {
            _Admin = s;
            _context = c;
        }
        public async Task<IActionResult> Index()
        {
            var banyakData = new AdminDashBoard();

            banyakData.pelanggan = await _Admin.TampilSemuaPelanggan();
            banyakData.pesawat = await _Admin.TampilSemuaPesawat();
            banyakData.kereta = await _Admin.TampilSemuaKereta();
            banyakData.travel = await _Admin.TampilSemuaTravel();
            banyakData.Transaksi = await _Admin.TampilSemuaTransaksi();

            return View(banyakData);
        }
        public IActionResult Das()
        {
            return View();
        }

        public IActionResult Notif()
        {
            return View();
        }

        public IActionResult TambahPesawat()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> TambahPesawat(Pesawat parameter, IFormFile fotonya)
        {

            if (ModelState.IsValid)
            {
                await _Admin.TambahPesawat(parameter, fotonya);

                return RedirectToAction(controllerName: "Home", actionName: "Index");
            }
            return View(parameter);
        }

        [HttpPost]
        public async Task<IActionResult> TambahKereta(Kereta parameter, IFormFile fotonya)
        {
            
            if (ModelState.IsValid)
            {
                await _Admin.TambahKereta(parameter, fotonya);

                return RedirectToAction(controllerName: "Home", actionName: "Index");
            }
            return View(parameter);
        }

        [HttpPost]
        public async Task<IActionResult> TambahTravel(Travel parameter, IFormFile fotonya)
        {

            if (ModelState.IsValid)
            {
                await _Admin.TambahTravel(parameter, fotonya);

                return RedirectToAction(controllerName: "Home", actionName: "Index");
            }
            return View(parameter);
        }
    }
}
