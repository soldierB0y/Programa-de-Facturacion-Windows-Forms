using Microsoft.Extensions.DependencyInjection;
using programaFacturacion.controlador;
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
    public partial class frmConduces : Form
    {

        //todas las variables

        DataTable dtFacturas= new DataTable();
        facturasControlador facturasControlador=new facturasControlador();


        public void cargarFacturas()
        {
            dtFacturas.Clear();
            dtFacturas= facturasControlador.cargarFacturas();
            dtFacturas.Columns.Remove("IDEmpleado");
            dtFacturas.Columns.Remove("NCF");
            dtFacturas.Columns.Remove("fechaCreacion");
            dtFacturas.Columns.Remove("fechaModificacion");
            dtFacturas.Columns.Remove("subtotal");
            dtFacturas.Columns.Remove("itbis");
            dtFacturas.Columns.Remove("transporte");
            dtFacturas.Columns.Remove("descuento");
            dtFacturas.Columns.Remove("total");
            dtFacturas.Columns.Remove("pagado");
            dtFacturas.Columns.Remove("guardado");
            dtFacturas.Columns.Remove("abono");
            dtFacturas.Columns.Remove("MetodoPago");
            dtFacturas.Columns.Remove("descripcionModificacion");
            dgvFacturas.DataSource = null;
            dgvFacturas.DataSource = dtFacturas;

        }
        public frmConduces(Int64 IDMarcaUsuario)
        {
            InitializeComponent();
            //cargamos las facturas
            cargarFacturas();
        }

        private void frmConduces_Load(object sender, EventArgs e)
        {

        }
    }
}
