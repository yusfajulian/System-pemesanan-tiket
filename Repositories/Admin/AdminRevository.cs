﻿using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Traveler.Data;
using Traveler.Models;
using Traveler.Service.File;

namespace Traveler.Repository.Admin
{
    public class AdminRevository : IAdminRevository
    {
        private readonly AppDbContext _Admin;
        public AdminRevository(AppDbContext Admin)
        {
            _Admin = Admin;
        }

        public async Task<bool> TambahPelanggan(Pelanggan baru)
        {
            _Admin.Tb_Pelanggan.Add(baru);
            await _Admin.SaveChangesAsync();

            return true;
        }

        public async Task<User> CariUsername(string username)
        {
            return await _Admin.Tb_User.FirstOrDefaultAsync(x => x.Username == username);
        }

        public async Task<List<transaksi>> TampilSemuaDataTransaksi()
        {
            return await _Admin.Tb_Transaksi.ToListAsync();
        }       

        public async Task<List<Pesawat>> TampilSemuaPesawat()
        {
            return await _Admin.Tb_Pesawat.ToListAsync();
        }

        public async Task<bool> TambahTransaksi(transaksi baru)
        {

            _Admin.Tb_Transaksi.Add(baru);
            await _Admin.SaveChangesAsync();

            return true;
        }

        public async Task<Pelanggan> CariId(string id)
        {
            return await _Admin.Tb_Pelanggan.FirstOrDefaultAsync(x => x.nik == id);
        }

        public async Task<Pesawat> CariIdPesawat(string id)
        {
            return await _Admin.Tb_Pesawat.FirstOrDefaultAsync(x => x.kode_pesawat == id);
        }

        public async Task<List<Kereta>> TampilSemuaKereta()
        {
            return await _Admin.Tb_Kereta.ToListAsync();
        }

        public async Task<List<Travel>> TampilSemuaTravel()
        {
            return await _Admin.Tb_Travel.ToListAsync();
        }

        public async Task<List<Pelanggan>> TampilSemuaPelanggan()
        {
            return await _Admin.Tb_Pelanggan.ToListAsync();
        }

        public async Task<List<transaksi>> TampilSemuaTransaksi()
        {
            return await _Admin.Tb_Transaksi.ToListAsync();
        }

        public async Task<bool> TambahPesawat(Pesawat parameter)
        {
            _Admin.Tb_Pesawat.Add(parameter);
            await _Admin.SaveChangesAsync();

            return true;
        }

        public async Task<bool> TambahKereta(Kereta parameter)
        {
            _Admin.Tb_Kereta.Add(parameter);
            await _Admin.SaveChangesAsync();

            return true;
        }

        public async Task<bool> TambahTravel(Travel parameter)
        {
            _Admin.Tb_Travel.Add(parameter);
            await _Admin.SaveChangesAsync();

            return true;
        }

        public async Task<bool> HapusPelanggan(Pelanggan id)
        {
            _Admin.Remove(id);
            await _Admin.SaveChangesAsync();

            return true;
        }

        public async Task<bool> HapusPesawat(Pesawat id)
        {
            _Admin.Remove(id);
            await _Admin.SaveChangesAsync();

            return true;
        }

        public async Task<bool> HapusKereta(Kereta id)
        {
             _Admin.Remove(id);
            await _Admin.SaveChangesAsync();

            return true;
        }

        public async Task<bool> HapusTravel(Travel id)
        {
             _Admin.Remove(id);
            await _Admin.SaveChangesAsync();

            return true;
        }

        public async Task<Kereta> CariIdKereta(string id)
        {
            return await _Admin.Tb_Kereta.FirstOrDefaultAsync(x => x.kode_kereta == id);
        }

        public async Task<Travel> CariIdTravel(string id)
        {
            return await _Admin.Tb_Travel.FirstOrDefaultAsync(x => x.kode_travel == id);
        }

        public async Task<transaksi> CariIdTransaksi(string id)
        {
            return await _Admin.Tb_Transaksi.FirstOrDefaultAsync(x => x.id_transaksi == id);
        }

        public async Task<bool> HapusTransaksi(transaksi id)
        {
            _Admin.Remove(id);
            await _Admin.SaveChangesAsync();

            return true;
        }

        public async Task<bool> UbahPesawat(Pesawat data)
        {
            _Admin.Tb_Pesawat.Update(data);
            await _Admin.SaveChangesAsync();

            return true;
        }

        public async Task<bool> UbahKereta(Kereta data)
        {
            _Admin.Tb_Kereta.Update(data);
            await _Admin.SaveChangesAsync();

            return true;
        }

        public async Task<bool> UbahTravel(Travel data)
        {
            _Admin.Tb_Travel.Update(data);
            await _Admin.SaveChangesAsync();

            return true;
        }

        public async Task<Pesawat> TampilSemuaPesawatId(string id)
        {
            return await _Admin.Tb_Pesawat.FirstOrDefaultAsync(x => x.kode_pesawat == id);
        }

        public async Task<Kereta> TampilSemuaKeretaId(string id)
        {
           return await _Admin.Tb_Kereta.FirstOrDefaultAsync (x => x.kode_kereta == id);
        }

        public async Task<Travel> TampilSemuaTravelId(string id)
        {
           return await _Admin.Tb_Travel.FirstOrDefaultAsync (x => x.kode_travel == id);
        }
    }
}
