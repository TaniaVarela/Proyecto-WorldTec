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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormProductos = new FormProductos();
            FormProductos.MdiParent = this;
            FormProductos.Show();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login();

        }

        private void login()
        {
            var FormLogin = new FormLogin();
            FormLogin.ShowDialog();
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var FormClientes = new FormClientes();
            FormClientes.MdiParent = this;
            FormClientes.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormVentas = new FormVentas();
            FormVentas.MdiParent = this;
            FormVentas.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            login();
        }

        private void reporteDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormReporteVentas = new FormReporteVentas();
            FormReporteVentas.MdiParent = this;
            FormReporteVentas.Show();
        }

        private void reporteDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormReporteCliente = new FormReporteCliente();
            FormReporteCliente.MdiParent = this;
            FormReporteCliente.Show();
        }

        private void reporteDeGarantiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormReporteGarantia = new FormReporteGarantia();
            FormReporteGarantia.MdiParent = this;
            FormReporteGarantia.Show();
        }
    }
}
