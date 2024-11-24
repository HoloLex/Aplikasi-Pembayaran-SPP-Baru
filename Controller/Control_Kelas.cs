using App_SPP_New.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_SPP_New.Controller
{
    internal class Control_Kelas
    {
        KoneksiKelas konkel = new KoneksiKelas();

        public bool insert(Model_Kelas Kelas)
        {
            Boolean status = false;
            try
            {
                konkel.OpenConnection();
                konkel.ExecuteQuery("INSERT INTO tb_kelas (nama_kelas, kompetensi_keahlian) VALUES ('" + Kelas.Nama_kelas + "', '" + Kelas.Kompetensi_keahlian + "')");
                status = true;
                MessageBox.Show("Data Berhasil Ditambahkan!", "Sukses!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                konkel.CloseConnection();
            }
            catch(Exception e) 
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }

        public bool update(Model_Kelas Kelas, string id)
        {
            Boolean status = false;
            try
            {
                konkel.OpenConnection();
                konkel.ExecuteQuery("UPDATE tb_kelas SET nama_kelas ='" + Kelas.Nama_kelas + "', kompetensi_keahlian ='" + Kelas.Kompetensi_keahlian + "' WHERE id_kelas ='" + id + "'");
                status = true;
                MessageBox.Show("Data Berhasil Diubah!", "Sukses!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                konkel.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }

        public bool delete(string id)
        {
            Boolean status = false;
            try
            {
                konkel.OpenConnection();
                konkel.ExecuteQuery("DELETE from tb_kelas WHERE id_kelas ='" + id + "'");
                status = true;
                MessageBox.Show("Data Berhasil Dihapus!", "Sukses!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                konkel.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }
    }
}
