using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace BaseDeDatos.Modelos
{
    public class ConnectionBD
    {
        public MySqlConnection connManager;
        string server = "127.0.0.1;";
        string database = "";
        string user = "root";
        string password = "root";

        public MySqlConnection DataSource()
        {
            connManager = new MySqlConnection($"sever = {server} database ={database}" + $"Uid ={user}" + $"password={password}");
            return connManager;
        }

        public void ConnectOpened()
        {
            connManager.Open();
        }
        public void ConnectClosed()
        {
            connManager.Close();
        }
        public bool ExceuteQuery(string sql)
        {
            bool result = false;
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, DataSource());
                ConnectOpened();
            }
            catch(Exception w)
            {
                Console.WriteLine("Hay un error" + w.Message);
                ConnectClosed();
            }
            finally
            {
                ConnectClosed();
            }
            return result;
        }

    }
}
