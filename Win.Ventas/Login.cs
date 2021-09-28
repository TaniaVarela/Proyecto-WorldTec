using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.Ventas
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Usuario;
            string Contrasena;

            Usuario = textBox1.Text;
            Contrasena = textBox2.Text;

            if (Usuario == "Tvarela" && Contrasena == "2324")
             
            {
                this.Close();
            }
            else
            { 
                if (Usuario == "YSalgado" && Contrasena == "1516")
                {
                    this.Close();
                }
                else 
                    MessageBox.Show("Usuario o Contraseña Incorrecta");
            }
    }
    }
}


