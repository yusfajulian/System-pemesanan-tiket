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
        public string email { get; set; }
    }
}
