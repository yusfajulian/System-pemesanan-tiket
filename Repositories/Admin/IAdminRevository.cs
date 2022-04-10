using Microsoft.AspNetCore.Http;
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
        Task<Kereta> CariIdKereta(string id);
        Task<Travel> CariIdTravel(string id);
        Task<transaksi> CariIdTransaksi(string id);
        Task<List<Kereta>> TampilSemuaKereta();
        Task<List<Travel>> TampilSemuaTravel();
        Task<List<Pelanggan>> TampilSemuaPelanggan();
        Task<List<transaksi>> TampilSemuaTransaksi();
        Task<bool> TambahPesawat(Pesawat parameter);
        Task<bool> TambahKereta(Kereta parameter);
        Task<bool> TambahTravel(Travel parameter);
        Task<bool> HapusPelanggan(Pelanggan id);
        Task<bool> HapusPesawat(Pesawat id);
        Task<bool> HapusKereta(Kereta id);
        Task<bool> HapusTravel(Travel id);
        Task<bool> HapusTransaksi(transaksi id);
        Task<bool> UbahPesawat(Pesawat data);
        Task<bool> UbahKereta(Kereta data);
        Task<bool> UbahTravel(Travel data);
        Task<Pesawat> TampilSemuaPesawatId(string id);
        Task<Kereta>TampilSemuaKeretaId(string id);
        Task<Travel>TampilSemuaTravelId(string id);
    }
}

