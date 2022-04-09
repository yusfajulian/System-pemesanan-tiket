using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Traveler.Models;

namespace Traveler.Service.AdminService
{
    public interface IAdminService
    {
        Task<List<Pesawat>> TampilSemuaPesawat();
        Task<bool> TambahPelanggan(Pelanggan baru);
        Task<bool> TambahTransaksi(transaksi transaksi, string data, string id);
        Task<List<Kereta>> TampilSemuaKereta();
        Task<List<Travel>> TampilSemuaTravel();
        Task<List<transaksi>> TampilSemuaTransaksi();
        Task<List<Pelanggan>> TampilSemuaPelanggan();
        Task<bool> TambahPesawat(Pesawat parameter, IFormFile fotonya);
        Task<bool> TambahKereta(Kereta parameter, IFormFile fotonya);
        Task<bool> TambahTravel(Travel parameter, IFormFile fotonya);
    }
}
