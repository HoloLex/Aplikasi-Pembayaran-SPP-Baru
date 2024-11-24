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
    public partial class TabelKelas : Form
    {
        KoneksiKelas konkel = new KoneksiKelas();

        public void Tampil()
        {
            //query
            DataTable.DataSource = konkel.ShowData("SELECT * FROM tb_kelas");

            //tablee
            DataTable.Columns[0].HeaderText = "Id Kelas";
            DataTable.Columns[1].HeaderText = "Nama Kelas";
            DataTable.Columns[2].HeaderText = "Kompetensi Keahlian";

        }
        public TabelKelas()
        {
            InitializeComponent();
            PnlTop.Move_Form(Handle);
        }

        private void TabelKelas_Load(object sender, EventArgs e)
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

        private void CariKompe_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable.DataSource = konkel.ShowData("SELECT * FROM tb_kelas WHERE kompetensi_keahlian LIKE '%' '" + CariKompe.Text + "'");
        }
    }
}
