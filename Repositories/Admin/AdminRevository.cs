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

        public async Task<List<transaksi>> TampilSemuaDataTransaksi()
        {
            return await _Admin.Tb_Transaksi.ToListAsync();
        }

        public async Task<List<Jam_pesawat>> TampilSemuaJampesawat()
        {
            return await _Admin.Tb_JamPesawat.ToListAsync();
        }

        public async Task<List<Maskapai>> TampilSemuaMaskapai()
        {
            return await _Admin.Tb_Maskapan.ToListAsync();
        }

        public async Task<List<Pesawat>> TampilSemuaPesawat()
        {
            return await _Admin.Tb_Pesawat.ToListAsync();
        }
    }
}
