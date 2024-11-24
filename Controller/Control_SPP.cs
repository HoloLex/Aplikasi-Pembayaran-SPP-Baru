using App_SPP_New.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_SPP_New.Controller
{
    internal class Control_SPP
    {
        koneksi kon = new koneksi();

        public bool insert(Model_SPP SPP)
        {
            Boolean status = false;
            try
            {
                kon.OpenConnection();
                kon.ExecuteQuery("INSERT INTO tb_spp (tahun, nominal) VALUES ('" + SPP.Tahun + "', '" + SPP.Nominal + "')");
                status = true;
                MessageBox.Show("Data Berhasil Ditambahkan!", "Sukses!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                kon.CloseConnection();
            }
            catch(Exception e) 
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }

        public bool update(Model_SPP SPP, string id)
        {
            Boolean status = false;
            try
            {
                kon.OpenConnection();
                kon.ExecuteQuery("UPDATE tb_spp SET tahun ='" + SPP.Tahun + "', nominal ='" + SPP.Nominal + "' WHERE id_spp ='" + id + "'");
                status = true;
                MessageBox.Show("Data Berhasil Diubah!", "Sukses!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                kon.CloseConnection();
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
                kon.OpenConnection();
                kon.ExecuteQuery("DELETE from tb_spp WHERE id_spp ='" + id + "'");
                status = true;
                MessageBox.Show("Data Berhasil Dihapus!", "Sukses!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                kon.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }
    }
}
