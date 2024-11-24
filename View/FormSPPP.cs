using App_SPP_New.Controller;
using App_SPP_New.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_SPP_New
{
    public partial class FormSPPP : Form
    {
        koneksi kon = new koneksi();
        Model_SPP spp = new Model_SPP();
        string id;

        public void Tampil()
        {
            //query
            DataTable.DataSource = kon.ShowData("SELECT * FROM tb_spp");

            //tablee
            DataTable.Columns[0].HeaderText = "Id SPP";
            DataTable.Columns[1].HeaderText = "Tahun SPP";
            DataTable.Columns[2].HeaderText = "Nominal";

        }

        public FormSPPP()
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

        private void FormSPP_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        private void CariTahun_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable.DataSource = kon.ShowData("SELECT * FROM tb_spp WHERE tahun LIKE '%' '" + CariTahun.Text + "'");
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            CariTahun.SelectedIndex = -1;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

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
