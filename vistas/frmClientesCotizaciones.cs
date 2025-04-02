using programaFacturacion.controlador;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing.Printing;
using System.IO.Pipes;
using System.Runtime.CompilerServices;

namespace programaFacturacion.vistas
{
    public partial class frmClientesCotizaciones : Form
    {
        ClientesControlador clientesControlador = new ClientesControlador();
        cotizacionesControlador cotizacionesControlador = new cotizacionesControlador();
        public Int64 IDCliente = -1;
        DataTable dtCotizaciones = new DataTable();
        DataTable dtCotizacion = new DataTable();
        DataTable dtClientes = new DataTable();
        DataTable dtCotizacionDetalle = new DataTable();
        Int64 IDCotizacion = -1;
        public int posicionx = -1;
        public int posiciony = -1;
        Int64 IDUsuario;

        public frmClientesCotizaciones(Int64 IDMarcaUsuario)
        {
            InitializeComponent();
            //asignamos la imagen base a el picturebox
            pbxCliente.Image = Properties.Resources.persona;
            IDUsuario = IDMarcaUsuario;

        }

        private void frmClientesCotizaciones_Load(object sender, EventArgs e)
        {
            dtClientes = clientesControlador.getClientesControlador();
            dtCotizaciones = cotizacionesControlador.cargarCotizaciones();
            dgvCotizacion.DataSource = dtCotizaciones;
            //asignamos al combobox la lista de clientes
            foreach (DataRow row in dtClientes.Rows)
            {

                cbbClientes.Items.Add(row[3]);
            }
        }


