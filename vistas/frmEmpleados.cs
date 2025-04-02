using programaFacturacion.controlador;
using System.Data;

namespace programaFacturacion.vistas
{
    public partial class frmEmpleados : Form
    {
        empleadosControlador empleadosControlador = new empleadosControlador();
        DataTable dtEmpleado = new DataTable();
        int fila = -1;
        int columna = -1;
        byte[] imagenParaEnviar;
        Int64 IDEmpleado = -1;
        Int64 MyUsuario;
        public frmEmpleados(Int64 IDMarcaUsuario)
        {
            InitializeComponent();
            // asignar valores defacto
            //al datagridview
            MyUsuario = IDMarcaUsuario;
            cbbCriterio.Items.Clear();
            cbbCriterio.Items.Add("nombre");
            cbbCriterio.Items.Add("posicion");
            cbbCriterio.Items.Add("sexo");
            cbbCriterio.Items.Add("cedula");
            cbbCriterio.Items.Add("correo");
            cbbCriterio.SelectedIndex = 0;
            tbxSalario.Text = "0";
            dtEmpleado = empleadosControlador.cargarEmpleados();
            dgvEmpleados.DataSource = dtEmpleado;
            //imagen
            pbxEmpleado.Image = Resources.empleado.empleado1;

        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {

        }

        public void limpiar()
        {
            tbxNombre.Text = "";
            cbxSexo.SelectedIndex = 0;
            tbxCedulaRNC.Text = "";
            tbxDireccion.Text = "";
            cbbPosicion.SelectedIndex = 0;
            tbxTelefono.Text = "";
            tbxCorreo.Text = "";
            tbxSalario.Text = "";
            dtpFechaEntrada.Text = "";
            dtpFechaSalida.Text = "";
            tbxNumeroLicencia.Text = "";
            cbbTipoLicencia.SelectedIndex = 0;
            imagenParaEnviar = null;
            pbxEmpleado.Image = Resources.empleado.empleado1;
            IDEmpleado = -1;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //verificar si ya existe un registro con el nombre o cedula provisto
            if (!string.IsNullOrEmpty(tbxNombre.Text) && !string.IsNullOrEmpty(tbxCedulaRNC.Text) && !string.IsNullOrEmpty(cbbPosicion.Text))
            {
                bool verificarExistencia = empleadosControlador.verificarExistenciaEmpleado(IDEmpleado);
                if (verificarExistencia == true)
                {
                    MessageBox.Show("Ya existe un registro con estos datos");
                }
                else
                {
                    try
                    {
                        empleadosControlador.agregarEmpleado(tbxNombre.Text, cbxSexo.Text, tbxCedulaRNC.Text, tbxDireccion.Text, cbbPosicion.Text, tbxTelefono.Text, tbxCorreo.Text, Convert.ToDouble(tbxSalario.Text), dtpFechaEntrada.Value, dtpFechaSalida.Value, imagenParaEnviar, tbxNumeroLicencia.Text, cbbTipoLicencia.Text, MyUsuario.ToString());
                        dtEmpleado.Clear();
                        dtEmpleado = empleadosControlador.cargarEmpleados();
                        dgvEmpleados.DataSource = dtEmpleado;
                        limpiar();
                        MessageBox.Show("Empleado Agregado Exitosamente!!");

                    }
                    catch (Exception ex) { MessageBox.Show("Ha ingresado un valor no numerico en el salario \n" + ex.ToString()); }
                }
            }
            else
            {
                MessageBox.Show("Rellene los campos para continuar");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            fila = e.RowIndex;
            columna = e.ColumnIndex;
            // try
            //{
            if (fila >= 0 && columna >= 0)
            {
                if (!string.IsNullOrEmpty(dtEmpleado.Rows[fila][1].ToString()))
                {
                    cbbPosicion.Text = dtEmpleado.Rows[fila][1].ToString();
                }
                else { cbbPosicion.Text = ""; cbbPosicion.SelectedIndex = 0; }
                tbxNombre.Text = dtEmpleado.Rows[fila][2].ToString();
                cbxSexo.Text = dtEmpleado.Rows[fila][3].ToString();
                tbxCedulaRNC.Text = dtEmpleado.Rows[fila][4].ToString();
                tbxDireccion.Text = dtEmpleado.Rows[fila][7].ToString();
                IDEmpleado = Convert.ToInt64(dtEmpleado.Rows[fila][0]);
                tbxTelefono.Text = dtEmpleado.Rows[fila][6].ToString();
                tbxCorreo.Text = dtEmpleado.Rows[fila][5].ToString();
                tbxSalario.Text = dtEmpleado.Rows[fila][9].ToString();
                if (!string.IsNullOrEmpty(dtEmpleado.Rows[fila][10].ToString()))
                {
                    dtpFechaEntrada.Value = (DateTime)dtEmpleado.Rows[fila][10];
                }
                if (!string.IsNullOrEmpty(dtEmpleado.Rows[fila][17].ToString()))
                {
                    var imagenEmpleado = (byte[])dtEmpleado.Rows[fila][17];
                    using (MemoryStream ms = new MemoryStream(imagenEmpleado))
                    {
                        pbxEmpleado.Image = Image.FromStream(ms);
                    }



                }
                else { pbxEmpleado.Image = Resources.empleado.empleado1; }

                if (!string.IsNullOrEmpty(dtEmpleado.Rows[fila][11].ToString()))
                {
                    dtpFechaSalida.Value = (DateTime)dtEmpleado.Rows[fila][11];
                }
                tbxNumeroLicencia.Text = dtEmpleado.Rows[fila][18].ToString();
                cbbTipoLicencia.Text = dtEmpleado.Rows[fila][19].ToString();
            }
            //}
            //catch (Exception ex){ MessageBox.Show(ex.ToString()); }
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.tiff";
                if (dialog.ShowDialog() == DialogResult.OK)
                {

                    lbUbicacionArchivo.Text = dialog.FileName;
                    var varImagen = Image.FromFile(dialog.FileName);
                    using (MemoryStream ms = new MemoryStream())
                    {
                        varImagen.Save(ms, varImagen.RawFormat);
                        pbxEmpleado.Image = varImagen;
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                empleadosControlador.eliminarEmpleados(IDEmpleado);
                dtEmpleado.Clear();
                dtEmpleado = empleadosControlador.cargarEmpleados();
                dgvEmpleados.DataSource = dtEmpleado;
                limpiar();
                MessageBox.Show("Eliminado exitosamente");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void tbxSalario_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxSalario.Text))
            {
                tbxSalario.Text = "0";
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbbPosicion.Text))
            {

                empleadosControlador.modificarEmpleados(IDEmpleado, tbxNombre.Text, cbxSexo.Text, tbxCedulaRNC.Text, tbxDireccion.Text, cbbPosicion.Text, tbxTelefono.Text, tbxCorreo.Text, Convert.ToInt64(tbxSalario.Text), DateTime.Now, imagenParaEnviar, tbxNumeroLicencia.Text, cbbTipoLicencia.Text, MyUsuario.ToString());
                dtEmpleado.Clear();
                dtEmpleado = empleadosControlador.cargarEmpleados();
                dgvEmpleados.DataSource = dtEmpleado;
                limpiar();

            }
            else
            {
                MessageBox.Show("debe ingresar una posicion");

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbbPosicion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbPosicion.Text == "chofer")
            {
                lbNumeroLicencia.Visible = true;
                tbxNumeroLicencia.Visible = true;
                lbTipoLicencia.Visible = true;
                cbbTipoLicencia.Visible = true;
            }
            else
            {
                lbNumeroLicencia.Visible = false;
                tbxNumeroLicencia.Visible = false;
                lbTipoLicencia.Visible = false;
                cbbTipoLicencia.Visible = false;
                tbxNumeroLicencia.Text = "";
                cbbTipoLicencia.SelectedIndex = 0;
            }
        }

        private void cbbCriterio_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtEmpleado.Clear();
            dtEmpleado = empleadosControlador.buscarEmpleado(tbxBuscador.Text, cbbCriterio.Text);
            dgvEmpleados.DataSource = null;
            dgvEmpleados.DataSource = dtEmpleado;

        }

        private void tbxBuscadorEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbxBuscador_TextChanged(object sender, EventArgs e)
        {
            dtEmpleado.Clear();
            dtEmpleado = empleadosControlador.buscarEmpleado(tbxBuscador.Text, cbbCriterio.Text);
            dgvEmpleados.DataSource = null;
            dgvEmpleados.DataSource = dtEmpleado;
        }
    }
}
