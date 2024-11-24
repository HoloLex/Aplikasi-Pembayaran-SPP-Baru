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
    public partial class Form1 : Form
    {
        CekLogin login = new CekLogin();
        public Form1()
        {
            InitializeComponent();
            PnlTop.Move_Form(Handle);
        }

        private void Login_Click(object sender, EventArgs e)
        {
            if(Username.Text == "" || Password.Text == "")
            {
                MessageBox.Show("Username dan/atau Password Tidak Boleh Kosong!", "Ada Yang Kosong...");
            }
            else
            {
                string username = Username.Text;
                string password = Password.Text;

                bool status = login.cek_login(username, password);
                if (status)
                {
                  MessageBox.Show("Login Sukses! Menuju ke Halaman Admin...", "Sukses!");
                    MenuAdmin form = new MenuAdmin();
                    MenuStart form1 = new MenuStart();
                    form1.Hide();
                    form.Show();
                    this.Hide();
                }
                else
                {
                  MessageBox.Show("Username/Password Salah! Silahkan Cek Kembali....", "User/Pass Salah!");
                }
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            MenuStart form = new MenuStart();
            form.Show();
            this.Hide();

        }

        private void ShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPass.Checked)
            {
                Password.PasswordChar = '\0';
            }
            else
            {
                Password.PasswordChar = '*';
            }
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
