using App_SPP_New.Controller;
using App_SPP_New.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_SPP_New
{
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
            PnlTop.Move_Form(Handle);
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void Tombol_Kelas_Click(object sender, EventArgs e)
        {
            FormKelas FKelas = new FormKelas();
            FKelas.Show();
            this.Hide();
        }

        private void Tombol_Siswa_Click(object sender, EventArgs e)
        {
            FormSiswa FSiswa = new FormSiswa();
            FSiswa.Show();
            this.Hide();
        }

        private void Tombol_Laporan_Click(object sender, EventArgs e)
        {
            FormKelas Kelas = new FormKelas();
            Kelas.Show();
            this.Hide();
        }

        private void Tombol_Tagihan_Click(object sender, EventArgs e)
        {
            FormBayar FBayar = new FormBayar();
            FBayar.Show();
            this.Hide();
        }

        private void Tombol_SPP_Click(object sender, EventArgs e)
        {
            FormSPP FSPP = new FormSPP();
            FSPP.Show();
            this.Hide();
        }

        private void Tombol_User_Click(object sender, EventArgs e)
        {
            FormPetugas FUser = new FormPetugas();
            FUser.Show();
            this.Hide();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Close_MouseMove(object sender, MouseEventArgs e)
        {
            ((Button)sender).BackColor = Color.Red;
        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(255, 128, 128);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Jam.Text = DateTime.Now.ToString("HH:mm:ss");
            Tanggal.Text = DateTime.Now.ToString("dddd, MMM dd yyyy");
        }

        private void MenuAdmin_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
