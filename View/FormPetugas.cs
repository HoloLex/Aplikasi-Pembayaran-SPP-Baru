using App_SPP_New.Controller;
using App_SPP_New.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_SPP_New
{
    public partial class FormPetugas : Form
    {
        KoneksiPetugas konp = new KoneksiPetugas();
        Model_Petugas petugas = new Model_Petugas();
        string id;

        public void Tampil()
        {
            //query
            DataTable.DataSource = konp.ShowData("SELECT * FROM tb_petugas");

            //tablee
            DataTable.Columns[0].HeaderText = "Id Petugas";
            DataTable.Columns[1].HeaderText = "Username";
            DataTable.Columns[2].HeaderText = "Password";
            DataTable.Columns[3].HeaderText = "Nama Petugas";
            DataTable.Columns[4].HeaderText = "Level";

        }
        public FormPetugas()
        {
            InitializeComponent();
            PnlTop.Move_Form(Handle);
        }

        private void Simpan_Click(object sender, EventArgs e)
        {
            if (User.Texts == "" || NamaPetugas.Texts == "" || Pass.Texts == "" || Lvl.SelectedIndex == -1)
            {
                MessageBox.Show("Semua Data/Salah Satu Data Tidak Boleh Kosong!", "kosong....", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Control_Petugas pe = new Control_Petugas();
                petugas.Username = User.Texts;
                petugas.Nama_petugas = NamaPetugas.Texts;
                petugas.Password = Pass.Texts;
                petugas.Level= Lvl.Text;

                pe.insert(petugas);
                User.Texts = "";
                NamaPetugas.Texts = "";
                Pass.Texts = "";
                Lvl.SelectedIndex = -1;

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
            if (User.Texts == "" || NamaPetugas.Texts == "" || Pass.Texts == "" || Lvl.SelectedIndex == -1)
            {
                MessageBox.Show("Semua Data/Salah Satu Data Tidak Boleh Kosong!", "kosong....", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Control_Petugas pe = new Control_Petugas();
                petugas.Username = User.Texts;
                petugas.Password = Pass.Texts;
                petugas.Nama_petugas = NamaPetugas.Texts;
                petugas.Level = Lvl.Text;

                pe.update(petugas, id);
                User.Texts = "";
                Pass.Texts = "";
                NamaPetugas.Texts = "";
                Lvl.SelectedIndex = -1;

                Tampil();

            }
        }

        private void Hapus_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show("Yakin hapus data ini?", "Perhatian!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pesan == DialogResult.Yes)
            {
                Control_Petugas pe = new Control_Petugas();
                pe.delete(id);
                User.Texts = "";
                Pass.Texts = "";
                NamaPetugas.Texts = "";
                Lvl.SelectedIndex = -1;
                Tampil();



            }
        }

        private void FormUser_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        private void DataTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = DataTable.Rows[e.RowIndex].Cells[0].Value.ToString();
            User.Texts = DataTable.Rows[e.RowIndex].Cells[1].Value.ToString();
            Pass.Texts = DataTable.Rows[e.RowIndex].Cells[2].Value.ToString();
            NamaPetugas.Texts = DataTable.Rows[e.RowIndex].Cells[3].Value.ToString();
            Lvl.Text = DataTable.Rows[e.RowIndex].Cells[4].Value.ToString();
        }


        private void Reset_Click(object sender, EventArgs e)
        {
            CariLevel.SelectedIndex = -1;
        }

        private void CariLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable.DataSource = konp.ShowData("SELECT * FROM tb_petugas WHERE level LIKE '%' '" + CariLevel.Text + "'");
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

        private void label2_Click(object sender, EventArgs e)
        {

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
            save.FileName = "Data User Atau Petugas.xls";

            if (save.ShowDialog() == DialogResult.OK)
            {
                EksporExcel(DataTable, save.FileName);
            }
        }
    }
}
