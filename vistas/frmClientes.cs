using programaFacturacion.controlador;
using System.Data;

namespace programaFacturacion.vistas
{
    public partial class frmClientes : Form
    {
        ClientesControlador controlador = new ClientesControlador();
        cambiarIDaNombreControlador CINC = new cambiarIDaNombreControlador();
        DataTable dtClientes = new DataTable();
        Array imagen;
        Array imagenParaEnviar;
        Int64 IDUsuario;
        Int64 MyUsuario;
        public void getClientes()
        {
            if (controlador.dtClientesControlador != null)
            {
                controlador.dtClientesControlador.Clear();
            }
            controlador.getClientesControlador();
            dgvClientes.DataSource = controlador.dtClientesControlador;

            dgvClientes.Columns[1].HeaderText = "RNC";
        }

        public void limpiarRegistros()
        {
            pbFotoCliente.Image = Properties.Resources.persona;
            tbxNombre.Text = "";
            cbxSexo.SelectedIndex = 0;
            cbxTipoCliente.SelectedIndex = 0;
            tbxCedulaRNC.Text = "";
            tbxEmpresa.Text = "";
            tbxDireccion.Text = "";
            tbxRNC.Text = "";
            tbxTelefono.Text = "";
            tbxCorreo.Text = "";
            tbxBalance.Text = "";
            tbxDeuda.Text = "";
            tbxLimiteCredito.Text = "";
        }

        public frmClientes(Int64 IDMarcaUsuario)
        {
            InitializeComponent();
            MyUsuario = IDMarcaUsuario;
            getClientes();
            //ajustes combobox
            cbxCriterio.SelectedIndex = 0;
            cbxBuscadorTipoCliente.SelectedIndex = 0;
            cbxTipoCliente.SelectedIndex = 0;
            //combobox bloqueadas
            cbxCriterio.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxSexo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxTipoCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxBuscadorTipoCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            tbxBalance.Text = "0";
            tbxDeuda.Text = "0";
            tbxLimiteCredito.Text = "0";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmClientes_Load(object sender, EventArgs e)
        {

        }

        private void tbxBuscador_TextChanged(object sender, EventArgs e)
        {

            if (cbxCriterio.Text != "tipoCliente")// esta condicion es para que cambie de usar el campo buscador, y
                                                  //use el campo buscadorTipoCliente en caso de que sea necesario
            {
                dgvClientes.DataSource = controlador.buscarClientesControlador(cbxCriterio.Text, tbxBuscador.Text);
                dgvClientes.Columns[1].HeaderText = "RNC";
            }
            else
            {
                dgvClientes.DataSource = controlador.buscarClientesControlador(cbxCriterio.Text, cbxBuscadorTipoCliente.Text);
                dgvClientes.Columns[1].HeaderText = "RNC";
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbxBuscadorTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCriterio.Text != "tipoCliente")// esta condicion es para que cambie de usar el campo buscador, y
                                                  //use el campo buscadorTipoCliente en caso de que sea necesario
            {
                dgvClientes.DataSource = controlador.buscarClientesControlador(cbxCriterio.Text, tbxBuscador.Text);
                //     dgvClientes.Columns[1].HeaderText = "RNC";
            }
            else
            {
                dgvClientes.DataSource = controlador.buscarClientesControlador(cbxCriterio.Text, cbxBuscadorTipoCliente.Text);
                dgvClientes.Columns[1].HeaderText = "RNC";
            }

        }

        private void cbxCriterio_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cambiar visibilidad de el combobox buscadorTipoCliente segun se haga click en comboboxCriterio
            if (cbxCriterio.Text == "tipoCliente")
            {
                cbxBuscadorTipoCliente.Visible = true;
            }
            else
            {
                cbxBuscadorTipoCliente.Visible = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dgvClientes.Rows.Count; i++)
                {
                    for (int j = 0; j < dgvClientes.Columns.Count; j++)
                    {

                        if (dgvClientes.Rows[i].Cells[j].GetType().Name.ToString() == "DataGridViewImageCell" && dgvClientes.Rows[i].Cells[j].Value.ToString() != "System.DBNull")
                        {
                            //creamos un objeto que contiene el contenido de la celda, en este caso una imagen
                            object objclienteCelda = dgvClientes.Rows[i].Cells[j].Value;
                            //capturamos ese objeto en bytes[]
                            byte[] bytesObjclienteCelda = (byte[])objclienteCelda;
                            //creamos una variable del tipo imagen 
                            Image imagen;
                            using (MemoryStream ms = new MemoryStream(bytesObjclienteCelda))
                            {
                                //asignamos a  la variable imagen el valor del objeto en bytes[]
                                imagen = Image.FromStream(ms);
                            }
                            //creamos un variable bitmap del tipo Bitmap, con sus respectivas dimenciones
                            Bitmap bitmap = new Bitmap(45, 45);
                            using (Graphics g = Graphics.FromImage(bitmap))
                            {
                                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                                g.DrawImage(imagen, 0, 0, 45, 45);



                                using (MemoryStream ms2 = new MemoryStream())
                                {
                                    var tipoImagen = imagen.RawFormat;
                                    bitmap.Save(ms2, tipoImagen);

                                    dgvClientes.Rows[i].Cells[j].Value = ms2.ToArray();
                                }
                            }



                        }

                    }






                }
            }
            catch (Exception ex)
            {

            }

