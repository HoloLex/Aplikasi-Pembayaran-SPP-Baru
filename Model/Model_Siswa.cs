using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_SPP_New.Model
{
    internal class Model_Siswa
    {
        //dont forget ctr+r+e lolz
        string nisn, nis, nama, id_kelas, alamat, no_telp, id_spp;

        public Model_Siswa(string nisn, string nis, string nama, string id_kelas, string alamat, string no_telp, string id_spp)
        {
            this.Nisn = nisn;
            this.Nis = nis;
            this.Nama = nama;
            this.Id_kelas = id_kelas;
            this.Alamat = alamat;
            this.No_telp = no_telp;
            this.Id_spp = id_spp;
        }

        public Model_Siswa() { }

        public string Nisn { get => nisn; set => nisn = value; }
        public string Nis { get => nis; set => nis = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Id_kelas { get => id_kelas; set => id_kelas = value; }
        public string Alamat { get => alamat; set => alamat = value; }
        public string No_telp { get => no_telp; set => no_telp = value; }
        public string Id_spp { get => id_spp; set => id_spp = value; }
    }
}
