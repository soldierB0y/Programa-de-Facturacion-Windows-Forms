using programaFacturacion.controlador;
using System.Data;

namespace programaFacturacion.vistas
{
    public partial class frmCamiones : Form
    {

        public void agregarValoresDefactoCamion()
        {
            cbbMarca.Items.Clear();
            cbbModelo.Items.Clear();
            cbbColor.Items.Clear();
            cbbColor.Items.Add("");
            cbbMarca.Items.Add("");
            cbbModelo.Items.Add("");
            foreach (DataRow row in dtCamiones.Rows)
            {
                if (!string.IsNullOrEmpty(row[1].ToString()))
                {
                    bool existeModelo = false;
                    for (int i = 0; i < cbbModelo.Items.Count; i++)
                    {
                        if (cbbModelo.Items[i].ToString() == row[1].ToString())
                        {
                            existeModelo = true;
                            break;
                        }
                    }
                    if (existeModelo == false)
                    {
                        cbbModelo.Items.Add(row[1].ToString());
                    }
                }

                if (!string.IsNullOrEmpty(row[4].ToString()))
                {
                    bool existeMarca = false;
                    for (int i = 0; i < cbbMarca.Items.Count; i++)
                    {
                        if (cbbMarca.Items[i].ToString() == row[4].ToString())
                        {
                            existeMarca = true;
                            break;
                        }
                    }
                    if (existeMarca == false)
                    {
                        cbbMarca.Items.Add(row[4].ToString());
                    }
                }

                if (!string.IsNullOrEmpty(row[3].ToString()))
                {
                    bool existeColor = false;
                    for (int i = 0; i < cbbColor.Items.Count; i++)
                    {
                        if (cbbColor.Items[i].ToString() == row[3].ToString())
                        {
                            existeColor = true;
                            break;
                        }
                    }
                    if (existeColor == false)
                    {
                        cbbColor.Items.Add(row[3].ToString());
                    }
                }


            }

        }
        public DataTable dtCamiones;
        public int fila;
        public int columna;
        public Int64 IDCamion = -1;
        camionesControlador camionescontrolador = new camionesControlador();
        Int64 MyUsuario;
        Array imagenParaEnviar;
        public frmCamiones(Int64 IDMarcaUsuario)
        {

            InitializeComponent();
            MyUsuario = IDMarcaUsuario;
            dtCamiones = camionescontrolador.cargarCamiones();
            dgvCamiones.DataSource = dtCamiones;
            //asignar valores defactos
            cbbPropietario.SelectedIndex = 0;
            cbbCriterio.Text = "modelo";
            for (int i = 0; i < cbbPropietario.Items.Count; i++)
            {
                cbbBuscador.Items.Add(cbbPropietario.Items[i]);
            }
            agregarValoresDefactoCamion();

        }

