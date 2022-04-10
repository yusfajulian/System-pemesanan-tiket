using Microsoft.AspNetCore.Authentication;
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

        public IActionResult TambahKereta()
        {
            return View();
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

        public IActionResult TambahTravel()
        {
            return View();
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

        public async Task<IActionResult> HapusPelanggan(string id)
        {

            if (id == null)
            {
                return NotFound();
            }

            await _Admin.HapusPelanggan(id);

            return RedirectToAction("Index");

        }
        public async Task<IActionResult> HapusPesawat(string id)
        {

            if (id == null)
            {
                return NotFound();
            }

            await _Admin.HapusPesawat(id);

            return RedirectToAction("Index");

        }
        public async Task<IActionResult> HapusKereta(string id)
        {

            if (id == null)
            {
                return NotFound();
            }

            await _Admin.HapusKereta(id);

            return RedirectToAction("Index");

        }
        public async Task<IActionResult> HapusTravel(string id)
        {

            if (id == null)
            {
                return NotFound();
            }

            await _Admin.HapusTravel(id);

            return RedirectToAction("Index");

        }

        public async Task<IActionResult> HapusTransaksi(string id)
        {

            if (id == null)
            {
                return NotFound();
            }

            await _Admin.HapusTransaksi(id);

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UbahPesawat(string id)
        {
            var cari = await _Admin.TampilSemuaPesawatId(id);

            if (cari == null)
            {
                return NotFound();
            }
            return View(cari);
        }

        [HttpPost]
        public async Task<IActionResult> UbahPesawat(Pesawat data)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _Admin.UbahPesawat(data);
                }
                catch
                {
                    return NotFound();
                }
            }
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UbahKereta(string id)
        {
            var cari = await _Admin.TampilSemuaKeretaId(id);

            if (cari == null)
            {
                return NotFound();
            }
            return View(cari);
        }

        [HttpPost]
        public async Task<IActionResult> UbahKereta(Kereta data)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _Admin.UbahKereta(data);
                }
                catch
                {
                    return NotFound();
                }
            }
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> UbahTravel(string id)
        {
            var cari = await _Admin.TampilSemuaTravelId(id);

            if (cari == null)
            {
                return NotFound();
            }
            return View(cari);
        }

        [HttpPost]
        public async Task<IActionResult> UbahTravel(Travel data)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    await _Admin.UbahTravel(data);
                }
                catch
                {
                    return NotFound();
                }
            }
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Keluar()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/");
        }
    }
}
