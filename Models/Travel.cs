using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Traveler.Models
{
    public class Travel
    {
        [Key]
        public string kode_travel { get; set; }
        public string Tempat { get; set; }
    }
}