        private void frmCamiones_Load(object sender, EventArgs e)
        {

        }
        private void limpiar()
        {
            imagenParaEnviar = null;
            pictureBox1.Image = Resources.empleado.camion;
            cbbCriterio.SelectedIndex = 0;
            tbxBuscador.Text = "";
            cbbModelo.SelectedIndex = 0;
            tbxMatricula.Text = "";
            cbbColor.SelectedIndex = 0;
            cbbMarca.SelectedIndex = 0;
            tbxMetraje.Text = "0";
            cbbPropietario.SelectedIndex = 0;
            cbxActivo.Checked = false;
            IDCamion = -1;
            lbUbicacionArchivo.Text = "ninguno";

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbbMarca.Text) && !string.IsNullOrEmpty(cbbModelo.Text) && !string.IsNullOrEmpty(tbxMatricula.Text) && !string.IsNullOrEmpty(cbbColor.Text) && !string.IsNullOrEmpty(tbxMetraje.Text) && !string.IsNullOrEmpty(dtpFechaAdquisicion.Value.ToString()) && ((cbxActivo.Checked == true) || (cbxActivo.Checked == false)))
            {
                try
                {
                    camionescontrolador.agregarCamiones(cbbModelo.Text, tbxMatricula.Text, cbbColor.Text, cbbMarca.Text, Convert.ToDouble(tbxMetraje.Text), dtpFechaAdquisicion.Value, 0, cbxActivo.Checked, DateTime.Now, DateTime.Now, MyUsuario.ToString(), cbbPropietario.Text,imagenParaEnviar);
                    dtCamiones.Clear();
                    dtCamiones = camionescontrolador.cargarCamiones();
                    dgvCamiones.DataSource = dtCamiones;
                    limpiar();
                    agregarValoresDefactoCamion();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insentar valores no numericos" + ex);
                }
            }
            else
            {
                MessageBox.Show("Debe rellenar todos los campos");
            }
        }

        private void tbxBuscador_TextChanged(object sender, EventArgs e)
        {
            dtCamiones.Clear();
            if (!string.IsNullOrEmpty(tbxBuscador.Text))
            {
                dtCamiones = camionescontrolador.buscarCamiones(tbxBuscador.Text, cbbCriterio.Text);
            }
            else
            {
                dtCamiones = camionescontrolador.cargarCamiones();
            }
            dgvCamiones.DataSource = null;
            dgvCamiones.DataSource = dtCamiones;
        }

        private void cbbCriterio_SelectedIndexChanged(object sender, EventArgs e)
        {

            dtCamiones.Clear();
            if (cbbCriterio.Text != "propietario")
            {
                tbxBuscador.Visible = true;
                cbbBuscador.Visible = false;
                dtCamiones = camionescontrolador.buscarCamiones(tbxBuscador.Text, cbbCriterio.Text);
            }
            else
            {
                tbxBuscador.Visible = false;
                cbbBuscador.Visible = true;
                dtCamiones = camionescontrolador.buscarCamiones(cbbBuscador.Text, cbbCriterio.Text);
            }
            dgvCamiones.DataSource = null;
            dgvCamiones.DataSource = dtCamiones;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void dgvCamiones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            columna = e.ColumnIndex;
            if (fila >= 0 && columna >= 0)
            {
                try
                {
                    IDCamion = Convert.ToInt64(dgvCamiones.Rows[fila].Cells[0].Value.ToString());
                }
                catch { IDCamion = -1; }
                if (!string.IsNullOrEmpty(dgvCamiones.Rows[fila].Cells[4].Value.ToString()))
                {
                    cbbMarca.Text = dgvCamiones.Rows[fila].Cells[4].Value.ToString();
                }
                else
                {
                    cbbMarca.Text = "";
                }
                if (!string.IsNullOrEmpty(dgvCamiones.Rows[fila].Cells[1].Value.ToString()))
                {
                    cbbModelo.Text = dgvCamiones.Rows[fila].Cells[1].Value.ToString();
                }
                else
                {
                    cbbModelo.Text = "";
                }
                if (!string.IsNullOrEmpty(dgvCamiones.Rows[fila].Cells[2].Value.ToString()))
                {
                    tbxMatricula.Text = dgvCamiones.Rows[fila].Cells[2].Value.ToString();
                }
                else
                {
                    tbxMatricula.Text = "";
                }
                if (!string.IsNullOrEmpty(dgvCamiones.Rows[fila].Cells[3].Value.ToString()))
                {
                    cbbColor.Text = dgvCamiones.Rows[fila].Cells[3].Value.ToString();
                }
                else
                {

                    cbbColor.Text = "";
                }
                if (!string.IsNullOrEmpty(dgvCamiones.Rows[fila].Cells[5].Value.ToString()))
                {
                    tbxMetraje.Text = dgvCamiones.Rows[fila].Cells[5].Value.ToString();
                }
                else
                {
                    tbxMetraje.Text = "";
                }
                if (!string.IsNullOrEmpty(dgvCamiones.Rows[fila].Cells[6].Value.ToString()))
                {
                    dtpFechaAdquisicion.Value = Convert.ToDateTime(dgvCamiones.Rows[fila].Cells[6].Value);
                }
                if (!string.IsNullOrEmpty(dgvCamiones.Rows[fila].Cells[12].Value.ToString()))
                {
                    cbbPropietario.Text = dgvCamiones.Rows[fila].Cells[12].Value.ToString();
                }
                else
                {
                    cbbPropietario.SelectedIndex = 0;

                }
                if (!string.IsNullOrEmpty(dgvCamiones.Rows[fila].Cells[8].Value.ToString()))
                {
                    cbxActivo.Checked = Convert.ToBoolean(dgvCamiones.Rows[fila].Cells[8].Value.ToString());
                }


                if (dgvCamiones.Rows[e.RowIndex].Cells[13].Value != DBNull.Value)
                {
                    object objImagenClientes = dgvCamiones.Rows[e.RowIndex].Cells[13].Value;
                    byte[] byteImagenClientes = (byte[])objImagenClientes;
                    using (MemoryStream ms = new MemoryStream(byteImagenClientes))
                    {
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                }
                else { pictureBox1.Image = Resources.empleado.camion; }






            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (IDCamion >= 0)
            {
                camionescontrolador.eliminarCamiones(IDCamion);
                dgvCamiones.DataSource = null;
                dtCamiones.Clear();
                dtCamiones = camionescontrolador.cargarCamiones();
                dgvCamiones.DataSource = dtCamiones;
                limpiar();
                agregarValoresDefactoCamion();
            }
            else
            {
                MessageBox.Show("Asegurese de seleccionar el Camion a eliminar");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (IDCamion >= 0)
            {
                try
                {
                    camionescontrolador.modificarCamiones(IDCamion, cbbModelo.Text, tbxMatricula.Text, cbbColor.Text, cbbMarca.Text, Convert.ToDouble(tbxMetraje.Text), dtpFechaAdquisicion.Value, cbxActivo.Checked, DateTime.Now, MyUsuario.ToString(), cbbPropietario.Text,imagenParaEnviar);
                }
                catch (Exception ex)
                { MessageBox.Show("Error al insertar valores no numericos"); }
                dgvCamiones.DataSource = null;
                dtCamiones.Clear();
                dtCamiones = camionescontrolador.cargarCamiones();
                dgvCamiones.DataSource = dtCamiones;
                limpiar();
                agregarValoresDefactoCamion();
            }
            else
            {
                MessageBox.Show("Asegurese de seleccionar el Camion a modificar");
            }
        }

        private void tbxMetraje_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxMetraje.Text))
            {
                tbxMetraje.Text = "0";
            }

        }

        private void cbbCriterio_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbbCriterio.Text))
            {
                cbbCriterio.SelectedIndex = 0;
            }
        }

        private void cbbBuscador_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtCamiones.Clear();
            if (!string.IsNullOrEmpty(cbbBuscador.Text))
            {

                if (cbbCriterio.Text == "propietario")
                {
                    tbxBuscador.Visible = false;
                    cbbBuscador.Visible = true;
                    dtCamiones = camionescontrolador.buscarCamiones(cbbBuscador.Text, cbbCriterio.Text);
                }
            }
            dgvCamiones.DataSource = null;
            dgvCamiones.DataSource = dtCamiones;
        }

        private void cbbBuscador_TextChanged(object sender, EventArgs e)
        {
            dtCamiones = camionescontrolador.cargarCamiones();
            dgvCamiones.DataSource = null;
            dgvCamiones.DataSource = dtCamiones;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCombustible frmCombustible = new frmCombustible(MyUsuario);
            frmCombustible.Show();
            frmCombustible.Visible = true;
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    lbUbicacionArchivo.Text = dialog.FileName;
                    var varImagen = Image.FromFile(dialog.FileName);
                    using (MemoryStream ms = new MemoryStream())
                    {
                        varImagen.Save(ms, varImagen.RawFormat);
                        pictureBox1.Image = varImagen;
                        // if (imagenParaEnviar == null) MessageBox.Show("No tengo contenido");
                        imagenParaEnviar = ms.ToArray();
                        //  if (imagenParaEnviar != null) MessageBox.Show("Tengo contenido pero no me puedo enviar");
                    }
                }
                else
                {
                    MessageBox.Show("No ha seleccionado ningun archivo");
                }
            }
        }
    }
}
