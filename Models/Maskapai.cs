﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Traveler.Models
{
    public class Maskapai
    {
        [Key]
        public string id_maskapai { get; set; }
        public string nama { get; set; }
    }
}
