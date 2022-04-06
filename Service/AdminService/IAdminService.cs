using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Traveler.Models;

namespace Traveler.Service.AdminService
{
    public interface IAdminService
    {
        Task<List<Pesawat>> TampilSemuaPesawat();
    }
}
