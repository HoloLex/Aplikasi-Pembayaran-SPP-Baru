using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_SPP_New.Model
{
    internal class Model_SPP
    {
        //dont forget ctr+r+e lolz
        string tahun, nominal;

        public Model_SPP(string tahun, string nominal)
        {
            this.Tahun = tahun;
            this.Nominal = nominal;
        }

        public Model_SPP() { }

        public string Tahun { get => tahun; set => tahun = value; }
        public string Nominal { get => nominal; set => nominal = value; }
    }
}
