using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_SPP_New.Model
{
    internal class Model_Bayar
    {
        //dont forget ctr+r+e lolz
        string id_pembayaran, id_petugas, nisn, tgl_bayar, bulan_dibayar, tahun_dibayar, id_spp, jumlah_bayar;

        public Model_Bayar(string id_pembayaran, string id_petugas, string nisn, string tgl_bayar, string bulan_dibayar, string tahun_dibayar, string id_spp, string jumlah_bayar)
        {
            this.Id_pembayaran = id_pembayaran;
            this.Id_petugas = id_petugas;
            this.Nisn = nisn;
            this.Tgl_bayar = tgl_bayar;
            this.Bulan_dibayar = bulan_dibayar;
            this.Tahun_dibayar = tahun_dibayar;
            this.Id_spp = id_spp;
            this.Jumlah_bayar = jumlah_bayar;
        }

        public string Id_pembayaran { get => id_pembayaran; set => id_pembayaran = value; }
        public string Id_petugas { get => id_petugas; set => id_petugas = value; }
        public string Nisn { get => nisn; set => nisn = value; }
        public string Tgl_bayar { get => tgl_bayar; set => tgl_bayar = value; }
        public string Bulan_dibayar { get => bulan_dibayar; set => bulan_dibayar = value; }
        public string Tahun_dibayar { get => tahun_dibayar; set => tahun_dibayar = value; }
        public string Id_spp { get => id_spp; set => id_spp = value; }
        public string Jumlah_bayar { get => jumlah_bayar; set => jumlah_bayar = value; }

        public Model_Bayar() { }
    }
}
