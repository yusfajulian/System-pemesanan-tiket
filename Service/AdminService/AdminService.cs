using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Traveler.Models;
using Traveler.Repository.Admin;

namespace Traveler.Service.AdminService
{
    public class AdminService : IAdminService
    {
        public readonly IAdminRevository _AdminRevo;
        public AdminService(IAdminRevository admin)
        {
            _AdminRevo = admin;
        }
        public async Task<List<Pesawat>> TampilSemuaPesawat()
        {
            return await _AdminRevo.TampilSemuaPesawat();
        }
    }
}
