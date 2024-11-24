using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_SPP_New
{
    internal class Connection
    {
        string ConnectionString = "Server=localhost;Database=db_spp;Uid=root;Pwd=;";
        MySqlConnection con;

        public void OpenConnection()
        {
            con = new MySqlConnection(ConnectionString);
            con.Open();
        }
        public void CloseConnection()
        {
            con.Close();
        }
        public MySqlDataReader reader(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
    }
}
