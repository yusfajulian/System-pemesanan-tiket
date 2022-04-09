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
        List<Pesawat> TampilSemuaPesawat();
        Task<bool> TambahPelanggan(Pelanggan baru);
        Task<bool> TambahTransaksi(transaksi transaksi, string data, string id);
        List<Kereta> TampilSemuaKereta();
    }
}
