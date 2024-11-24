using App_SPP_New.Controller;
using App_SPP_New.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_SPP_New
{
    public partial class FormKelasP : Form
    {
        KoneksiKelas konkel = new KoneksiKelas();
        Model_Kelas kelas = new Model_Kelas();
        string id;

        public void Tampil()
        {
            //query
            DataTable.DataSource = konkel.ShowData("SELECT * FROM tb_kelas");

            //tablee
            DataTable.Columns[0].HeaderText = "Id Kelas";
            DataTable.Columns[1].HeaderText = "Nama Kelas";
            DataTable.Columns[2].HeaderText = "Kompetensi Keahlian";

        }

        public FormKelasP()
        {
            InitializeComponent();
            PnlTop.Move_Form(Handle);
        }

        private void Kembali_Click(object sender, EventArgs e)
        {
            MenuPetugas form = new MenuPetugas();
            form.Show();
            this.Hide();
        }

        private void FormKelas_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        private void CariKK_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable.DataSource = konkel.ShowData("SELECT * FROM tb_kelas WHERE kompetensi_keahlian LIKE '%' '" + CariKK.Text + "'");
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            CariKK.SelectedIndex = -1;
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
            ((Button)sender).BackColor = Color.Red;
        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(255, 128, 128);
        }
    }
}

