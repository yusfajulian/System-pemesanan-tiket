using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Traveler.Models;
using Traveler.Helper;
using Traveler.Data;
using Traveler.Service.EmailService;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;

namespace Traveler.Controllers
{
    public class Akun : Controller
    {
        private readonly AppDbContext _context;
        private readonly EmailService _email;
        private static int _OTP;

        public Akun(AppDbContext context, EmailService e)
        {
            _context = context;
            _email = e;
        }
        public IActionResult Daftar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Daftar(User parameter, int otp)
        {
            if (otp == _OTP)
            {
                Roles cariRoles = _context.Tb_Roles.FirstOrDefault(x => x.Id == "2");

                parameter.Roles = cariRoles;

                _context.Tb_User.Add(parameter);
                _context.SaveChanges();

                return RedirectToAction(actionName: "Masuk");
            }
            return View(parameter);
        }

        [HttpPost]
        public object KirimEmailOTP(string emailTujuan)
        {
            // cari email ke database
            var cariEmail = _context.Tb_User.FirstOrDefault(x => x.Email == emailTujuan);

            // pengecekan email
            // != null berarti email ditemukan
            if (cariEmail != null) return new { result = false, message = "Email " + emailTujuan + " sudah terdaftar" };

            BanyakBantuan _bantu = new();
            _OTP = BanyakBantuan.BuatOTP(); // dari helper, dan memasukan ke variable _OTP diatas

            // mengisi email
            string subjeknya = "Konfirmasi email untuk daftar akun";
            // bisa diisi html seperti img, a href, button, dll
            string isiEmailnya =
                "<h1>Berikut adalah OTP anda <i style='color: blue;'>"
                + _OTP.ToString()
                + "</i></h1>"
                + "<a href='mailto:dotnetlanjutan@gmail.com?subject=Bantuan&body=Hallo'>Bantuan</a>";

            // dari services/EmailService.cs
            bool cek = _email.KirimEmail(emailTujuan, subjeknya, isiEmailnya); // return nya true atau false

            // cek jika true
            if (cek) return new { result = true, message = "Email berhasil dikirimkan ke " + emailTujuan };

            // jika false
            return new { result = false, message = "Email " + emailTujuan + " tidak ditemukan" };
        }

        public IActionResult Masuk()
        {          
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Masuk(User data)
        {
            var username = _context.Tb_User.Where(
                        bebas =>
                        bebas.Username == data.Username
                        ).FirstOrDefault();

            if (username != null)
            {
                var password = _context.Tb_User.Where(bebas => bebas.Username == data.Username && bebas.Password == data.Password)
                    .Include(bebas2 => bebas2.Roles)
                    .FirstOrDefault();

                if (password != null)
                {
                    var daftar = new List<Claim>
                    {
                        new Claim("Username", username.Username),
                        new Claim("Role", username.Roles.Name)
                    };

                    await HttpContext.SignInAsync(
                       new ClaimsPrincipal(
                           new ClaimsIdentity(daftar, "Cookie", "Username", "Role")
                           )
                       );

                    if (username.Roles.Id == "1")
                    {
                        return Redirect("/Admin/Home");
                    }
                    else if (username.Roles.Id == "2")
                    {
                        return Redirect("/User/Home");
                    }

                    return RedirectToAction(controllerName: "Home", actionName: "Index");
                }
                ViewBag.pesan = "Password Anda Salah";
                return View(data);
            }
            ViewBag.pesan = "Username Anda Salah";
            return View(data);
        }

        public async Task<IActionResult> Keluar()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/");
        }
    }
}
