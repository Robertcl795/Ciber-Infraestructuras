using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_Connector
{
    class SQLConnector
    {
        MySqlConnection connection = new MySqlConnection();
        string test = "server=localhost;port=3306;user id=root; password=Rbrtlc-7313; database=empresa_dummy";

        public MySqlConnection establishConnection(string host, string port, string user, string password, string database)
        {
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            if (host.Length == 0 || port.Length == 0 || user.Length == 0 || password.Length == 0 || database.Length == 0)
            {
                MessageBox.Show("Datos inválidos", "Error", buttons);
            }
            else
            {
                string connectionString = "server=" + host + ";port=" + port + ";user id=" + user + ";password=" + password + ";database=" + database;
                try
                {
                    System.Console.WriteLine(connectionString);
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    MessageBox.Show("Conexión establecida");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo establecer conexión: " + ex.ToString(), "Error", buttons);
                }
            }
            return connection;
        }
    }
}
