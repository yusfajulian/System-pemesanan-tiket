using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Traveler.Models
{
    public class Pelanggan
    {
        [Key]
        public string nik { get; set; }
        [Required]
        public string nama_pelanggan { get; set; }
        [Required]
        public bool kartu_vaksin { get; set; }
        [Required]
        public string no_telp { get; set; }
        [Required]
        public DateTime tanggal_berangkat { get; set; }
        public string email { get; set; }
        public string type { get; set; }
    }

     public class AdminDashBoard
    {
        public List<Pelanggan> pelanggan { get; set; }
        public List<Pesawat> pesawat { get; set; }
        public List<Kereta> kereta { get; set; }
        public List<Travel> travel { get; set; }
        public List<transaksi> Transaksi { get; set; }

        public AdminDashBoard()
        {
            pelanggan = new List<Pelanggan>();
            pesawat = new List<Pesawat>();
            kereta = new List<Kereta>();
            travel = new List<Travel>();
            Transaksi = new List<transaksi>();
        }
    }
}
