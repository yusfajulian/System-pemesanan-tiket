using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Traveler.Models
{
    public class Jenis_travel
    {
        [Key]
        public string id_jenistrav { get; set; }
        public string nama { get; set; }
    }
}
