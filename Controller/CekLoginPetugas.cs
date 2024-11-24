using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_SPP_New
{
    internal class CekLoginPetugas
    {
        Connection connection = new Connection();

        public bool cek_login(string username, string password)
        {
            try
            {
                connection.OpenConnection();
                MySqlDataReader reader = connection.reader("SELECT * FROM tb_petugas WHERE username='" + username + "' AND password='" + password + "' AND level='petugas'");
                if (reader.Read())
                {
                    connection.CloseConnection();
                    return true;
                }
                else
                {
                    connection.CloseConnection();
                    return false;
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Error, Gagal!");
            }
            return false;
        }
    }
}
