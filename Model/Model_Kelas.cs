using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_SPP_New.Model
{
    internal class Model_Kelas
    {
        //dont forget ctr+r+e lolz
        string nama_kelas, kompetensi_keahlian;

        public Model_Kelas(string nama_kelas, string kompetensi_keahlian)
        {
            this.nama_kelas = nama_kelas;
            this.kompetensi_keahlian = kompetensi_keahlian;
        }

        public Model_Kelas() { }

        public string Nama_kelas { get => nama_kelas; set => nama_kelas = value; }
        public string Kompetensi_keahlian { get => kompetensi_keahlian; set => kompetensi_keahlian = value; }
    }
}
