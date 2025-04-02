using programaFacturacion.controlador;
using System.Data;

namespace programaFacturacion.vistas
{
    public partial class frmUsuarios : Form
    {
        DataTable dtUsuarios = new DataTable();
        usuarioControlador usuarioControlador = new usuarioControlador();
        empleadosControlador empleadosControlador = new empleadosControlador();
        cambiarIDaNombreControlador CIDNC = new cambiarIDaNombreControlador();
        DataTable dtEmpleados = new DataTable();
        int fila = -1;
        int columna = -1;
        Int64 IDUsuario = -1;
        Int64 MyUsuario;
        public void cargarUsuarios()
        {
            dtUsuarios.Clear();
            dgvUsuarios.DataSource = null;
            dtUsuarios = usuarioControlador.cargarUsuarios();
            dgvUsuarios.DataSource = dtUsuarios;
        }
        public void IDEmpleadoaNombreaLista()
        {
            dtEmpleados.Clear();
            dtEmpleados = empleadosControlador.cargarEmpleados();
            cbbEmpleado.Items.Clear();
            foreach (DataRow row in dtEmpleados.Rows)
            {
                if (row[1].ToString() == cbbPuesto.Text)
                {
                    cbbEmpleado.Items.Add(row[2]);
                }
            }
        }
        public Int64 nombreaIDEmpleado(string nombre)
        {

            Int64 result = 0;
            // MessageBox.Show(nombre);
            DataTable dtNombres = new DataTable();
            dtNombres = empleadosControlador.cargarEmpleados();
            foreach (DataRow row in dtNombres.Rows)
            {
                if (row[2].ToString() == nombre)
                {
                    // MessageBox.Show("Tengo el nombre");
                    result = Convert.ToInt64(row[0].ToString());
                    //   MessageBox.Show("su ID es "+result.ToString());

                }
            }
            return result;
        }
        public frmUsuarios(Int64 IDMarcaUsuario)
        {
            InitializeComponent();
            cargarUsuarios();
            MyUsuario = IDMarcaUsuario;
            dtEmpleados = empleadosControlador.cargarEmpleados();
            //cargar valores defacto
            //puesto
            cbbPuesto.Items.Add("administrador");
            cbbPuesto.Items.Add("facturador");
            cbbPuesto.Items.Add("chofer");
            cbbPuesto.SelectedIndex = 0;
            //criterio
            cbbCriterio.Items.Add("IDUsuario");
            cbbCriterio.Items.Add("IDEmpleado");
            cbbCriterio.Items.Add("usuario");
            cbbCriterio.SelectedIndex = 2;
            IDEmpleadoaNombreaLista();

        }

        public void limpiar()
        {
            tbxUsuario.Text = "";
            tbxClave.Text = "";
            cbbEmpleado.Text = "";
            cbbPuesto.SelectedIndex = 0;
            IDUsuario = -1;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            columna = e.RowIndex;
            if (fila >= 0 && columna >= 0 && dgvUsuarios.Rows.Count > 0)
            {
                IDUsuario = Convert.ToInt64(dgvUsuarios.Rows[fila].Cells[0].Value.ToString());
                if (!string.IsNullOrEmpty(dgvUsuarios.Rows[fila].Cells[2].Value.ToString()))
                {
                    tbxUsuario.Text = dgvUsuarios.Rows[fila].Cells[2].Value.ToString();
                }
                if (!string.IsNullOrEmpty(dgvUsuarios.Rows[fila].Cells[3].Value.ToString()))
                {
                    tbxClave.Text = dgvUsuarios.Rows[fila].Cells[3].Value.ToString();
                }
                if (!string.IsNullOrEmpty(dgvUsuarios.Rows[fila].Cells[7].Value.ToString()))
                {
                    cbbPuesto.Text = dgvUsuarios.Rows[fila].Cells[7].Value.ToString();
                }
                if (!string.IsNullOrEmpty(dgvUsuarios.Rows[fila].Cells[1].Value.ToString()))
                {
                    cbbEmpleado.Text = CIDNC.getID("empleados", "nombre", "IDEmpleado", Convert.ToInt64(dgvUsuarios.Rows[fila].Cells[1].Value.ToString()));
                }
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxUsuario.Text) && !string.IsNullOrEmpty(tbxClave.Text) && !string.IsNullOrEmpty(cbbEmpleado.Text))
            {
                if (usuarioControlador.verificarNombreUsuario(tbxUsuario.Text) == false)
                {
                    try
                    {
                        Int64 IDEmpleado = nombreaIDEmpleado(cbbEmpleado.Text);
                        usuarioControlador.agregarUsuarios(tbxUsuario.Text, tbxClave.Text, cbbPuesto.Text, IDEmpleado, MyUsuario.ToString());
                        MessageBox.Show("Agregado Exitosamente");
                        cargarUsuarios();
                        limpiar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Rellene todos los campos \n" + ex);
                    }
                }
                else
                {
                    MessageBox.Show("Ya existe un usuario con el nombre provisto");
                }
            }
            else
            {
                MessageBox.Show("Asegurese de rellenar todos los campos");
            }

        }

        private void cbbPuesto_SelectedIndexChanged(object sender, EventArgs e)
        {
            IDEmpleadoaNombreaLista();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (IDUsuario >= 0)
            {
                usuarioControlador.eliminarUsuario(IDUsuario);
                limpiar();
                cargarUsuarios();
            }
            else
            {
                MessageBox.Show("Asegurese de haber seleccionado un usuario para eliminar");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxUsuario.Text) && !string.IsNullOrEmpty(tbxClave.Text) && !string.IsNullOrEmpty(cbbEmpleado.Text))
            {
                if (usuarioControlador.verificarExistenciaUsuario(IDUsuario) == true)
                {
                    try
                    {
                        Int64 IDEmpleado = nombreaIDEmpleado(cbbEmpleado.Text);
                        usuarioControlador.modificarUsuario(IDUsuario, IDEmpleado, tbxUsuario.Text, tbxClave.Text, MyUsuario.ToString(), cbbPuesto.Text);
                        cargarUsuarios();
                        limpiar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Rellene todos los campos \n" + ex);
                    }
                }
                else
                {
                    MessageBox.Show("Ya existe un usuario con el nombre provisto");
                }
            }
            else
            {
                MessageBox.Show("Asegurese de rellenar todos los campos");
            }

        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void tbxBuscador_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxBuscador.Text) && !string.IsNullOrEmpty(cbbCriterio.Text))
            {
                dtUsuarios.Clear();
                dgvUsuarios.DataSource = null;

                dtUsuarios = usuarioControlador.buscarUsuarios(tbxBuscador.Text, cbbCriterio.Text);
                dgvUsuarios.DataSource = dtUsuarios;
            }
            else
            {
                dtUsuarios.Clear();
                dtUsuarios = usuarioControlador.cargarUsuarios();
                dgvUsuarios.DataSource = null;
                dgvUsuarios.DataSource = dtUsuarios;
            }
        }

        private void cbbCriterio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxBuscador.Text) && !string.IsNullOrEmpty(cbbCriterio.Text))
            {
                dtUsuarios.Clear();
                dgvUsuarios.DataSource = null;

                dtUsuarios = usuarioControlador.buscarUsuarios(tbxBuscador.Text, cbbCriterio.Text);
                dgvUsuarios.DataSource = dtUsuarios;
            }
            else
            {
                dtUsuarios.Clear();
                dtUsuarios = usuarioControlador.cargarUsuarios();
                dgvUsuarios.DataSource = null;
                dgvUsuarios.DataSource = dtUsuarios;
            }

        }
    }
}
