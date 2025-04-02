using programaFacturacion.controlador;
using programaFacturacion.vistas;
using System.Data;
using System.Drawing.Printing;

namespace programaFacturacion
{
    public partial class FrmCotizacion : Form
    {
        Int64 IDUsuario;
        DataTable dtArticulos = new DataTable();
        DataTable dtArticulosDetalle = new DataTable();
        cotizacionesControlador controlador = new cotizacionesControlador();
        DataTable dtClientes = new DataTable();
        ClientesControlador clientesControlador = new ClientesControlador();
        DataTable dtCotizacion = new DataTable();
        DataRow rwCotizacion;
        public Int64 IDCotizacion = 0;
        public Int64 IDCliente = 0;
        bool itWasCellClik = false;
        string precioVenta;
        string precioMinimo;
        string nombreArticulo;
        string codigo;
        string inventario;
        bool facturarSinInventario;
        bool precioModificable;
        string IDArticuloDetalle;
        double ITBIS = 18;
        int fila;
        int columna;
        public double total;
        Int64 MyUsuario;

        //el get set permite que sea modificable desde otro lugar!!
        public DataTable _dtValoresCotizacion = null;
        public DataTable dtValoresCotizaciones
        {
            get
            {
                return _dtValoresCotizacion;
            }
            set
            {
                if (_dtValoresCotizacion != value)
                {
                    _dtValoresCotizacion = value;
                }
            }
        }
        private bool _modificar;
        private Int64 _ClientIndex = 0;
        public Int64 ClientIndex
        {
            get { return _ClientIndex; }
            set
            {
                if (_ClientIndex != value)
                {
                    _ClientIndex = value;

                }
            }

        }
        public bool modificar
        {
            get
            {
                return _modificar;
            }
            set
            {
                if (_modificar != value)
                {
                    _modificar = value;
                    if (_modificar == true)
                    {
                        cbbCliente.SelectedIndex = Convert.ToInt32(_ClientIndex);
                        cbbCliente.Enabled = false;
                        dtArticulosDetalle = _dtValoresCotizacion;
                        btnCotizar.Text = "Cotizar Nueva";
                        btnModificar.Visible = true;

                        //arreglar como viene la tabla desde el otro formulario, para que se integre bien aqui
                        try
                        {
                            dtArticulosDetalle.Columns.Remove("IDCotizacionDetalle");
                            dtArticulosDetalle.Columns.Remove("precioCompra");
                            dtArticulosDetalle.Columns.Remove("estado");
                            dtArticulosDetalle.Columns.Remove("guardado");
                            dtArticulosDetalle.Columns.Remove("fechaCreacion");
                            dtArticulosDetalle.Columns.Remove("fechaModificacion");
                            dtArticulosDetalle.Columns.Remove("descripcionModificacion");
                            dtArticulosDetalle.Columns["nombre"].SetOrdinal(2);
                            dtArticulosDetalle.Columns["codigo"].SetOrdinal(3);
                            //dtArticulosDetalle.Columns[""]
                            dgvArticulosDetalle.DataSource = dtArticulosDetalle;
                        }
                        catch { }
                    }
                }
            }
        }


