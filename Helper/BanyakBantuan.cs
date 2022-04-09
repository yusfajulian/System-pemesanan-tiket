﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traveler.Helper
{
    public class BanyakBantuan
    {
        public static int BuatOTP()
        {
            Random mulai = new Random();

            int nilainya = mulai.Next(1000, 9999);
            return nilainya;
        }

        public Object BuatResponAPI(int respon_code, string message, Object data)
        {
            return new
            {
                status = respon_code == 200 ? "SUKSES" : "GAGAL",
                respon_code,
                message,
                data
            };
        }


        // API
        public int CodeOk = 200;

        public int CodeBadRequest = 400;

        public int CodeInternalServerError = 500;

        public string PesanGetSukses(string apa)
        {
            return "Berhasil ambil data " + apa;
        }

        public string PesanTambahSukses(string apa)
        {
            return "Berhasil menambah data " + apa;
        }

        public string PesanUbahSukses(string apa)
        {
            return "Berhasil ubah data " + apa;
        }

        public string PesanHapusSukses(string apa)
        {
            return "Berhasil hapus data " + apa;
        }

        public string PesanTidakDitemukan(string apa)
        {
            return "Data " + apa + " tidak ditemukan";
        }

        public string PesanInputanSalah(string apa)
        {
            return "Inputan untuk data " + apa + " salah";
        }
    }
}
