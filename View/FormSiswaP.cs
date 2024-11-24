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
    public partial class FormSiswaP : Form
    {
        KoneksiSiswa kons = new KoneksiSiswa();
        Model_Siswa siswa = new Model_Siswa();

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

        public FormSiswaP()
        {
            InitializeComponent();
            PnlTop.Move_Form(Handle);
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
                    string idcboxe = myReader["nisn"].ToString();
                    CariNISN.Items.Add(idcboxe);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Kembali_Click(object sender, EventArgs e)
        {
            MenuPetugas form = new MenuPetugas();
            form.Show();
            this.Hide();
        }

        private void FormSiswa_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            CariNISN.SelectedIndex = -1;
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
