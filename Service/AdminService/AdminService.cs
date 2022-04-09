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

        public async Task<bool> TambahKereta(Kereta parameter, IFormFile fotonya)
        {
            parameter.kode_kereta = Helper.BuatPrimary.buatPrimary();
            parameter.image = await _file.SimpanFile(fotonya);

            return await _AdminRevo.TambahKereta(parameter);
        }

        public async Task<bool> TambahPelanggan(Pelanggan baru)
        {
            return await _AdminRevo.TambahPelanggan(baru);
        }

        public async Task<bool> TambahPesawat(Pesawat parameter, IFormFile fotonya)
        {
            parameter.kode_pesawat = Helper.BuatPrimary.buatPrimary();
            parameter.image = await _file.SimpanFile(fotonya);

            return await _AdminRevo.TambahPesawat(parameter);
        }

        public async Task<bool> TambahTransaksi(transaksi transaksi, string data,string id)
        {
            transaksi.id_transaksi = BuatPrimary.buatPrimary();
            transaksi.Pelanggan = await _AdminRevo.CariId(data);
            transaksi.pesawat = await _AdminRevo.CariIdPesawat(id);

            return await _AdminRevo.TambahTransaksi(transaksi);
        }

        public async Task<bool> TambahTravel(Travel parameter, IFormFile fotonya)
        {
            parameter.kode_travel = Helper.BuatPrimary.buatPrimary();
            parameter.image = await _file.SimpanFile(fotonya);

            return await _AdminRevo.TambahTravel(parameter);
        }

        public Task<List<Kereta>> TampilSemuaKereta()
        {
            return _AdminRevo.TampilSemuaKereta();
        }

        public Task<List<Pelanggan>> TampilSemuaPelanggan()
        {
            return _AdminRevo.TampilSemuaPelanggan();
        }

        public Task<List<Pesawat>> TampilSemuaPesawat()
        {
            return _AdminRevo.TampilSemuaPesawat();
        }

        public Task<List<transaksi>> TampilSemuaTransaksi()
        {
            return _AdminRevo.TampilSemuaTransaksi();
        }

        public Task<List<Travel>> TampilSemuaTravel()
        {
            return _AdminRevo.TampilSemuaTravel();
        }
    }
}
