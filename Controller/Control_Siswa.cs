using App_SPP_New.Model;
using App_SPP_New.CustomUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_SPP_New.Controller
{
    internal class Control_Siswa
    {
        KoneksiSiswa kons = new KoneksiSiswa();

        public bool insert(Model_Siswa Siswa)
        {
            Boolean status = false;
            try
            {
                kons.OpenConnection();
                kons.ExecuteQuery("INSERT INTO tb_siswa (nisn, nis, nama, id_kelas, alamat, no_telp, id_spp) VALUES ('" + Siswa.Nisn + "', '" + Siswa.Nis + "', '" + Siswa.Nama + "', '" + Siswa.Id_kelas + "', '" + Siswa.Alamat + "', '" + Siswa.No_telp + "', '" + Siswa.Id_spp + "')");
                status = true;
                MessageBox.Show("Data Berhasil Ditambahkan!", "Sukses!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                kons.CloseConnection();
            }
            catch(Exception e) 
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }

        public bool update(Model_Siswa Siswa)
        {
            Boolean status = false;
            try
            {
                kons.OpenConnection();
                kons.ExecuteQuery("UPDATE tb_siswa SET nisn ='" + Siswa.Nisn + "', nis ='" + Siswa.Nis + "', nama ='" + Siswa.Nama + "', id_kelas ='" + Siswa.Id_kelas + "', alamat ='" + Siswa.Alamat + "', no_telp ='" + Siswa.No_telp + "', id_spp ='" + Siswa.Id_spp + "' WHERE nisn ='" + Siswa.Nisn + "'");
                status = true;
                MessageBox.Show("Data Berhasil Diubah!", "Sukses!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                kons.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }

        public bool delete(Model_Siswa siswa)
        {
            Boolean status = false;
            try
            {
                kons.OpenConnection();
                kons.ExecuteQuery("DELETE from tb_siswa WHERE nisn ='" + siswa.Nisn + "'");
                status = true;
                MessageBox.Show("Data Berhasil Dihapus!", "Sukses!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                kons.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }
    }
}
