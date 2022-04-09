using Microsoft.AspNetCore.Http;
using Traveler.Helper;
using Traveler.Models;
using Traveler.Repository.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Traveler.Service.File;

namespace Traveler.Service.AdminService
{
    public class AdminService : IAdminService
    {
        public readonly IAdminRevository _AdminRevo;
        private readonly FileService _file;
        public AdminService(IAdminRevository admin, FileService file)
        {
            _AdminRevo = admin;
            _file = file;
        }

        public async Task<bool> TambahPelanggan(Pelanggan baru)
        {
            return await _AdminRevo.TambahPelanggan(baru);
        }

        public async Task<bool> TambahTransaksi(transaksi transaksi, string data,string id)
        {
            transaksi.id_transaksi = BuatPrimary.buatPrimary();
            transaksi.Pelanggan = await _AdminRevo.CariId(data);
            transaksi.pesawat = await _AdminRevo.CariIdPesawat(id);

            return await _AdminRevo.TambahTransaksi(transaksi);
        }

        public List<Kereta> TampilSemuaKereta()
        {
            return _AdminRevo.TampilSemuaKereta().Result;
        }
        public List<Pesawat> TampilSemuaPesawat()
        {
            return _AdminRevo.TampilSemuaPesawat().Result;
        }
    }
}
