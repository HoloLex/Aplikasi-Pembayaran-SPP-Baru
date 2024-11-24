using App_SPP_New.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_SPP_New.Controller
{
    internal class Control_Bayar
    {
        KoneksiBayar konba = new KoneksiBayar();

        public bool insert(Model_Bayar Bayar)
        {
            Boolean status = false;
            try
            {
                konba.OpenConnection();
                konba.ExecuteQuery("INSERT INTO tb_pembayaran (id_pembayaran, id_petugas, nisn, tgl_bayar, bulan_dibayar, tahun_dibayar, id_spp, jumlah_bayar) VALUES ('" + Bayar.Id_pembayaran + "', '" + Bayar.Id_petugas + "', '" + Bayar.Nisn + "', '" + Bayar.Tgl_bayar + "', '" + Bayar.Bulan_dibayar + "', '" + Bayar.Tahun_dibayar + "', '" + Bayar.Id_spp + "', '" + Bayar.Jumlah_bayar + "')");
                status = true;
                MessageBox.Show("Data Berhasil Ditambahkan!", "Sukses!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                konba.CloseConnection();
            }
            catch(Exception e) 
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }

        public bool update(Model_Bayar Bayar)
        {
            Boolean status = false;
            try
            {
                konba.OpenConnection();
                konba.ExecuteQuery("UPDATE tb_siswa SET id_pembayaran ='" + Bayar.Id_pembayaran + "', id_petugas ='" + Bayar.Id_petugas + "', nisn ='" + Bayar.Nisn + "', tgl_bayar ='" + Bayar.Tgl_bayar + "', bulan_dibayar ='" + Bayar.Bulan_dibayar + "', tahun_dibayar ='" + Bayar.Tahun_dibayar + "', id_spp ='" + Bayar.Id_spp + "', jumlah_bayar ='" + Bayar.Jumlah_bayar + "' WHERE id_pembayaran ='" + Bayar.Id_pembayaran + "'");
                status = true;
                MessageBox.Show("Data Berhasil Diubah!", "Sukses!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                konba.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }

        public bool delete(string id_pembayaran)
        {
            Boolean status = false;
            try
            {
                konba.OpenConnection();
                konba.ExecuteQuery("DELETE from tb_pembayaran WHERE id_pembayaran ='" + id_pembayaran + "'");
                status = true;
                MessageBox.Show("Data Berhasil Dihapus!", "Sukses!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                konba.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }
    }
}
