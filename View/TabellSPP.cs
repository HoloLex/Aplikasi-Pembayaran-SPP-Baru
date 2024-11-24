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
    public partial class TabellSPP : Form
    {
        koneksi kon = new koneksi();
        public void Tampil()
        {
            //query
            DataTable.DataSource = kon.ShowData("SELECT * FROM tb_spp");

            //tablee
            DataTable.Columns[0].HeaderText = "Id SPP";
            DataTable.Columns[1].HeaderText = "Tahun SPP";
            DataTable.Columns[2].HeaderText = "Nominal";

        }
        public TabellSPP()
        {
            InitializeComponent();
        }

        private void TabellSPP_Load(object sender, EventArgs e)
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

        private void Tutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Close_MouseMove(object sender, MouseEventArgs e)
        {
            ((System.Windows.Forms.Button)sender).BackColor = Color.Red;
        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            ((System.Windows.Forms.Button)sender).BackColor = Color.FromArgb(255, 128, 128);
        }

        private void CariTahun_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable.DataSource = kon.ShowData("SELECT * FROM tb_spp WHERE tahun LIKE '%' '" + CariTahun.Text + "'");
        }
    }
}