            //al presionar agregar solo se va a ejecutar si el nombre del cliente no esta vacio
            if (!string.IsNullOrEmpty(tbxNombre.Text))
            {
                /* try
                 {*/

                MessageBox.Show(controlador.agregarClientesControlador(tbxNombre.Text, cbxSexo.Text, imagenParaEnviar, tbxCedulaRNC.Text, tbxEmpresa.Text, tbxDireccion.Text, cbxTipoCliente.Text, tbxTelefono.Text, tbxCorreo.Text, Convert.ToDouble(tbxBalance.Text), Convert.ToDouble(tbxDeuda.Text), Convert.ToDouble(tbxLimiteCredito.Text), DateTime.Now.ToString(), DateTime.Now.ToString(), tbxRNC.Text, MyUsuario.ToString()));
                getClientes();
                limpiarRegistros();
                /*  }
                  catch (Exception ex)
                  {
                      MessageBox.Show("Debe insertar valores numericos\n" + ex, "Error al insertar valor");

                  }*/

            }
            else
            {
                MessageBox.Show("Debe proporcionar un nombre para el cliente");
            }
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //almacenaremos la informacion de dgv en variables para asignarlos a nuestros formulario
            try
            {
                //Esto sirve par cuando se de click en una celda, busque en la linea la celda de imagenes, y la inserte en el picturebox
                if (dgvClientes.Rows[e.RowIndex].Cells[15].Value != DBNull.Value)
                {
                    object objImagenClientes = dgvClientes.Rows[e.RowIndex].Cells[15].Value;
                    byte[] byteImagenClientes = (byte[])objImagenClientes;
                    using (MemoryStream ms = new MemoryStream(byteImagenClientes))
                    {
                        pbFotoCliente.Image = Image.FromStream(ms);
                    }
                }
                else { pbFotoCliente.Image = Properties.Resources.persona; }

                string nombre = dgvClientes.Rows[e.RowIndex].Cells[3].Value.ToString();
                string sexo = dgvClientes.Rows[e.RowIndex].Cells[4].Value.ToString();
                string cedula = dgvClientes.Rows[e.RowIndex].Cells[5].Value.ToString();
                string empresa = dgvClientes.Rows[e.RowIndex].Cells[6].Value.ToString();
                string direccion = dgvClientes.Rows[e.RowIndex].Cells[7].Value.ToString();
                string RNC = dgvClientes.Rows[e.RowIndex].Cells[1].Value.ToString();
                string tipoCliente = dgvClientes.Rows[e.RowIndex].Cells[2].Value.ToString();
                string telefono = dgvClientes.Rows[e.RowIndex].Cells[8].Value.ToString();
                string correo = dgvClientes.Rows[e.RowIndex].Cells[14].Value.ToString();
                string balance = dgvClientes.Rows[e.RowIndex].Cells[9].Value.ToString();
                string deuda = dgvClientes.Rows[e.RowIndex].Cells[10].Value.ToString();
                string limiteCredito = dgvClientes.Rows[e.RowIndex].Cells[11].Value.ToString();
                //insertar estos datos en los campos
                tbxNombre.Text = nombre;
                cbxSexo.Text = sexo;
                tbxCedulaRNC.Text = cedula;
                tbxEmpresa.Text = empresa;
                tbxDireccion.Text = direccion;
                tbxRNC.Text = RNC;
                cbxTipoCliente.Text = tipoCliente;
                tbxTelefono.Text = telefono;
                tbxCorreo.Text = correo;
                tbxBalance.Text = balance;
                tbxDeuda.Text = deuda;
                tbxLimiteCredito.Text = limiteCredito;
            }
            catch (Exception ex)
            {

            }
        }

        private void tbxBalance_TextChanged(object sender, EventArgs e)
        {
            if (tbxBalance.Text == "")
            {
                tbxBalance.Text = "0";
            }
        }

        private void tbxDeuda_TextChanged(object sender, EventArgs e)
        {
            if (tbxDeuda.Text == "")
            { tbxDeuda.Text = "0"; }
        }

        private void tbxLimiteCredito_TextChanged(object sender, EventArgs e)
        {
            if (tbxLimiteCredito.Text == "")
            {
                tbxLimiteCredito.Text = "0";
            }
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
                        pbFotoCliente.Image = varImagen;
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarRegistros();
        }


        private void eliminarClientesView()
        {
            string mensaje = "";
            if (!string.IsNullOrEmpty(tbxNombre.Text))
            {
                mensaje = controlador.eliminarClientesControlador(tbxNombre.Text);
                MessageBox.Show(mensaje);
                getClientes();
                limpiarRegistros();
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre en el campo nombre para eliminar el cliente", "error al eliminar cliente");
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            eliminarClientesView();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxNombre.Text))
            {
                try
                {
                    MessageBox.Show(controlador.modificarClientesControlador(tbxNombre.Text, cbxSexo.Text, imagenParaEnviar, tbxCedulaRNC.Text, tbxEmpresa.Text, tbxDireccion.Text, cbxTipoCliente.Text, tbxTelefono.Text, tbxCorreo.Text, Convert.ToDouble(tbxBalance.Text), Convert.ToDouble(tbxDeuda.Text), Convert.ToDouble(tbxLimiteCredito.Text), DateTime.Now.ToString(), tbxRNC.Text, MyUsuario.ToString()));
                    getClientes();
                    limpiarRegistros();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al ingresar valores no numericos en balance/limiteCredito/deuda" + "\n" + ex);
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre en el campo nombre para modificar el cliente", "error al modificar cliente");
            }
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            frmClientesCotizaciones frmClientesCotizaciones = new frmClientesCotizaciones(IDUsuario);
            frmClientesCotizaciones.ShowDialog();
        }
    }
}

