using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Traveler.Data;
using Traveler.Helper;
using Traveler.Models;
using Traveler.Service.AdminService;
using Traveler.Service.EmailService;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;

namespace Traveler.Areas.User.Controllers
{
   
    [Area("User")]
    public class HomeController : Controller
    {
        private readonly IAdminService _Admin;
        private readonly EmailService _email;
        public HomeController(IAdminService s, EmailService e)
        {
            _Admin = s;
            _email = e;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Notif()
        {
            return View();
        }

        public IActionResult FromAPIPesawat() => View();

        public async Task<IActionResult> Pesawat()
        {
            var banyakData = new AdminDashBoard();

            banyakData.pesawat = await _Admin.TampilSemuaPesawat();
            return View(banyakData);
        }
        [Authorize]
        public IActionResult Pelanggan()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Pelanggan(Pelanggan parameter, string id, transaksi transaksi)
        {
            int OTP = BanyakBantuan.BuatOTP();
            _email.KirimEmail(parameter.email, "Konfirmasi Pemesanan Tiket", "<h1>Pesanan sedang di proses mohon untuk melunasi pembayarannya</h1><br/> <a href = https://www.dana.id/ >Bayar Disini</a> <br/> <a href='mailto:dotnetlanjutan@gmail.com?subject=Bantuan&body=Hallo'>Bantuan</a><br/>" + OTP);

            var data = parameter.nik.ToString();
            if (ModelState.IsValid)
            {
                string username = User.GetUsername().ToString();
                await _Admin.TambahPelanggan(parameter);
                await _Admin.TambahTransaksi(transaksi, id, data);

                return RedirectToAction(controllerName: "Home", actionName: "Notif");
            }
            return View(parameter);
        }
        public async Task<IActionResult> Kereta()
        {
            var banyakData = new AdminDashBoard();

            banyakData.kereta = await _Admin.TampilSemuaKereta();
            
            return View(banyakData);
        }

        public async Task<IActionResult> Travel()
        {
            var banyakData = new AdminDashBoard();

            banyakData.travel = await _Admin.TampilSemuaTravel();
            return View(banyakData);
        }
    }
}
