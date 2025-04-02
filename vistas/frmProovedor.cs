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
    public partial class frmProovedor : Form
    {
        public int fila = -1;
        public int columna = -1;
        Int64 IDProovedor = -1;
        Int64 MyUsuario;
        DataTable dtProovedor = new DataTable();
        proovedorControlador proovedorControlador = new proovedorControlador();
        public void cargarProovedor()
        {
            dtProovedor.Clear();
            dgvProovedor.DataSource = null;
            dtProovedor = proovedorControlador.cargarProovedor();
            dgvProovedor.DataSource = dtProovedor;
        }
        public frmProovedor(Int64 IDMarcaUsuario)
        {
            InitializeComponent();
            cargarProovedor();
            MyUsuario = IDMarcaUsuario;
            cbxCriterio.Items.Clear();
            cbxCriterio.Items.Add("nombreProovedor");
            cbxCriterio.Items.Add("cedulaRNC");
            cbxCriterio.Items.Add("email");
            cbxCriterio.Items.Add("empresa");
        }
        public void limpiar()
        {
            IDProovedor = -1;
            tbxNombre.Text = "";
            tbxTelefono.Text = "";
            tbxCedulaRNC.Text = "";
            tbxCorreo.Text = "";
            tbxEmpresa.Text = "";
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void frmProovedor_Load(object sender, EventArgs e)
        {

        }

        private void dgvProovedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            columna = e.ColumnIndex;
            if (fila >= 0 && columna >= 0)
            {
                IDProovedor = Convert.ToInt64(dgvProovedor.Rows[fila].Cells[0].Value.ToString());
                tbxNombre.Text = dgvProovedor.Rows[fila].Cells[1].Value.ToString();
                if (!string.IsNullOrEmpty(dgvProovedor.Rows[fila].Cells[2].Value.ToString()))
                {
                    tbxTelefono.Text = dgvProovedor.Rows[fila].Cells[2].Value.ToString();
                }
                else
                {
                    tbxTelefono.Text = "";
                }
                if (!string.IsNullOrEmpty(dgvProovedor.Rows[fila].Cells[3].Value.ToString()))
                {
                    tbxCedulaRNC.Text = dgvProovedor.Rows[fila].Cells[3].Value.ToString();
                }
                else
                {
                    tbxCedulaRNC.Text = "";
                }
                if (!string.IsNullOrEmpty(dgvProovedor.Rows[fila].Cells[4].Value.ToString()))
                {
                    tbxCorreo.Text = dgvProovedor.Rows[fila].Cells[4].Value.ToString();

                }
                else
                {
                    tbxCorreo.Text = "";
                }
                if (!string.IsNullOrEmpty(dgvProovedor.Rows[fila].Cells[8].Value.ToString()))
                {
                    tbxEmpresa.Text = dgvProovedor.Rows[fila].Cells[8].Value.ToString();
                }
                else
                {
                    tbxEmpresa.Text = "";
                }
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxNombre.Text))
            {
                proovedorControlador.agregarProovedor(tbxNombre.Text, tbxTelefono.Text, tbxCedulaRNC.Text, tbxCorreo.Text, tbxEmpresa.Text, MyUsuario.ToString());
                limpiar();
                cargarProovedor();
                MessageBox.Show("Agregado exitosamente!!!");
            }
            else
            {
                MessageBox.Show("Asegurese de ingresar un nombre para el proovedor");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (IDProovedor >= 0)
            {
                proovedorControlador.eliminarProovedor(IDProovedor);
                limpiar();
                cargarProovedor();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (IDProovedor >= 0)
            {
                proovedorControlador.modificarProovedor(IDProovedor, tbxNombre.Text, tbxTelefono.Text, tbxCedulaRNC.Text, tbxCorreo.Text, tbxEmpresa.Text,MyUsuario.ToString());
                limpiar();
                cargarProovedor();
            }
            else
            {
                MessageBox.Show("Asegurese de haber seleccionado un proovedor a modificar");
            }
        }

        private void cbxCriterio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxBuscador.Text))
            {
                dtProovedor.Clear();
                dtProovedor = proovedorControlador.buscarProovedor(tbxBuscador.Text, cbxCriterio.Text);
                dgvProovedor.DataSource = null;
                dgvProovedor.DataSource = dtProovedor;
            }
            else
            {
                cargarProovedor();
            }
        }

        private void tbxBuscador_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxBuscador.Text))
            {
                dtProovedor.Clear();
                dtProovedor = proovedorControlador.buscarProovedor(tbxBuscador.Text, cbxCriterio.Text);
                dgvProovedor.DataSource = null;
                dgvProovedor.DataSource = dtProovedor;
            }
            else
            {
                cargarProovedor();
            }
        }
    }
}
