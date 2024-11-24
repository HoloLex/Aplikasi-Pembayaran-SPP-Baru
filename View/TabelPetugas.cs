using App_SPP_New.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_SPP_New.View
{
    public partial class TabelPetugas : Form
    {
        KoneksiPetugas konp = new KoneksiPetugas();
        public void Tampil()
        {
            //query
            DataTable.DataSource = konp.ShowData("SELECT * FROM tb_petugas");

            //tablee
            DataTable.Columns[0].HeaderText = "Id Petugas";
            DataTable.Columns[1].HeaderText = "Username";
            DataTable.Columns[2].HeaderText = "Password";
            DataTable.Columns[3].HeaderText = "Nama Petugas";
            DataTable.Columns[4].HeaderText = "Level";

        }
        public TabelPetugas()
        {
            InitializeComponent();
            PnlTop.Move_Form(Handle);
        }

        private void TabelPetugas_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Close_MouseMove(object sender, MouseEventArgs e)
        {
            ((System.Windows.Forms.Button)sender).BackColor = Color.Red;
        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            ((System.Windows.Forms.Button)sender).BackColor = Color.FromArgb(255, 128, 128);
        }

        private void Tutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
