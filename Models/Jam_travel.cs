using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Traveler.Models
{
    public class Jam_travel
    {
        [Key]
        public string id_jam { get; set; }
        public string jam_berangkat { get; set; }
        public string jam_sampai { get; set; }
    }
}
