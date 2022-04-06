using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Traveler.Models
{
    public class Email
    {
        [Key]
        public string NamaClientnya { get; set; }
        public int Portnya { get; set; }
        public string EmailKita { get; set; }
        public string PasswordEmailKita { get; set; }
    }
}
