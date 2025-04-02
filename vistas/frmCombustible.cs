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
    public partial class frmCombustible : Form
    {
        //objetos
        empleadosControlador empleadosControlador = new empleadosControlador();
        camionesControlador camionesControlador = new camionesControlador();
        CombustibleControlador CombustibleControlador = new CombustibleControlador();
        cambiarIDaNombreControlador cambiarIDaNombreControlador = new cambiarIDaNombreControlador();
        //tablas
        DataTable dtRegistro = new DataTable();
        DataTable dtEmpleados = new DataTable();
        DataTable dtCamiones = new DataTable();
        // variables utilizadas para almacenar informacion de los camiones y los choferes
        Int64 IDChofer = -1;
        Int64 IDCamion = -1;
        List<Int64> listaIDCamiones = new List<Int64>();
        List<Int64> listaIDChoferes = new List<Int64>();
        //ID usuario utilizado para el descripcionModificacion
        Int64 MyUsuario;
        //ubicacion del click
        int fila = -1;
        int columna = -1;
        Int64 IDCamionClick = -1;
        Int64 IDCombustible = -1;

        public void recargarTablas()
        {
            dtCamiones.Clear();
            dtRegistro.Clear();
            dgvCamiones.DataSource = null;
            dgvRegistros.DataSource = null;
            dtCamiones = camionesControlador.cargarCamiones();
            dgvCamiones.DataSource = dtCamiones;
            dtRegistro = CombustibleControlador.cargarCombustible();
            dgvRegistros.DataSource = dtRegistro;
        }
        public frmCombustible(Int64 IDMarcaUsuario)
        {
            InitializeComponent();
            //cargar valores defacto
            cbbCriterio.SelectedIndex = 0;
            MyUsuario = IDMarcaUsuario;
            dtEmpleados = empleadosControlador.cargarEmpleados();
            recargarTablas();
            foreach (DataRow dataRow in dtEmpleados.Rows)
            {
                if (dataRow[1].ToString() == "chofer")
                {
                    cbbChofer.Items.Add(dataRow[2]);
                    listaIDChoferes.Add(Convert.ToInt64(dataRow[0].ToString()));
                }
            }
            foreach (DataRow dataRow in dtCamiones.Rows)
            {
                if (dataRow[12].ToString() == "Empresa")
                {
                    cbbCamion.Items.Add(dataRow[2]);
                    listaIDCamiones.Add(Convert.ToInt64(dataRow[0].ToString()));
                }
            }
        }


        public void limpiar()
        {
            cbbCamion.Text = "";
            cbbChofer.Text = "";
            tbxGalones.Text = "";
            tbxGasto.Text = "";
            tbxNotas.Text = "";
        }
        private void frmCombustible_Load(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbbCamion.Text) && !string.IsNullOrEmpty(cbbChofer.Text) && !string.IsNullOrEmpty(tbxGalones.Text) && !string.IsNullOrEmpty(tbxGasto.Text))
            {
                try
                {
                    CombustibleControlador.agregarCombustible(IDChofer, cbbChofer.Text, IDCamion, Convert.ToDouble(tbxGasto.Text), Convert.ToDouble(tbxGalones.Text), dtpFecha.Value, tbxNotas.Text, MyUsuario.ToString(), cbbCamion.Text);
                    MessageBox.Show("Agregado exitosamente!");
                    limpiar();
                    recargarTablas();
                }
                catch (Exception ex)
                { MessageBox.Show("En gastos y galones solo son admisibles valores numericos\n" + ex, "Agregar Registro"); }
            }
            else
            {
                MessageBox.Show("Deber rellenar todos los campos", "Agregar Registro");
            }
        }

        private void cbbChofer_SelectedIndexChanged(object sender, EventArgs e)
        {
            IDChofer = listaIDChoferes[cbbChofer.SelectedIndex];
            //   MessageBox.Show(IDChofer.ToString());
        }

        private void cbbCamion_SelectedIndexChanged(object sender, EventArgs e)
        {
            IDCamion = listaIDCamiones[cbbCamion.SelectedIndex];
            //MessageBox.Show(IDCamion.ToString());
        }

        private void dgvCamiones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            columna = e.ColumnIndex;
            if (fila >= 0 && columna >= 0)
            {
                IDCamionClick = Convert.ToInt64(dgvCamiones.Rows[fila].Cells[0].Value.ToString());
                dtRegistro.Clear();
                dgvRegistros.DataSource = null;
                dtRegistro = CombustibleControlador.buscarCombustible(IDCamionClick.ToString(), "IDCamion");
                dgvRegistros.DataSource = dtRegistro;
                fila = -1;
                columna = -1;
            }

        }

        private void tbxBuscador_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxBuscador.Text) && !string.IsNullOrEmpty(cbbCriterio.Text))
            {
                dtCamiones.Clear();
                dgvCamiones.DataSource = null;
                dtCamiones = camionesControlador.buscarCamiones(tbxBuscador.Text, cbbCriterio.Text);
                dgvCamiones.DataSource = dtCamiones;
            }

            else
            {
                dtCamiones = camionesControlador.cargarCamiones();
                dgvCamiones.DataSource = null;
                dgvCamiones.DataSource = dtCamiones;
            }

        }

        private void dgvRegistros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            columna = e.ColumnIndex;
            if (fila >= 0 && columna >= 0)
            {
                try
                {
                    cbbCamion.Text = dgvRegistros.Rows[fila].Cells[10].Value.ToString();
                    cbbChofer.Text = dgvRegistros.Rows[fila].Cells[2].Value.ToString();
                    tbxGalones.Text = dgvRegistros.Rows[fila].Cells[4].Value.ToString();
                    tbxGasto.Text = dgvRegistros.Rows[fila].Cells[3].Value.ToString();
                    IDCombustible= Convert.ToInt64(dgvRegistros.Rows[fila].Cells[0].Value.ToString());
                    //MessageBox.Show(IDCombustible.ToString());
                    if (!string.IsNullOrEmpty(dgvRegistros.Rows[fila].Cells[7].Value.ToString()))
                    {
                        tbxNotas.Text = dgvRegistros.Rows[fila].Cells[7].Value.ToString();
                    }
                    fila = -1;
                    columna = -1;
                }
                catch (Exception ex)
                { 
                
                }
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (IDCombustible > 0)
            {
                MessageBox.Show(CombustibleControlador.eliminarCombustible(IDCombustible));
                recargarTablas();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un registro de combustibles para eliminar");
            }
        }
    }
}
