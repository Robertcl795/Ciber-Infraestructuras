using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Validador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Regex validatePassword = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{5,}$");
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;
            if (String.IsNullOrEmpty(textBox1.Text)) 
            { 
                MessageBox.Show("La contraseña no puede estar vacía", "Error", buttons);
            }
            else if (!validatePassword.IsMatch(textBox1.Text)) 
            {
                MessageBox.Show("Contraseña no válida", "Error", buttons);
                textBox1.Text = String.Empty;
            } else 
            {
                result = MessageBox.Show("Contraseña validada", "Éxito", buttons);
                if (result == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }
    }
}
