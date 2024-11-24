using App_SPP_New.Controller;
using App_SPP_New.Model;
using App_SPP_New.CustomUI;
using MySql.Data.MySqlClient;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace App_SPP_New.View
{
    public partial class FormBayar : Form
    {
        KoneksiBayar konba = new KoneksiBayar();
        Model_Bayar bayar = new Model_Bayar();
        string id_pembayaran;

        public void Tampil()
        {
            //query
            DataTable.DataSource = konba.ShowData("SELECT * FROM tb_pembayaran");

            //tablee
            DataTable.Columns[0].HeaderText = "Id Pembayaran";
            DataTable.Columns[1].HeaderText = "Id Petugas";
            DataTable.Columns[2].HeaderText = "NISN";
            DataTable.Columns[3].HeaderText = "Tanggal Bayar";
            DataTable.Columns[4].HeaderText = "Bulan Bayar";
            DataTable.Columns[5].HeaderText = "Tahun Bayar";
            DataTable.Columns[6].HeaderText = "Id SPP";
            DataTable.Columns[7].HeaderText = "Jumlah Bayar";
        }

        public FormBayar()
        {
            InitializeComponent();
            PnlTop.Move_Form(Handle);
            fillcombo();
            fillcombo1();
            fillcombo2();
            fillcombo3();
            fillcombo4();
        }

        void fillcombo()
        {
            string connstring = "Server=localhost;Database=db_spp;Uid=root;Pwd=;";
            string Query = "SELECT * FROM tb_spp";
            MySqlConnection cons = new MySqlConnection(connstring);
            MySqlCommand cmd = new MySqlCommand(Query, cons);
            MySqlDataReader myReader;
            try
            {
                cons.Open();
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    string idcbox = myReader["id_spp"].ToString();
                    IdSPP.Items.Add(idcbox);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void fillcombo1()
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
                    string idcboxx = myReader["nisn"].ToString();
                    NISN.Items.Add(idcboxx);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void fillcombo2()
        {
            string connstring = "Server=localhost;Database=db_spp;Uid=root;Pwd=;";
            string Query = "SELECT * FROM tb_petugas";
            MySqlConnection cons = new MySqlConnection(connstring);
            MySqlCommand cmd = new MySqlCommand(Query, cons);
            MySqlDataReader myReader;
            try
            {
                cons.Open();
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    string idcboxe = myReader["id_petugas"].ToString();
                    IdPetugas.Items.Add(idcboxe);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void fillcombo4()
        {
            string connstring = "Server=localhost;Database=db_spp;Uid=root;Pwd=;";
            string Query = "SELECT * FROM tb_pembayaran";
            MySqlConnection cons = new MySqlConnection(connstring);
            MySqlCommand cmd = new MySqlCommand(Query, cons);
            MySqlDataReader myReader;
            try
            {
                cons.Open();
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    string idcboxe = myReader["nisn"].ToString();
                    CariNISN.Items.Add(idcboxe);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void fillcombo3()
        {
            for (int i = 1950; i <= 2050; i++)
            TahunBayar.Items.Add(i);
        }

        private void FormBayar_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        private void Simpan_Click(object sender, EventArgs e)
        {
            if (IdPetugas.SelectedIndex == -1 || NISN.SelectedIndex == -1 || TahunBayar.SelectedIndex == -1 || BulanBayar.SelectedIndex == -1 || JumlahBayar.Text == "0" || IdSPP.SelectedIndex == -1)
            {
                MessageBox.Show("Semua Data/Salah Satu Data Tidak Boleh Kosong!", "kosong....", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Control_Bayar ba = new Control_Bayar();
                bayar.Id_petugas = IdPetugas.Text;
                bayar.Nisn = NISN.Text;
                bayar.Tgl_bayar = TanggalBayar.Text;
                bayar.Bulan_dibayar = BulanBayar.Text;
                bayar.Tahun_dibayar = TahunBayar.Text;
                bayar.Jumlah_bayar = JumlahBayar.Text;

                ba.insert(bayar);
                IdPetugas.SelectedIndex = -1;
                NISN.SelectedIndex = -1;
                BulanBayar.SelectedIndex = -1;
                TahunBayar.SelectedIndex = -1;
                IdSPP.SelectedIndex = -1;
                JumlahBayar.Text = "0";
                Tampil();
            }
        }

        private void Kembali_Click(object sender, EventArgs e)
        {
            MenuAdmin form = new MenuAdmin();
            form.Show();
            this.Hide();
        }

        private void Ubah_Click(object sender, EventArgs e)
        {
            if (IdPetugas.SelectedIndex == -1 || NISN.SelectedIndex == -1 || TahunBayar.SelectedIndex == -1 || BulanBayar.SelectedIndex == -1 || JumlahBayar.Text == "0" || IdSPP.SelectedIndex == -1)
            {
                MessageBox.Show("Semua Data/Salah Satu Data Tidak Boleh Kosong!", "kosong....", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Control_Bayar ba = new Control_Bayar();
                bayar.Id_petugas = IdPetugas.Text;
                bayar.Nisn = NISN.Text;
                bayar.Tgl_bayar = TanggalBayar.Text;
                bayar.Bulan_dibayar = BulanBayar.Text;
                bayar.Tahun_dibayar = TahunBayar.Text;
                bayar.Jumlah_bayar = JumlahBayar.Text;

                ba.update(bayar);
                IdPetugas.SelectedIndex = -1;
                NISN.SelectedIndex = -1;
                BulanBayar.SelectedIndex = -1;
                TahunBayar.SelectedIndex = -1;
                IdSPP.SelectedIndex = -1;
                JumlahBayar.Text = "0";
                Tampil();
            }
        }

        private void Hapus_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show("Yakin hapus data ini?", "Perhatian!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pesan == DialogResult.Yes)
            {
                Control_Bayar ba = new Control_Bayar();
                ba.delete(id_pembayaran);
                Tampil();
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            CariNISN.SelectedIndex = -1;
        }

        private void DataTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            IdPetugas.Text = DataTable.Rows[e.RowIndex].Cells[1].Value.ToString();
            NISN.Text = DataTable.Rows[e.RowIndex].Cells[2].Value.ToString();
            TanggalBayar.Text = DataTable.Rows[e.RowIndex].Cells[3].Value.ToString();
            BulanBayar.Text = DataTable.Rows[e.RowIndex].Cells[4].Value.ToString();
            TahunBayar.Text = DataTable.Rows[e.RowIndex].Cells[5].Value.ToString();
            IdSPP.Text = DataTable.Rows[e.RowIndex].Cells[6].Value.ToString();
            JumlahBayar.Text = DataTable.Rows[e.RowIndex].Cells[7].Value.ToString();
        }

        private void CariNISN_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable.DataSource = konba.ShowData("SELECT * FROM tb_pembayaran WHERE nisn LIKE '%' '" + CariNISN.Text + "'");
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EksporExcel(DataGridView dataGrid, string filename)
        {
            string Output = "";
            string Headers = "";

            //ekspor judul file
            for(int j  = 0; j < dataGrid.Columns.Count; j++)
            {
                Headers = Headers.ToString() + Convert.ToString(dataGrid.Columns[j].HeaderText) + "\t";
            }
            Output += Headers + "\r\n";

            //ekspor data
            for (int i = 0; i < dataGrid.RowCount - 1; i++)
            {
                string Line = "";
                for(int j = 0; j < dataGrid.Rows[i].Cells.Count; j++)
                {
                    Line = Line.ToString() + Convert.ToString(dataGrid.Rows[i].Cells[j].Value) + "\t";
                }
                Output += Line + "\r\n";
            }
            Encoding encoding = Encoding.GetEncoding(1254);
            byte[] outputs = encoding.GetBytes(Output);
            FileStream file = new FileStream(filename,FileMode.Create);
            BinaryWriter binary = new BinaryWriter(file);
            binary.Write(outputs,0,outputs.Length);
            binary.Flush();
            binary.Close();
            file.Close();
        }
        private void Ekspor_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel Documents (*.xls)|*.xls";
            save.FileName = "Pemasukkan SPP.xls";

            if(save.ShowDialog() == DialogResult.OK)
            {
                EksporExcel(DataTable, save.FileName);
            }
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

        private void TblSPP_Click(object sender, EventArgs e)
        {
            TabellSPP form = new TabellSPP();
            form.Show();
        }

        private void TblPetugas_Click(object sender, EventArgs e)
        {
            TabelPetugas form = new TabelPetugas();
            form.Show();
        }

        private void TblSiswa_Click(object sender, EventArgs e)
        {
            TabelSiswa form = new TabelSiswa();
            form.Show();
        }
    }
}