        // esta funcion se activa al cambiar la informacion del combobox cbbClientes, el cual almacena los nombres de los clientes
        private void cbbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //declaramos las variables necesarias
            Int64 IDCliente = 0;// almacena el IDCliente
            dgvCotizacion.DataSource = null;// quitamos la relacion de datasource con la tabla dtCotizaciones
            dtCotizaciones.Rows.Clear();// la limpiamos por si tiene alguna fila que no deba estar
            dtCotizaciones = cotizacionesControlador.cargarCotizaciones();// cargamos todas las cotizaciones de la base de datos
            DataTable tempTableCotizaciones = dtCotizaciones.Clone();// creamos una tabla temporal que nos servira para almacenar las columnas que
            //tengan un IDCliente igual al IDCliente de nuestro nombreCliente
            if (cbbClientes.SelectedIndex != 0)
            {
                foreach (DataRow row in dtClientes.Rows)// foreach para recorrer la tabla de clientes
                {
                    //row[3] es el nombre del cliente

                    if (row[3].ToString() == cbbClientes.Text)// buscaremos al cliente donde el nombre sea igual a el brindado
                                                              //por nuestro datatable
                    {

                        IDCliente = Convert.ToInt64(row[0]);// capturamos el IDCliente donde el nombre del cliente sea igual a cbbcliente.text
                                                            //ahora que tenemos el ID recorremos el dtCotizaciones para capturar las cotizaciones que tengan el
                        foreach (DataRow row2 in dtCotizaciones.Rows)
                        {
                            if (Convert.ToInt64(row2[2]) == IDCliente)//validamos que sean iguales los ID
                            {
                                //si es asi creamos una row temporal para almacenar la columna que es igual
                                //para ello esta debe tener las mismas columnas que la tabla de origen, para eso es el newRow
                                DataRow tempRowCotizaciones = tempTableCotizaciones.NewRow();
                                tempRowCotizaciones.ItemArray = row2.ItemArray.Clone() as object[];
                                //el itemArray es donde se almacenar los campos de la fila, este es un objeto, por eso al tomar el
                                //row2 con el clone, necesitamos decirle que es como objeto[] <---- esos corchetes indican bytes
                                tempTableCotizaciones.Rows.Add(tempRowCotizaciones);// ahora si podemos cargar sin problemas las filas agregadas
                                                                                    // en el tempRowCotizaciones hacia la temptableCotizaciones

                            }
                        }
                        // y finalmente solo necesitamos igualarlo
                        dgvCotizacion.DataSource = tempTableCotizaciones;


                        //asignar imagen de cliente
                        if (!string.IsNullOrEmpty(row[15].ToString()))
                        {
                            //creamos un objeto que almacene la imagen
                            object objImagenCliente = row[15];
                            // convertimos en bytes
                            byte[] byteImagenCliente = (byte[])objImagenCliente;
                            //creamos imagen
                            Image imagenCliente;
                            using (MemoryStream ms = new MemoryStream(byteImagenCliente))
                            {
                                imagenCliente = Image.FromStream(ms);
                            }
                            pbxCliente.Image = imagenCliente;
                        }

                    }

                }
            }
            else
            {
                dgvCotizacion.DataSource = dtCotizaciones;

            }
        }
        // esto es para que cuando el texto cambie y este vacio pase al item 0 el cual esta vacio
        private void cbbClientes_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbbClientes.Text) || string.IsNullOrWhiteSpace(cbbClientes.Text))
            {
                cbbClientes.SelectedIndex = 0;
                pbxCliente.Image = Resources.persona.Persona;
            }
        }

        private void dgvCotizacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            posicionx = e.ColumnIndex;
            posiciony = e.RowIndex;
            try
            {
                if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                {
                    IDCliente = Convert.ToInt64(dgvCotizacion.Rows[e.RowIndex].Cells[2].Value);
                    //    MessageBox.Show(IDCliente.ToString());
                    IDCotizacion = Convert.ToInt64(dgvCotizacion.Rows[e.RowIndex].Cells[0].Value);

                    //    MessageBox.Show(IDCotizacion.ToString());
                    dtCotizacionDetalle = cotizacionesControlador.cargarDetalleCotizaciones(IDCotizacion);
                    dgvCotizacionDetalle.DataSource = dtCotizacionDetalle;





                }
            }
            catch (Exception ex) 
            { 
            
            }

        }

        private void btnModificarCotizacion_Click(object sender, EventArgs e)
        {
            /*con este codigo verificamos primero que posea un IDCotizacion como referencia
             al ser correcto crea el formulario de frmCotizacion 
             */
            try
            {
                if (IDCotizacion >= 0 && (Application.OpenForms.OfType<FrmCotizacion>().Count() == 0))
                {
                    FrmCotizacion frmCotizacion = new FrmCotizacion(IDUsuario);
                    frmCotizacion.Show();
                    frmCotizacion._dtValoresCotizacion = cotizacionesControlador.cargarDetalleCotizaciones(IDCotizacion);
                    //      frmCotizacion.ClientIndex = 4;
                    frmCotizacion.modificar = true;
                    //asignar cliente
                    foreach (DataRow row in dtClientes.Rows)
                    {
                        string nombreCliente;
                        if (row[0].ToString() == IDCliente.ToString())
                        {
                            nombreCliente = row[3].ToString();
                            for (int i = 0; i < frmCotizacion.cbbCliente.Items.Count; i++)
                            {
                                if (frmCotizacion.cbbCliente.Items[i].ToString() == nombreCliente)
                                {
                                    frmCotizacion.cbbCliente.SelectedIndex = i;
                                    // MessageBox.Show(i.ToString());
                                    break;
                                }

                            }


                        }
                    }
                    //asignar valores transporte, itbis,total,subtotal,descuento
                    frmCotizacion.tbxTransporte.Text = dgvCotizacion.Rows[posiciony].Cells[8].Value.ToString();
                    frmCotizacion.tbxDescuento.Text = dgvCotizacion.Rows[posiciony].Cells[9].Value.ToString();
                    frmCotizacion.tbxITBIS.Text = dgvCotizacion.Rows[posiciony].Cells[7].Value.ToString();
                    frmCotizacion.tbxSubtotal.Text = dgvCotizacion.Rows[posiciony].Cells[6].Value.ToString();
                    frmCotizacion.tbxTotal.Text = dgvCotizacion.Rows[posiciony].Cells[10].Value.ToString();
                    frmCotizacion.total = Convert.ToDouble(dgvCotizacion.Rows[posiciony].Cells[10].Value);
                    frmCotizacion.IDCotizacion = Convert.ToInt64(dgvCotizacion.Rows[posiciony].Cells[0].Value.ToString());
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar una cotizacion");
                }
            }
            catch { }
        }

        private void btnEliminarCotizacoin_Click(object sender, EventArgs e)
        {
            if (IDCotizacion >= 0)
            {
                try
                {
                    cotizacionesControlador.eliminarCotizacion(IDCotizacion, "");
                    dtCotizaciones.Clear();
                    dtCotizaciones = cotizacionesControlador.cargarCotizaciones();
                    dgvCotizacion.DataSource = dtCotizaciones;
                    dtCotizacionDetalle.Clear();
                    dgvCotizacionDetalle.Refresh();
                    cbbClientes.Text = "";
                    IDCotizacion = -1;

                }
                catch (Exception ex) { MessageBox.Show("error \n" + ex.ToString()); }
            }
            else
            {
                MessageBox.Show("Debes seleccionar una cotizacion para eliminar");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Application.OpenForms.OfType<FrmCotizacion>().Count();
            if (a == 0)
            {
                FrmCotizacion frmCotizacion = new FrmCotizacion(IDUsuario);
                frmCotizacion.Show();
                frmCotizacion.Visible = true;
                this.Close();
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (IDCotizacion >= 0)
            {
                printDocument1 = new PrintDocument();
                PrinterSettings ps = new PrinterSettings();
                printDocument1.PrinterSettings = ps;
                printDocument1.PrintPage += imprimirCotizacion;
                printDocument1.Print();
            }
            else
            {
                MessageBox.Show("Debe seleccionar una cotizacion para imprimir");
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }
        private void imprimirCotizacion(object sender, PrintPageEventArgs e)
        {
            string total = dgvCotizacion.Rows[posiciony].Cells[10].Value.ToString();
            string subtotal = dgvCotizacion.Rows[posiciony].Cells[6].Value.ToString();
            string nombreCliente = "";
            string telefono = "";
            string direccion = "";
            Int64 ID = Convert.ToInt64(dgvCotizacion.Rows[posiciony].Cells[0].Value.ToString());
            //  MessageBox.Show(dgvCotizacion.Rows[posiciony].Cells[2].Value.ToString());

            foreach (DataRow row in dtClientes.Rows)
            {

                if (row[0].ToString() == dgvCotizacion.Rows[posiciony].Cells[2].Value.ToString())
                {
                    nombreCliente = row[3].ToString();
                    telefono = row[8].ToString();
                    direccion = row[7].ToString();
                    // MessageBox.Show(nombreCliente);
                }

            }
            impresora impresora = new impresora(ID, nombreCliente, telefono, direccion, dtCotizacionDetalle, Convert.ToDouble(dgvCotizacion.Rows[posiciony].Cells[10].Value.ToString()), IDUsuario, "Cotizacion");
            impresora.imprimirCotizacion();
            impresora = null;
            GC.Collect();
        }

        private void dgvCotizacion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
