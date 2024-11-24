using App_SPP_New.Controller;
using App_SPP_New.Model;
using App_SPP_New.CustomUI;
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
using App_SPP_New.View;
using System.IO;

namespace App_SPP_New
{
    public partial class FormSiswa : Form
    {
        KoneksiSiswa kons = new KoneksiSiswa();
        Model_Siswa siswa = new Model_Siswa();
        string id;

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

        public FormSiswa()
        {
            InitializeComponent();
            PnlTop.Move_Form(Handle);
            fillcombo();
            fillcombo1();
            fillcombo2();
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

                while(myReader.Read())
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
            string Query = "SELECT * FROM tb_kelas";
            MySqlConnection cons = new MySqlConnection(connstring);
            MySqlCommand cmd = new MySqlCommand(Query, cons);
            MySqlDataReader myReader;
            try
            {
                cons.Open();
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    string idcboxx = myReader["id_kelas"].ToString();
                    IdKelas.Items.Add(idcboxx);
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
                    string idcboxe = myReader["nisn"].ToString();
                    CariNISN.Items.Add(idcboxe);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Simpan_Click(object sender, EventArgs e)
        {
            if (NISN.Texts == "" || NIS.Texts == "" || NamaSiswa.Texts == "" || IdKelas.SelectedIndex == -1 || Alamat.Texts == "" || NoTelepon.Texts == "" || IdSPP.SelectedIndex == -1)
            {
                MessageBox.Show("Semua Data/Salah Satu Data Tidak Boleh Kosong!", "kosong....", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Control_Siswa si = new Control_Siswa();
                siswa.Nisn = NISN.Texts;
                siswa.Nis = NIS.Texts;
                siswa.Nama = NamaSiswa.Texts;
                siswa.Id_kelas = IdKelas.Text;
                siswa.Alamat = Alamat.Texts;
                siswa.No_telp = NoTelepon.Texts;
                siswa.Id_spp = IdSPP.Text;

                si.insert(siswa);
                NISN.Texts = "";
                NIS.Texts = "";
                NamaSiswa.Texts = "";
                IdKelas.SelectedIndex = -1;
                Alamat.Texts = "";
                NoTelepon.Texts = "";
                IdSPP.SelectedIndex = -1;
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
            if (NISN.Texts == "" || NIS.Texts == "" || NamaSiswa.Texts == "" || IdKelas.SelectedIndex == -1 || Alamat.Texts == "" || NoTelepon.Texts == "" || IdSPP.SelectedIndex == -1)
            {
                MessageBox.Show("Semua Data/Salah Satu Data Tidak Boleh Kosong!", "kosong....", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Control_Siswa si = new Control_Siswa();
                siswa.Nisn = NISN.Texts;
                siswa.Nis = NIS.Texts;
                siswa.Nama = NamaSiswa.Texts;
                siswa.Id_kelas = IdKelas.Text;
                siswa.Alamat = Alamat.Texts;
                siswa.No_telp = NoTelepon.Texts;
                siswa.Id_spp = IdSPP.Text;

                si.update(siswa);
                NISN.Texts = "";
                NIS.Texts = "";
                NamaSiswa.Texts = "";
                IdKelas.SelectedIndex = -1;
                Alamat.Texts = "";
                NoTelepon.Texts = "";
                IdSPP.SelectedIndex = -1;
                Tampil();
            }
        }

        private void Hapus_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show("Yakin hapus data ini?", "Perhatian!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pesan == DialogResult.Yes)
            {
                Control_Siswa si = new Control_Siswa();
                siswa.Nisn = NISN.Texts;

                si.delete(siswa);
                NISN.Texts = "";
                NIS.Texts = "";
                NamaSiswa.Texts = "";
                IdKelas.SelectedIndex = -1;
                Alamat.Texts = "";
                NoTelepon.Texts = "";
                IdSPP.SelectedIndex = -1;
                Tampil();
            }
        }

        private void FormSiswa_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            CariNISN.SelectedIndex = -1;
        }

        private void DataTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NISN.Texts  = DataTable.Rows[e.RowIndex].Cells[0].Value.ToString();
            NIS.Texts = DataTable.Rows[e.RowIndex].Cells[1].Value.ToString();
            NamaSiswa.Texts = DataTable.Rows[e.RowIndex].Cells[2].Value.ToString();
            IdKelas.Text = DataTable.Rows[e.RowIndex].Cells[3].Value.ToString();
            Alamat.Texts = DataTable.Rows[e.RowIndex].Cells[4].Value.ToString();
            NoTelepon.Texts = DataTable.Rows[e.RowIndex].Cells[5].Value.ToString();
            IdSPP.Text = DataTable.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void CariNISN_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable.DataSource = kons.ShowData("SELECT * FROM tb_siswa WHERE nisn LIKE '%' '" + CariNISN.Text + "'");
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

        private void TblKelas_Click(object sender, EventArgs e)
        {
            TabelKelas form1 = new TabelKelas();
            form1.Show();
        }

        private void TblSPP_Click(object sender, EventArgs e)
        {
            TabellSPP form1 = new TabellSPP();
            form1.Show();
        }

        private void EksporExcel(DataGridView dataGrid, string filename)
        {
            string Output = "";
            string Headers = "";

            //ekspor judul file
            for (int j = 0; j < dataGrid.Columns.Count; j++)
            {
                Headers = Headers.ToString() + Convert.ToString(dataGrid.Columns[j].HeaderText) + "\t";
            }
            Output += Headers + "\r\n";

            //ekspor data
            for (int i = 0; i < dataGrid.RowCount - 1; i++)
            {
                string Line = "";
                for (int j = 0; j < dataGrid.Rows[i].Cells.Count; j++)
                {
                    Line = Line.ToString() + Convert.ToString(dataGrid.Rows[i].Cells[j].Value) + "\t";
                }
                Output += Line + "\r\n";
            }
            Encoding encoding = Encoding.GetEncoding(1254);
            byte[] outputs = encoding.GetBytes(Output);
            FileStream file = new FileStream(filename, FileMode.Create);
            BinaryWriter binary = new BinaryWriter(file);
            binary.Write(outputs, 0, outputs.Length);
            binary.Flush();
            binary.Close();
            file.Close();
        }
        private void Ekspor_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel Documents (*.xls)|*.xls";
            save.FileName = "Data Siswa.xls";

            if (save.ShowDialog() == DialogResult.OK)
            {
                EksporExcel(DataTable, save.FileName);
            }
        }
    }
}
