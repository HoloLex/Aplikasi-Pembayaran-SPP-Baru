using App_SPP_New.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_SPP_New.Controller
{
    internal class Control_Petugas
    {
        KoneksiPetugas konp = new KoneksiPetugas();

        public bool insert(Model_Petugas Petugas)
        {
            Boolean status = false;
            try
            {
                konp.OpenConnection();
                konp.ExecuteQuery("INSERT INTO tb_petugas (username, password, nama_petugas, level) VALUES ('" + Petugas.Username + "', '" + Petugas.Password + "', '" + Petugas.Nama_petugas + "', '" + Petugas.Level + "')");
                status = true;
                MessageBox.Show("Data Berhasil Ditambahkan!", "Sukses!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                konp.CloseConnection();
            }
            catch(Exception e) 
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }

        public bool update(Model_Petugas Petugas, string id)
        {
            Boolean status = false;
            try
            {
                konp.OpenConnection();
                konp.ExecuteQuery("UPDATE tb_petugas SET username ='" + Petugas.Username + "', password ='" + Petugas.Password + "', nama_petugas ='" + Petugas.Nama_petugas + "', level ='" + Petugas.Level + "' WHERE id_petugas ='" + id + "'");
                status = true;
                MessageBox.Show("Data Berhasil Diubah!", "Sukses!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                konp.CloseConnection();
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
                konp.OpenConnection();
                konp.ExecuteQuery("DELETE from tb_petugas WHERE id_petugas ='" + id + "'");
                status = true;
                MessageBox.Show("Data Berhasil Dihapus!", "Sukses!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                konp.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }
    }
}
