using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Traveler.Models
{
    public class transaksi
    {
        [Key]
        public string id_transaksi { get; set; }
        public Pelanggan Pelanggan { get; set; }
        public Pesawat pesawat { get; set; }
    }
}
