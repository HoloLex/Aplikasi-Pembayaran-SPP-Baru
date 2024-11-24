using App_SPP_New.Controller;
using MySql.Data.MySqlClient;
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
    public partial class TabelSiswa : Form
    {
        KoneksiSiswa kons = new KoneksiSiswa();
        public void Tampil()
        {
            //query
            DataTable.DataSource = kons.ShowData("SELECT * FROM tb_siswa");

            //tablee
            DataTable.Columns[0].HeaderText = "NISN";
            DataTable.Columns[1].HeaderText = "NIS";
            DataTable.Columns[2].HeaderText = "Nama Siswa";
            DataTable.Columns[3].HeaderText = "Id Kelas";
            DataTable.Columns[4].HeaderText = "Alamat";
            DataTable.Columns[5].HeaderText = "No Telepon";
            DataTable.Columns[6].HeaderText = "Id SPP";
        }
        public TabelSiswa()
        {
            InitializeComponent();
            PnlTop.Move_Form(Handle);
        }

        private void TabelSiswa_Load(object sender, EventArgs e)
        {
            Tampil();
            fillcombo2();
        }

        void fillcombo2()
        {
            string connstring = "Server=localhost;Database=db_spp;Uid=root;Pwd=;";
            string Query = "SELECT * FROM tb_siswa";
            MySqlConnection cons = new MySqlConnection(connstring);
            MySqlCommand cmd = new MySqlCommand(Query, cons);
            MySqlDataReader myReader;
            try
            {
                cons.Open();
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    string idcboxe = myReader["nama"].ToString();
                    CariNama.Items.Add(idcboxe);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
