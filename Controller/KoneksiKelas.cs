using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_SPP_New
{
    internal class KoneksiKelas
    {
        string connectkel = "Server=localhost;Database=db_spp;Uid=root;Pwd=;";
        MySqlConnection konkel;

        public void OpenConnection() 
        {
            konkel = new MySqlConnection(connectkel);
            konkel.Open();
        }

        public void CloseConnection() 
        {
            konkel.Close();
        }

        public void ExecuteQuery(string query)
        {
            MySqlCommand commmand = new MySqlCommand(query, konkel);
            commmand.ExecuteNonQuery();
        }

        public object ShowData(String query)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connectkel);
            DataSet data = new DataSet();
            
            adapter.Fill(data);
            object bebas = data.Tables[0];
            return bebas;
        }

    }
}
