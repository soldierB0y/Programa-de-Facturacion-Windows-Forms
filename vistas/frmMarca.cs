using programaFacturacion.controlador;
using System.Data;

namespace programaFacturacion.vistas
{
    public partial class frmMarca : Form
    {
        DataTable dtMarcas = new DataTable();
        marcasControlador marcasControlador = new marcasControlador();
        public int fila;
        public int columna;
        public Int64 IDMarca = -1;
        Int64 MyUsuario;
        public void limpiar()
        {
            tbxNombre.Text = "";
            tbxDescripcion.Text = "";
            tbxOtrosDatos.Text = "";
        }
        public void cargarMarcas()
        {
            dtMarcas.Clear();
            dgvMarcas.DataSource = null;
            dtMarcas = marcasControlador.cargarMarcas();
            dgvMarcas.DataSource = dtMarcas;
        }
        public void buscarMarca()
        {
            dtMarcas.Clear();
            dgvMarcas.DataSource = null;
            dtMarcas = marcasControlador.buscarMarcas(tbxBuscador.Text, "nombreMarca");
            dgvMarcas.DataSource = dtMarcas;

        }
        public frmMarca(Int64 IDMarcaUsuario)
        {
            InitializeComponent();
            MyUsuario = IDMarcaUsuario;
            cargarMarcas();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {

        }

        private void tbxBuscador_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxBuscador.Text))
            {
                cargarMarcas();
            }
            else
            {
                buscarMarca();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            List<string> marcas = marcasControlador.cargarNombreMarcas();
            //tenemos que recorrer los nombres de las marcas para aseguranos que el nombre que tenemos en tbxNombre no sea igual a alguna marca ya registrada
            bool yaExisteMarca = false;
            if (marcas.Count > 0)
            {
                for (int i = 0; i < marcas.Count; i++)
                {
                    if (marcas[i].ToString() == tbxNombre.Text)
                    {
                        yaExisteMarca = true;
                        break;
                    }
                }
            }
            if (yaExisteMarca == false)
            {
                try
                {
                    if (!string.IsNullOrEmpty(tbxNombre.Text))
                    {
                        marcasControlador.agregarMarcas(tbxNombre.Text, tbxDescripcion.Text, tbxOtrosDatos.Text, MyUsuario.ToString());
                        MessageBox.Show("Agregado exitosamente");
                        limpiar();
                        cargarMarcas();
                    }
                    else
                    {
                        MessageBox.Show("El campo nombre no puede estar vacio");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error al agregar Marca verifique los campos ingresados e intentelo nuevamente \n" + ex);
                }
            }
            else
            {
                MessageBox.Show("Ya existe una Marca registrada con el nombre provisto");
            }
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            limpiar();
        }

        private void dgvMarcas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            columna = e.ColumnIndex;
            try
            {
                if (fila >= 0 && columna >= 0)
                {
                    limpiar();
                    IDMarca = Convert.ToInt64(dgvMarcas.Rows[fila].Cells[0].Value.ToString());
                    tbxNombre.Text = dgvMarcas.Rows[fila].Cells[1].Value.ToString();
                    if (!string.IsNullOrEmpty(dgvMarcas.Rows[fila].Cells[2].Value.ToString()))
                    {
                        tbxDescripcion.Text = dgvMarcas.Rows[fila].Cells[2].Value.ToString();
                    }
                    if (!string.IsNullOrEmpty(dgvMarcas.Rows[fila].Cells[3].Value.ToString()))
                    {
                        tbxOtrosDatos.Text = dgvMarcas.Rows[fila].Cells[3].Value.ToString();
                    }
                }
            }
            catch
            {
                IDMarca = -1;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (IDMarca >= 0)
            {
                marcasControlador.eliminarMarca(IDMarca);
                limpiar();
                cargarMarcas();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una Marca a eliminar");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (IDMarca >= 0)
            {
                marcasControlador.modificarMarca(IDMarca, tbxNombre.Text, tbxDescripcion.Text, tbxOtrosDatos.Text, MyUsuario.ToString());
                limpiar();
                cargarMarcas();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una Marca a modificar");
            }
        }
    }
}
