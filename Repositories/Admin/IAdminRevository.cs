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
        Task<User> CariUsername(string username);
        Task<bool> TambahPelanggan(Pelanggan baru);
        Task<bool> TambahTransaksi(transaksi baru);
        Task<Pelanggan> CariId(string id);
        Task<Pesawat> CariIdPesawat(string id);
        Task<List<Kereta>> TampilSemuaKereta();

    }
}

