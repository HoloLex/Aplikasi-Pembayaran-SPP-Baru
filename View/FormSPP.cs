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
    public partial class FormSPP : Form
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

        public FormSPP()
        {
            InitializeComponent();
            PnlTop.Move_Form(Handle);
        }

        private void Simpan_Click(object sender, EventArgs e)
        {
            if (TahunTagihan.SelectedIndex == -1 || HargaTagihan.Texts == "")
            {
                MessageBox.Show("Semua Data/Salah Satu Data Tidak Boleh Kosong!", "kosong....", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Control_SPP sp = new Control_SPP();
                spp.Tahun = TahunTagihan.Text;
                spp.Nominal = HargaTagihan.Texts;

                sp.insert(spp);
                TahunTagihan.SelectedIndex = -1;
                HargaTagihan.Texts = "";

                Tampil();

            }
        }

        private void DataTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = DataTable.Rows[e.RowIndex].Cells[0].Value.ToString();
            TahunTagihan.Text = DataTable.Rows[e.RowIndex].Cells[1].Value.ToString();
            HargaTagihan.Texts = DataTable.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void Ubah_Click(object sender, EventArgs e)
        {
            if (TahunTagihan.SelectedIndex == -1 || HargaTagihan.Texts == "")
            {
                MessageBox.Show("Semua Data/Salah Satu Data Tidak Boleh Kosong!", "kosong....", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Control_SPP sp = new Control_SPP();
                spp.Tahun = TahunTagihan.Text;
                spp.Nominal = HargaTagihan.Texts;

                sp.update(spp, id);
                TahunTagihan.SelectedIndex = -1;
                HargaTagihan.Texts = "";

                Tampil();

            }

        }

        private void Hapus_Click(object sender, EventArgs e)
        {
            DialogResult pesan = MessageBox.Show("Yakin hapus data ini?", "Perhatian!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (pesan == DialogResult.Yes)
            {
                Control_SPP sp = new Control_SPP();
                sp.delete(id);

                TahunTagihan.SelectedIndex = -1;
                HargaTagihan.Texts = "";
                Tampil();
            }
        }

        private void Kembali_Click(object sender, EventArgs e)
        {
            MenuAdmin form = new MenuAdmin();
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
            Close();
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
            save.FileName = "Data Tahun SPP.xls";

            if (save.ShowDialog() == DialogResult.OK)
            {
                EksporExcel(DataTable, save.FileName);
            }
        }
    }
}
