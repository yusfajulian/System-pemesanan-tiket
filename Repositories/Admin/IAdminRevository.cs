using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Traveler.Models;

namespace Traveler.Repository.Admin
{
    public interface IAdminRevository
    {
        Task<List<transaksi>> TampilSemuaDataTransaksi();
        Task<List<Pesawat>> TampilSemuaPesawat();
        Task<List<Jam_pesawat>> TampilSemuaJampesawat();
        Task<List<Maskapai>> TampilSemuaMaskapai();
    }
}
