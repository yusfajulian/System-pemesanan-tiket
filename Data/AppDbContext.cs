using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Traveler.Models;

namespace Traveler.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
           : base(options)
        {

        }

        public virtual DbSet<Pesawat> Tb_Pesawat { get; set; }
        public virtual DbSet<Kereta> Tb_Kereta { get; set; }
        //public virtual DbSet<Travel> Tb_Travel { get; set; }
        //public virtual DbSet<Maskapai> Tb_Maskapan { get; set; }
        //public virtual DbSet<Jenis_kereta> Tb_JenisKereta { get; set; }
        //public virtual DbSet<Jenis_travel> Tb_JenisTravel { get; set; }
        public virtual DbSet<Pelanggan> Tb_Pelanggan { get; set; }
        public virtual DbSet<transaksi> Tb_Transaksi { get; set; }
        public virtual DbSet<Roles> Tb_Roles { get; set; }
        public virtual DbSet<User> Tb_User { get; set; }
        //public virtual DbSet<Kelas> tb_kelas { get; set; }
        //public virtual DbSet<tampPesawat> Tb_tampPes { get; set; }
    }
}
