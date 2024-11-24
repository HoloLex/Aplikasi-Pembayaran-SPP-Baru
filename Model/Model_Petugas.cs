using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_SPP_New.Model
{
    internal class Model_Petugas
    {
        //dont forget ctr+r+e lolz
        string username, password, nama_petugas, level;

        public Model_Petugas(string username, string password, string nama_petugas, string level)
        {
            this.Username = username;
            this.Password = password;
            this.Nama_petugas = nama_petugas;
            this.Level = level;
        }

        public Model_Petugas() { }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Nama_petugas { get => nama_petugas; set => nama_petugas = value; }
        public string Level { get => level; set => level = value; }
    }
}