        public void getArticulos()
        {
            dtArticulos.Clear();
            dtArticulos = controlador.getArticulos();
            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = dtArticulos;

        }
        public FrmCotizacion(Int64 IDMarcaUsuario)
        {
            InitializeComponent();
            



            MyUsuario  = IDMarcaUsuario;

            //asignamos los valores defactos de cotizacionDetalle
            tbxTransporte.Text = "0";
            tbxSubtotal.Text = "0";
            tbxITBIS.Text = "0";
            tbxTotal.Text = "0";
            tbxDescuento.Text = "0";
            cbxImprimir.Checked = true;
            cbxImprimirA4.Checked = false;
            //configurando la tabla dtCotizacion
            dtCotizacion.Columns.Add("IDEmpleado", typeof(Int64));
            dtCotizacion.Columns.Add("IDCliente", typeof(Int64));
            dtCotizacion.Columns.Add("IDNFC", typeof(Int64));
            dtCotizacion.Columns.Add("fechaCreacion", typeof(DateTime));
            dtCotizacion.Columns.Add("fechaModificacion", typeof(DateTime));
            dtCotizacion.Columns.Add("subtotal", typeof(double));
            dtCotizacion.Columns.Add("ITBIS", typeof(double));
            dtCotizacion.Columns.Add("transporte", typeof(double));
            dtCotizacion.Columns.Add("descuento", typeof(double));
            dtCotizacion.Columns.Add("total", typeof(double));
            dtCotizacion.Columns.Add("guardado", typeof(bool));
            dtCotizacion.Columns.Add("descripcionModificacion", typeof(string));
            dtCotizacion.Columns.Add("IDCotizacion", typeof(Int64));
            //aqui es donde asignaremos los valores de los registros de esta tabla
            rwCotizacion = dtCotizacion.NewRow();


            //configurando los detalles de la cotizacion
            //tenemos que agregarle las columnas correspondientes a articulos detalle
            dtArticulosDetalle.Columns.Add("IDCotizacion", typeof(Int64));
            dtArticulosDetalle.Columns.Add("IDArticulo", typeof(Int64));
            dtArticulosDetalle.Columns.Add("nombre articulo", typeof(string));
            dtArticulosDetalle.Columns.Add("codigo", typeof(string));
            dtArticulosDetalle.Columns.Add("Cantidad", typeof(double));
            dtArticulosDetalle.Columns.Add("Precio Unitario", typeof(double));
            dtArticulosDetalle.Columns.Add("ITBIS", typeof(double));
            dtArticulosDetalle.Columns.Add("subtotal", typeof(double));
            dtArticulosDetalle.Columns.Add("Descuento", typeof(double));
            dtArticulosDetalle.Columns.Add("Monto", typeof(double));
            dtArticulosDetalle.Rows.Clear();
            dgvArticulosDetalle.DataSource = dtArticulosDetalle;


            //asignar   lista de clientes a el combobox clientes
            // vamos a tomar los valores de la base de datos de clientes
            dtClientes = clientesControlador.getClientesControlador();
            foreach (DataRow row in dtClientes.Rows)
            {
                cbbCliente.Items.Add(row[3]);
            }



        }



