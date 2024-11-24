using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_SPP_New.Controller
{
    internal class koneksi
    {
        string connectionstring = "Server=localhost;Database=db_spp;Uid=root;Pwd=;";
        MySqlConnection kon;

        public void OpenConnection()
        {
            kon = new MySqlConnection(connectionstring);
            kon.Open();
        }

        public void CloseConnection()
        {
            kon.Close();
        }

        public void ExecuteQuery(string query)
        {
            MySqlCommand commmand = new MySqlCommand(query, kon);
            commmand.ExecuteNonQuery();
        }

        public object ShowData(String query)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connectionstring);
            DataSet data = new DataSet();

            adapter.Fill(data);
            object bebas = data.Tables[0];
            return bebas;
        }
    }
}
