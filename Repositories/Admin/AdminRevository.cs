using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Traveler.Data;
using Traveler.Models;

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
    }
}