        private void FrmCotizacion_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxBuscadorArticulos.Text) || !string.IsNullOrEmpty(tbxCodigo.Text))
            {
                if (itWasCellClik == false)
                {
                    dtArticulos.Clear();
                    dtArticulos = controlador.buscadorArticulos(tbxBuscadorArticulos.Text, tbxCodigo.Text);
                    dgvArticulos.DataSource = dtArticulos;
                }
            }
            else
            {
                getArticulos();
            }
        }

        private void tbxBuscadorArticulos_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxBuscadorArticulos.Text) || !string.IsNullOrEmpty(tbxCodigo.Text))
            {
                if (itWasCellClik == false)
                {
                    dtArticulos.Clear();
                    dtArticulos = controlador.buscadorArticulos(tbxBuscadorArticulos.Text, tbxCodigo.Text);
                    dgvArticulos.DataSource = dtArticulos;
                }
            }
            else
            {
                getArticulos();
            }

            if (tbxBuscadorArticulos.Text == "")
            {
                tbxCodigo.Text = "";
            }
        }

        private void dgvArticulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
            
            if (e.RowIndex >= 0 & e.ColumnIndex >= 0)
            {

                itWasCellClik = true;
                tbxCantidadArticulos.Text = "0";
                nombreArticulo = dgvArticulos.Rows[e.RowIndex].Cells[0].Value.ToString();
                codigo = dgvArticulos.Rows[e.RowIndex].Cells[1].Value.ToString();
                IDArticuloDetalle = dgvArticulos.Rows[e.RowIndex].Cells[2].Value.ToString();
                precioVenta = dgvArticulos.Rows[e.RowIndex].Cells[3].Value.ToString();
                precioMinimo = dgvArticulos.Rows[e.RowIndex].Cells[4].Value.ToString();
                inventario = dgvArticulos.Rows[e.RowIndex].Cells[5].Value.ToString();
                facturarSinInventario = Convert.ToBoolean(dgvArticulos.Rows[e.RowIndex].Cells[6].Value);
                precioModificable = Convert.ToBoolean(dgvArticulos.Rows[e.RowIndex].Cells[7].Value);
                if (precioModificable == false)
                {
                    tbxPrecio.ReadOnly = true;
                }
                else if (precioModificable == true)
                {
                    tbxPrecio.ReadOnly = false;
                }
                tbxCodigo.Text = codigo.ToString();
                tbxArticulos.Text = nombreArticulo.ToString();
                tbxPrecio.Text = precioVenta.ToString();

                itWasCellClik = false;
            }


        }

        private void tbxPrecio_TextChanged(object sender, EventArgs e)
        {
            try
            {

                if (!(Convert.ToInt32(tbxPrecio.Text) >= (Convert.ToInt32(precioMinimo))) && tbxPrecio.Text.Length >= precioMinimo.Length)
                {
                    tbxPrecio.Text = precioVenta;

                }
            }
            catch { }
        }

        //Boton Agregar
        private void button1_Click(object sender, EventArgs e)
        {
            //Calculos y agregar informacion a la tabla
            try
            {
                if (!string.IsNullOrEmpty(tbxCodigo.Text) && !string.IsNullOrEmpty(tbxArticulos.Text) && !string.IsNullOrEmpty(tbxCantidadArticulos.Text) && !string.IsNullOrEmpty(tbxPrecio.Text) && Convert.ToDouble(tbxCantidadArticulos.Text) > 0 && Convert.ToDouble(tbxPrecio.Text) >= Convert.ToDouble(precioMinimo))
                {

                    DataRow rwArticuloDetalle = dtArticulosDetalle.NewRow();
                    if (modificar==false)
                    {
                        rwArticuloDetalle[0] = 0;//IDArticuloDetalle;
                    }
                    else if (IDCotizacion > 0)
                    {
                        rwArticuloDetalle[0] = IDCotizacion;
                    }
                    rwArticuloDetalle[1] = Convert.ToInt64(IDArticuloDetalle);
                    rwArticuloDetalle[2] = tbxArticulos.Text;
                    rwArticuloDetalle[3] = tbxCodigo.Text;
                    rwArticuloDetalle[4] = Convert.ToDouble(tbxCantidadArticulos.Text);
                    rwArticuloDetalle[5] = Convert.ToDouble(tbxPrecio.Text);
                    rwArticuloDetalle[6] = ((Convert.ToDouble(tbxPrecio.Text)) * (ITBIS / 100) * Convert.ToDouble(tbxCantidadArticulos.Text));
                    rwArticuloDetalle[7] = (Convert.ToDouble(tbxPrecio.Text) - (Convert.ToDouble(tbxPrecio.Text)) * (ITBIS / 100)) * Convert.ToDouble(tbxCantidadArticulos.Text);
                    rwArticuloDetalle[8] = ((Convert.ToDouble(tbxPrecio.Text) - Convert.ToDouble(precioVenta)) * Convert.ToDouble(tbxCantidadArticulos.Text)) * -1; // lo multiplicamos por -1 al final para que deje de ser negativo
                    if (Convert.ToDouble(rwArticuloDetalle[8]) < 0)
                    {
                        rwArticuloDetalle[8] = 0;
                    }
                    rwArticuloDetalle[9] = Convert.ToDouble(rwArticuloDetalle[5]) * Convert.ToDouble(rwArticuloDetalle[4]);
                    dtArticulosDetalle.Rows.Add(rwArticuloDetalle);




                    if (dgvArticulosDetalle.Rows.Count > 0)
                    {
                        dgvArticulosDetalle.DataSource = null;
                        dgvArticulosDetalle.Rows.Clear();
                    }
                    dgvArticulosDetalle.DataSource = dtArticulosDetalle;
                    tbxCantidadArticulos.Text = "0";

                    double subtotal = 0;
                    double itbis = 0;// Puse estos itbis en minusculas porque hay uno en mayusculas que es para asignar el valor del porcentaje de itbis, este es para almacenar el resultado del producto del valor de la cantidad*precio y aplicarle el porcentaje de ITBIS en mayusculas
                    double descuento = 0;
                    total = 0;
                    for (int i = 0; i < dtArticulosDetalle.Rows.Count; i++)
                    {
                        for (int j = 0; j < dtArticulosDetalle.Columns.Count; j++)
                        {
                            if (j == 7)
                            {
                                subtotal += float.Parse(dtArticulosDetalle.Rows[i][j].ToString());
                            }
                            if (j == 6)
                            {
                                itbis += float.Parse(dtArticulosDetalle.Rows[i][j].ToString());

                            }
                            if (j == 8)
                            {
                                descuento += float.Parse(dtArticulosDetalle.Rows[i][j].ToString());
                            }
                            if (j == 9)
                            {
                                total += float.Parse(dtArticulosDetalle.Rows[i][j].ToString());
                            }
                        }


                    }
                    tbxSubtotal.Text = Math.Round(subtotal, 2).ToString();
                    tbxITBIS.Text = Math.Round(itbis, 2).ToString();
                    tbxDescuento.Text = Math.Round(descuento, 2).ToString();
                    try
                    {

                        tbxTotal.Text = (Math.Round(total, 2) + float.Parse(tbxTransporte.Text)).ToString();
                    }
                    catch { }

                }
                else
                {
                    MessageBox.Show("Debe Rellenar todos los campos para agregar el articulo. Tambien asegurese de que el precio aplicado sea mayor al precio minimo");
                    // MessageBox.Show(tbxCodigo.Text + "\n" + tbxArticulos.Text + "\n" + tbxCantidadArticulos.Text + "\n" + tbxPrecio.Text + "\n" + tbxCantidadArticulos.Text + "\n" + tbxPrecio.Text + "\n" + precioMinimo.ToString());
                }
            }
            catch (Exception ex) { MessageBox.Show("Hay valores que deben ser numericos" + "\n" + ex); }
        }

        private void dgvArticulosDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (fila >= 0)
            {
                var dataRowView = dgvArticulosDetalle.Rows[fila].DataBoundItem as DataRowView;
                if (dataRowView != null)
                {
                    dataRowView.Row.Delete();
                }
                dgvArticulosDetalle.Refresh();
                double total = 0;
                double subtotal = 0;
                double descuento = 0;
                double itbis = 0;
                foreach (DataRow row in dtArticulosDetalle.Rows)
                {
                    try
                    {
                        total += Convert.ToDouble(row[9]);
                        subtotal += Convert.ToDouble(row[7]);
                        descuento += Convert.ToDouble(row[8]);
                        itbis += Convert.ToDouble(row[6]);
                    }
                    catch
                    { }
                }
                tbxTotal.Text = Math.Round(total, 2).ToString();
                tbxSubtotal.Text = Math.Round(subtotal, 2).ToString();
                tbxDescuento.Text = Math.Round(descuento, 2).ToString();
                tbxITBIS.Text = Math.Round(itbis, 2).ToString();
            }
            else
            {
                tbxTotal.Text = "0";
                tbxSubtotal.Text = "0";
                tbxDescuento.Text = "0";
                tbxITBIS.Text = "0";
            }
        }

        private void dgvArticulosDetalle_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex >= 0 && e.RowIndex >= 0)
                {
                    fila = e.RowIndex;
                    columna = e.ColumnIndex;
                  //  MessageBox.Show("fila:"+fila+"\n columna:"+columna);
                    itWasCellClik = true;
                    tbxCantidadArticulos.Text = "0";
                    nombreArticulo = dgvArticulos.Rows[e.RowIndex].Cells[0].Value.ToString();
                    codigo = dgvArticulos.Rows[e.RowIndex].Cells[1].Value.ToString();
                    IDArticuloDetalle = dgvArticulos.Rows[e.RowIndex].Cells[2].Value.ToString();
                    precioVenta = dgvArticulos.Rows[e.RowIndex].Cells[3].Value.ToString();
                    precioMinimo = dgvArticulos.Rows[e.RowIndex].Cells[4].Value.ToString();
                    inventario = dgvArticulos.Rows[e.RowIndex].Cells[5].Value.ToString();
                    facturarSinInventario = Convert.ToBoolean(dgvArticulos.Rows[e.RowIndex].Cells[6].Value);
                    precioModificable = Convert.ToBoolean(dgvArticulos.Rows[e.RowIndex].Cells[7].Value);
                    if (precioModificable == false)
                    {
                        tbxPrecio.ReadOnly = true;
                    }
                    else if (precioModificable == true)
                    {
                        tbxPrecio.ReadOnly = false;
                    }
                    tbxCodigo.Text = codigo.ToString();
                    tbxArticulos.Text = nombreArticulo.ToString();
                    tbxPrecio.Text = precioVenta.ToString();

                    itWasCellClik = false;
                }
            }
            catch { }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbxDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVerClientes_Click(object sender, EventArgs e)
        {
            frmClientes newClientes = new frmClientes(IDUsuario);
            newClientes.ShowDialog();

            dtClientes.Rows.Clear();
            dtClientes = clientesControlador.getClientesControlador();
            cbbCliente.Items.Clear();

            foreach (DataRow row in dtClientes.Rows)
            {
                cbbCliente.Items.Add(row[3]);

            }
        }

        private void cbbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (DataRow row in dtClientes.Rows)
            {
                string nombre = row[3].ToString();
                if (nombre == cbbCliente.Text)
                {
                    if (!string.IsNullOrEmpty(row[2].ToString()))
                    {
                        tbxTipoCliente.Text = row[2].ToString();
                    }
                    else tbxTipoCliente.Text = "";
                    if (!string.IsNullOrEmpty(row[7].ToString()))
                    {
                        tbxDireccion.Text = row[7].ToString();
                    }
                    else tbxDireccion.Text = "";
                    if (!string.IsNullOrEmpty(row[8].ToString()))
                    {
                        tbxTelefono.Text = row[8].ToString();
                    }
                    else tbxTelefono.Text = "";

                }
            }
        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {
            int clientesCompatiblesConNombreProvisto = 0;

            //crear cotizacion y enviar informacion
            //try
            //  {
            //revisaremos si en clientes controlador existe una columna la cual tenga un nombre igual al de nuestro registro
            if (!string.IsNullOrEmpty(cbbCliente.Text))
            {
                dtClientes.Clear();
                dtClientes = clientesControlador.getClientesControlador();
                foreach (DataRow row in dtClientes.Rows)
                {
                    if (row[3].ToString() == cbbCliente.Text && total > 0)
                    {
                   //     MessageBox.Show("Hola Mundo");
                        clientesCompatiblesConNombreProvisto++;
                        //IDEmpleado
                        rwCotizacion[0] = 3;
                        //IDCliente
                        rwCotizacion[1] = row[0];
                        //IDNFC
                        rwCotizacion[2] = 1;
                        //fechaCreacion
                        rwCotizacion[3] = DateTime.Now;
                        //fechaModificacion
                        rwCotizacion[4] = DateTime.Now;
                        //subtotal
                        rwCotizacion[5] = tbxSubtotal.Text;
                        //ITBIS
                        rwCotizacion[6] = tbxITBIS.Text;
                        //transporte
                        rwCotizacion[7] = tbxTransporte.Text;
                        //descuento
                        rwCotizacion[8] = tbxDescuento.Text;
                        //total
                        rwCotizacion[9] = Math.Round(Convert.ToDouble(tbxTotal.Text), 2).ToString();
                        //guardado
                        rwCotizacion[10] = true;
                        //descripcionModificacion
                        rwCotizacion[11] = "";
                        dtCotizacion.Rows.Add(rwCotizacion);
                        controlador.enviarCotizacion(dtCotizacion,MyUsuario.ToString());
                        foreach (DataRow dataRow in dtArticulosDetalle.Rows)
                        {
                            IDCotizacion = Convert.ToInt64(controlador.cargarCotizacion(Convert.ToDateTime(rwCotizacion[3]), Convert.ToInt64(rwCotizacion[1])));
                            //   MessageBox.Show(IDCotizacion.ToString());
                            dataRow[0] = IDCotizacion;
                            //                      MessageBox.Show(dataRow[0].ToString());
                        }

                        //antes de limpiar los registros imprimiremos los datos
                        // lo condicionaremos para que solo haga esto si la casilla de imprimir esta marcada
                        if (cbxImprimir.Checked == true)
                        {
                            printDocument1 = new PrintDocument();
                            PrinterSettings ps = new PrinterSettings();
                            printDocument1.PrinterSettings = ps;
                            printDocument1.PrintPage += imprimirCotizacion;
                            printDocument1.Print();
                        }

                        //crear cotizacion detalle y enviarlo a la base de datos
                        if (dgvArticulosDetalle.Rows.Count > 0 && clientesCompatiblesConNombreProvisto > 0 && !string.IsNullOrEmpty(cbbCliente.Text))
                        {


                            controlador.enviarCotizacionDetalle(dtArticulosDetalle, MyUsuario.ToString());
                            dtArticulosDetalle.Rows.Clear();
                            dgvArticulosDetalle.DataSource = null;
                            dgvArticulosDetalle.DataSource = dtArticulosDetalle;
                            tbxArticulos.Text = "";
                            tbxCodigo.Text = "";
                            tbxCantidadArticulos.Text = "";
                            tbxPrecio.Text = "";
                            tbxTransporte.Text = "";
                            tbxSubtotal.Text = "";
                            tbxITBIS.Text = "";
                            tbxDescuento.Text = "";
                            tbxTotal.Text = "";
                            dtCotizacion.Rows.Clear();
                            if (modificar == true)
                            {
                                this.Close();
                            }
                        }
                        else { MessageBox.Show("Asegurese de haber ingresado un nombre de cliente correcto"); }



                    }
                    else
                    {
                       // MessageBox.Show("!Hola Mundo");
                    }



                }
            }
            else
            {
                MessageBox.Show("Debe ingresar un nombre de Cliente. Tambien asegurese de haber ingresado articulos");
            }
            //}
            // catch { if (clientesCompatiblesConNombreProvisto == 0) MessageBox.Show("No existe ningun cliente registrado con el nombre provisto"); }

        }

        private void tbxTransporte_TextChanged(object sender, EventArgs e)
        {



            if (string.IsNullOrEmpty(tbxTransporte.Text))
            {
                tbxTransporte.Text = "0";
            }

            try
            {

                tbxTotal.Text = (Math.Round(total, 2) + float.Parse(tbxTransporte.Text)).ToString();
            }
            catch { }


        }

        private void imprimirCotizacion(object sender, PrintPageEventArgs e)
        {

            impresora impresora = new impresora(IDCotizacion, cbbCliente.Text, tbxTelefono.Text, tbxDireccion.Text, dtArticulosDetalle,Convert.ToDouble( dtCotizacion.Rows[0][9].ToString()),MyUsuario,"Cotizacion");
            impresora.imprimirCotizacion();
            impresora = null;
            GC.Collect();
        }

        private void btnAgregarArticulos_Click(object sender, EventArgs e)
        {
            frmArticulos frmArticulos = new frmArticulos(IDUsuario);
            frmArticulos.ShowDialog();
        }

        //Esto se ejecutara al precionar modificar mientras estamos editando una cotizacion
        private void btnModificar_Click(object sender, EventArgs e)
        {

            if (dgvArticulosDetalle.Rows.Count >0)
            {
                //enviamos el valor de total a la tabla de cotizacion para que lo actualice
                controlador.actualizarCotizacion(IDCotizacion.ToString(),tbxTotal.Text,tbxSubtotal.Text,tbxITBIS.Text,tbxTransporte.Text,tbxDescuento.Text, MyUsuario.ToString());

                //eliminamos las cotizaciones detalle que tengan el siguiente IDCotizacion
                controlador.eliminarCotizacion(IDCotizacion,"detalle");
                //enviamos las nuevas cotizaciones detalle
                controlador.enviarCotizacionDetalle(dtArticulosDetalle, MyUsuario.ToString());
                MessageBox.Show("Ha actualizado exitosamente la cotizacion");
                this.Close();
            }
            else
            {
                MessageBox.Show("No  puede dejar una cotizacion vacia, debe tener al menos un articulo");
            }
        }
    }
}
