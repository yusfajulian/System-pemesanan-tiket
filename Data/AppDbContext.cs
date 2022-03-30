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
        public virtual DbSet<Travel> Tb_Travel { get; set; }
    }
}
