using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SQL_Connector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string Host = hostnameText.Text;
            string Port = portText.Text;
            string User = userText.Text;
            string Password = passwordText.Text;
            string Database = databaseNameText.Text;
            SQLConnector connection = new SQLConnector();
            connection.establishConnection(Host, Port, User, Password, Database);
        }
    }
}
