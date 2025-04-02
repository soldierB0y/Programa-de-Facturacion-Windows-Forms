using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace programaFacturacion.vistas
{
    public partial class frmPrincipal : Form
    {
        Int64 IDUsuario;
        public frmPrincipal(Int64 IDMarcaUsuario)
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            IDUsuario = IDMarcaUsuario;


        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a = Application.OpenForms.OfType<frmClientes>().Count();// con esto podemos contar la cantidad de formularios de este tipo en la aplicacion
            if (a == 0)
            {
                frmClientes frmClientes = new frmClientes(IDUsuario);
                frmClientes.MdiParent = this;
                frmClientes.Show();
                frmClientes.Visible = true;
                frmClientes.WindowState = FormWindowState.Maximized;
            }
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a = Application.OpenForms.OfType<frmArticulos>().Count();
            if (a == 0)
            {
                frmArticulos frmArticulos = new frmArticulos(IDUsuario);
                frmArticulos.MdiParent = this;
                frmArticulos.Show();
                frmArticulos.Visible = true;
                frmArticulos.WindowState = FormWindowState.Maximized;
            }
        }

        private void cotizacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a = Application.OpenForms.OfType<frmClientesCotizaciones>().Count();
            if (a == 0)
            {
                frmClientesCotizaciones frmClientesCotizaciones = new frmClientesCotizaciones(IDUsuario);
                frmClientesCotizaciones.MdiParent = this;
                frmClientesCotizaciones.Show();
                frmClientesCotizaciones.Visible = true;
                frmClientesCotizaciones.WindowState = FormWindowState.Maximized;
            }
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a = Application.OpenForms.OfType<frmEmpleados>().Count();
            if (a == 0)
            {
                frmEmpleados frmEmpleados = new frmEmpleados(IDUsuario);
                frmEmpleados.MdiParent = this;
                frmEmpleados.Show();
                frmEmpleados.Visible = true;
                frmEmpleados.WindowState = FormWindowState.Maximized;
            }
        }

        private void camionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a = Application.OpenForms.OfType<frmCamiones>().Count();
            if (a == 0)
            {
                frmCamiones frmCamiones = new frmCamiones(IDUsuario);
                frmCamiones.MdiParent = this;
                frmCamiones.Show();
                frmCamiones.Visible = true;
                frmCamiones.WindowState = FormWindowState.Maximized;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void proovedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a = Application.OpenForms.OfType<frmProovedor>().Count();
            if (a == 0)
            {
                frmProovedor frmProovedor = new frmProovedor(IDUsuario);
                frmProovedor.MdiParent = this;
                frmProovedor.Show();
                frmProovedor.Visible = true;

            }
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a = Application.OpenForms.OfType<frmUsuarios>().Count();
            if (a == 0)
            {
                frmUsuarios frmUsuarios = new frmUsuarios(IDUsuario);
                frmUsuarios.MdiParent = this;
                frmUsuarios.Show();
                frmUsuarios.Visible = true;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int a = Application.OpenForms.OfType<frmConduces>().Count();
            if (a == 0)
            {
                frmConduces frmConduces = new frmConduces(IDUsuario);
                frmConduces.MdiParent = this;
                frmConduces.Show();
                frmConduces.Visible = true;
                frmConduces.WindowState = FormWindowState.Normal;
            }
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a = Application.OpenForms.OfType<frmMarca>().Count();
            if (a == 0)
            {
                frmMarca frmMarca = new frmMarca(IDUsuario);
                frmMarca.MdiParent = this;
                frmMarca.Show();
                frmMarca.Visible = true;
                frmMarca.WindowState = FormWindowState.Normal;
            }
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int a = Application.OpenForms.OfType<frmClientesFacturacion>().Count();
            if (a == 0)
            {
                frmClientesFacturacion frmClientesFacturas = new frmClientesFacturacion(IDUsuario);
                frmClientesFacturas.MdiParent = this;
                frmClientesFacturas.Show();
                frmClientesFacturas.Visible = true;
                frmClientesFacturas.WindowState = FormWindowState.Maximized;
            }
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_MouseHover(object sender, EventArgs e)
        {

        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clientesToolStripMenuItem_MouseEnter(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            if (item != null)
            {
                // Cambia el color de fondo y texto cuando el ratón entra
                item.BackColor = Color.DarkRed;
                item.ForeColor = Color.White;
            }

        }

        private void clientesToolStripMenuItem_MouseLeave(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            if (item != null)
            {
                // Restaurar el color de fondo y texto al color original cuando el ratón se va
                item.BackColor = Color.Crimson;
                item.ForeColor = Color.White;
            }
        }

        private void toolStripMenuItem1_BackColorChanged(object sender, EventArgs e)
        {
            ToolStripMenuItem item = sender as ToolStripMenuItem;
            if (item.BackColor != Color.Crimson && item.BackColor != Color.DarkRed)
            {
                item.BackColor = Color.DarkRed;
            }
        }
    }
}
