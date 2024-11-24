using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_SPP_New.Controller
{
    internal class KoneksiPetugas
    {
        string connectionstring = "Server=localhost;Database=db_spp;Uid=root;Pwd=;";
        MySqlConnection konp;

        public void OpenConnection()
        {
            konp = new MySqlConnection(connectionstring);
            konp.Open();
        }

        public void CloseConnection()
        {
            konp.Close();
        }

        public void ExecuteQuery(string query)
        {
            MySqlCommand commmand = new MySqlCommand(query, konp);
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
