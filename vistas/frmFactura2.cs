using Microsoft.VisualBasic;
using programaFacturacion.controlador;
using System.Data;
using System.Drawing.Printing;
using System.Reflection.Metadata.Ecma335;
namespace programaFacturacion.vistas
{
    public partial class frmFactura2 : Form
    {
        ClientesControlador ClientesControlador = new ClientesControlador();
        ArticulosControlador ArticulosControlador = new ArticulosControlador();
        facturasControlador facturasControlador = new facturasControlador();
        DataTable dtArticulos = new DataTable();
        DataTable dtClientes = new DataTable();
        Int64 IDCliente = -1;
        Int64 IDUsuario = -1;
        int fila = -1;
        int columna = -1;
        int fila2 = -1;
        int columna2 = -1;
        bool _modificar;
        string _ClientIndex;
        DataTable dtArticulosDetalle = new DataTable();
        public DataTable _dtValoresCotizacion = new DataTable();
        public Int64 IDFactura;
        Int64 IDArtiucloDetalle;
        double precioMinimo;
        Int64 IDArticuloDetalle;
        Int64 IDArticulo = -1;
        double ITBIS = 18;
        double precioVenta;
        public  double total = 0;
        DataTable dtFacturacion = new DataTable();
        PrintDocument printDocument1 = new PrintDocument();
        DataRow rwFacturacion;

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
                        dtArticulosDetalle.Columns[0].ReadOnly = false;
                        btnFacturar2.Text = "Facturar Nueva";
                        btnModificar.Visible = true;

                        //arreglar como viene la tabla desde el otro formulario, para que se integre bien aqui
                        try
                        {
                            //dtArticulosDetalle.Columns[""]
                            dgvArticulosDetalle.DataSource = dtArticulosDetalle;
                        }
                        catch(Exception ex) { MessageBox.Show(ex.ToString()); }
                    }
                }
            }
        }

        public void limpiar()
        {
            cbbCliente.Text = "";
            IDCliente = -1;
            IDArticulo = -1;
            tbxTipoCliente.Text = "";
            tbxTelefono.Text = "";
            tbxDireccion.Text = "";
            tbxBuscadorArticulos.Text = "";
            tbxCodigo.Text = "";
            tbxArticulos.Text = "";
            tbxCantidadArticulos.Text = "";
            tbxPrecio.Text = "";
            precioMinimo = -1;
            tbxTransporte.Text = "";
            tbxSubtotal.Text = "";
            tbxITBIS.Text = "";
            tbxTotal.Text = "";
            cbxPagado.Checked = true;
            cbxAbono.Checked = false;
            cbxEntregado.Checked = false;
            cbxImprimir.Checked = true;
            cbxImprimirA4.Checked = false;
            tbxDescuento.Text = "0";
            cbbMetodoPago.SelectedIndex = 0;

        }

        public void valoresDefactoInfoCliente()
        {
            dtClientes.Clear();
            dtClientes = ClientesControlador.getClientesControlador();
            foreach (DataRow row in dtClientes.Rows)
            {
                cbbCliente.Items.Add(row[3]);
            }
            dtArticulos.Clear();
            try
            {
                dtArticulos = ArticulosControlador.getArticulos();
                dtArticulos.Columns.Remove("IDUnidadMedida");
                dtArticulos.Columns.Remove("RNC");
                dtArticulos.Columns.Remove("IDDepartamento");
                dtArticulos.Columns.Remove("IDProovedor");
                dtArticulos.Columns.Remove("imagen");
            }
            catch (Exception ex) { }


            dgvArticulos.DataSource = dtArticulos;
        }
        public frmFactura2(Int64 MyIDUsuario)
        {
            InitializeComponent();




            cbxPagado.Checked = true;
            cbbMetodoPago.SelectedIndex = 0;
            cbxImprimir.Checked = true;
            tbxTransporte.Text = "0";
            tbxSubtotal.Text = "0";
            tbxITBIS.Text = "0";
            tbxDescuento.Text = "0";
            tbxTotal.Text = "0";
            IDUsuario = MyIDUsuario;
            valoresDefactoInfoCliente();
            //configurando la tabla dtCotizacion
            dtFacturacion.Columns.Add("IDEmpleado", typeof(Int64));
            dtFacturacion.Columns.Add("IDCliente", typeof(Int64));
            dtFacturacion.Columns.Add("IDNFC", typeof(Int64));
            dtFacturacion.Columns.Add("fechaCreacion", typeof(DateTime));
            dtFacturacion.Columns.Add("fechaModificacion", typeof(DateTime));
            dtFacturacion.Columns.Add("subtotal", typeof(double));
            dtFacturacion.Columns.Add("ITBIS", typeof(double));
            dtFacturacion.Columns.Add("transporte", typeof(double));
            dtFacturacion.Columns.Add("descuento", typeof(double));
            dtFacturacion.Columns.Add("total", typeof(double));
            dtFacturacion.Columns.Add("guardado", typeof(bool));
            dtFacturacion.Columns.Add("@abono", typeof(double));
            dtFacturacion.Columns.Add("@entregado", typeof(bool));
            dtFacturacion.Columns.Add("@metodoPago", typeof(string));
            dtFacturacion.Columns.Add("descripcionModificacion", typeof(string));
            dtFacturacion.Columns.Add("IDFacturacion", typeof(Int64));
            dtFacturacion.Columns.Add("Pagado", typeof(bool));
            //aqui es donde asignaremos los valores de los registros de esta tabla
            rwFacturacion = dtFacturacion.NewRow();
            //configurando los detalles de la cotizacion
            //tenemos que agregarle las columnas correspondientes a articulos detalle
            dtArticulosDetalle.Columns.Add("IDFactura", typeof(Int64));
            dtArticulosDetalle.Columns.Add("IDArticulo", typeof(Int64));
            dtArticulosDetalle.Columns.Add("nombre Articulo", typeof(string));
            dtArticulosDetalle.Columns.Add("codigo", typeof(string));
            dtArticulosDetalle.Columns.Add("Cantidad", typeof(double));
            dtArticulosDetalle.Columns.Add("Precio Unitario", typeof(double));
            dtArticulosDetalle.Columns.Add("ITBIS", typeof(double));
            dtArticulosDetalle.Columns.Add("subtotal", typeof(double));
            dtArticulosDetalle.Columns.Add("Descuento", typeof(double));
            dtArticulosDetalle.Columns.Add("Monto", typeof(double));
            dtArticulosDetalle.Columns.Add("Estado",typeof(bool));
            dtArticulosDetalle.Columns.Add("Guardado",typeof(bool));
            dtArticulosDetalle.Columns.Add("Entregado",typeof(bool));
            dtArticulosDetalle.Rows.Clear();
            dgvArticulosDetalle.DataSource = dtArticulosDetalle;



        }

        private void frmFactura2_Load(object sender, EventArgs e)
        {

        }

        private void cbbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbbCliente.Text))
            {
                foreach (DataRow row in dtClientes.Rows)
                {
                    if (cbbCliente.Text == row[3].ToString())
                    {
                        IDCliente = Convert.ToInt64(row[0].ToString());
                        tbxTipoCliente.Text = row[2].ToString();
                        tbxTelefono.Text = row[8].ToString();
                        tbxDireccion.Text = row[7].ToString();
                        break;
                    }

                }
            }

        }

        private void cbbCliente_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbbCliente.Text))
            {
                IDCliente = -1;
                tbxTipoCliente.Text = "";
                tbxTelefono.Text = "";
                tbxDireccion.Text = "";
            }
        }

        private void btnVerClientes_Click(object sender, EventArgs e)
        {

        }

        private void btnVerClientes_Click_1(object sender, EventArgs e)
        {
            int a = Application.OpenForms.OfType<frmClientes>().Count();// con esto podemos contar la cantidad de formularios de este tipo en la aplicacion
            if (a == 0)
            {
                frmClientes frmClientes = new frmClientes(IDUsuario);
                frmClientes.Show();
                frmClientes.Visible = true;
            }
        }

        private void tbxBuscadorArticulos_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxBuscadorArticulos.Text))
            {
                dtArticulos.Clear();
                dgvArticulos.DataSource = null;
                dtArticulos = ArticulosControlador.BuscadorArticulosControlador("nombreArticulo", tbxBuscadorArticulos.Text);
                dgvArticulos.DataSource = dtArticulos;
            }
            else
            {
                dtArticulos.Clear();
                dgvArticulos.DataSource = null;
                dtArticulos = ArticulosControlador.getArticulos();
                dgvArticulos.DataSource = dtArticulos;
            }
        }

        private void btnAgregarArticulos_Click(object sender, EventArgs e)
        {
            int a = Application.OpenForms.OfType<frmArticulos>().Count();// con esto podemos contar la cantidad de formularios de este tipo en la aplicacion
            if (a == 0)
            {
                frmArticulos frmArticulos = new frmArticulos(IDUsuario);
                frmArticulos.Show();
                frmArticulos.Visible = true;
            }
        }

        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvArticulos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex;
            columna = e.ColumnIndex;
            if (columna < 0 ) {columna= 0;}
            if (fila >= 0 && columna >= 0)
            {
                IDArticulo = Convert.ToInt64( dgvArticulos.Rows[fila].Cells[0].Value.ToString());
                tbxCodigo.Text = dgvArticulos.Rows[fila].Cells[1].Value.ToString();
                /*
                    solucion al siguiente error:

                    Al agregar un nuevo articulo cuando usamos el buscador y la tabla de productos 
                    del buscador esta mal organizado 
                    y por ello cuando clickeamos en un articulo no selecciona el nombre de este
                    si no aparentemente el RNC. Corregir!.
                 */
                if (dgvArticulos.Columns[2].Name != "RNC")
                {
                    tbxArticulos.Text = dgvArticulos.Rows[fila].Cells[2].Value.ToString();
                }
                else
                {
                    tbxArticulos.Text = dgvArticulos.Rows[fila].Cells[dgvArticulos.Columns.Count - 1].Value.ToString();
                }
                tbxPrecio.Text = dgvArticulos.Rows[fila].Cells[4].Value.ToString();
                precioMinimo = Convert.ToDouble(dgvArticulos.Rows[fila].Cells[5].Value.ToString());
                precioVenta = Convert.ToDouble(tbxPrecio.Text.ToString());

                if (Convert.ToBoolean(dgvArticulos.Rows[fila].Cells[12].Value.ToString()) == false)
                {
                    tbxPrecio.ReadOnly = true;
                }
                else
                {
                    tbxPrecio.ReadOnly = false;
                }

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Calculos y agregar informacion a la tabla
          //  try
          //  {
                DataRow rwArticuloDetalle = dtArticulosDetalle.NewRow();
                if (!string.IsNullOrEmpty(tbxCodigo.Text) && !string.IsNullOrEmpty(tbxArticulos.Text) && !string.IsNullOrEmpty(tbxCantidadArticulos.Text) && !string.IsNullOrEmpty(tbxPrecio.Text) && Convert.ToDouble(tbxCantidadArticulos.Text) > 0 && (Convert.ToDouble(tbxPrecio.Text) >= Convert.ToDouble(precioMinimo)))
                {
                    if (_modificar == false)
                    {
                        rwArticuloDetalle[0] = 0;//IDArticuloDetalle;
                    }
                    else if (IDFactura > 0)
                    {
                        rwArticuloDetalle[0] = IDFactura;
                    }

                    rwArticuloDetalle[1] = IDArticulo;
                    rwArticuloDetalle[2] = tbxArticulos.Text;

                    rwArticuloDetalle[3] = tbxCodigo.Text;
                    rwArticuloDetalle[4] = Convert.ToDouble(tbxCantidadArticulos.Text);
                    rwArticuloDetalle[5] = Convert.ToDouble(tbxPrecio.Text);
                    rwArticuloDetalle[6] = ((Convert.ToDouble(tbxPrecio.Text)) * (ITBIS / 100) * Convert.ToDouble(tbxCantidadArticulos.Text));
                    rwArticuloDetalle[7] = (Convert.ToDouble(tbxPrecio.Text) - (Convert.ToDouble(tbxPrecio.Text)) * (ITBIS / 100)) * Convert.ToDouble(tbxCantidadArticulos.Text);
                    rwArticuloDetalle[8] = ((Convert.ToDouble(tbxPrecio.Text) - Convert.ToDouble(precioVenta)) * Convert.ToDouble(tbxCantidadArticulos.Text)) * -1; // lo multiplicamos por -1 al final para que deje de ser negativo
                //    MessageBox.Show("precio compra: "+tbxPrecio.Text+"\n precio venta: "+precioVenta.ToString()+"\n cantidad de articulos: "+tbxCantidadArticulos.Text);
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
                    //  MessageBox.Show(tbxCodigo.Text + "\n" + tbxArticulos.Text + "\n" + tbxCantidadArticulos.Text + "\n" + tbxPrecio.Text + "\n" + tbxCantidadArticulos.Text + "\n" + tbxPrecio.Text + "\n" + precioMinimo.ToString());
                }
         //   }
          //  catch (Exception ex)
//{ MessageBox.Show("Hay valores que deben ser numericos \n"+ex.ToString()); }
        }

        private void btnCotizar_Click(object sender, EventArgs e)
        {

        }


        private void imprimirCotizacion(object sender, PrintPageEventArgs e)
        {

            impresora impresora = new impresora(IDFactura, cbbCliente.Text, tbxTelefono.Text, tbxDireccion.Text, dtArticulosDetalle, Convert.ToDouble(dtFacturacion.Rows[0][9].ToString()), IDUsuario, "Factura");
            impresora.imprimirCotizacion();
            impresora = null;
            GC.Collect();
        }

        private void tbxTransporte_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxTransporte.Text))
            {
                tbxTransporte.Text = "0";
            }
            try
            {
                double valor = Convert.ToDouble(tbxTotal.Text);
                tbxTotal.Text = Convert.ToString(valor + Convert.ToDouble(tbxTransporte.Text));
            }
            catch
            {

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (fila2 >= 0)
            {
                var dataRowView = dgvArticulosDetalle.Rows[fila2].DataBoundItem as DataRowView;
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

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                fila2 = e.RowIndex;
                columna2 = e.ColumnIndex;
            }
        }

        private void btnFacturar2_Click(object sender, EventArgs e)
        {
            int clientesCompatiblesConNombreProvisto = 0;

            //crear cotizacion y enviar informacion
            //try
            //  {
            //revisaremos si en clientes controlador existe una columna la cual tenga un nombre igual al de nuestro registro
            if (!string.IsNullOrEmpty(cbbCliente.Text) && (IDCliente > 0))
            {
                dtClientes.Clear();
                dtClientes = ClientesControlador.getClientesControlador();

                foreach (DataRow row in dtClientes.Rows)
                {
                    if (row[3].ToString() == cbbCliente.Text && total > 0)
                    {
                        //     MessageBox.Show("Hola Mundo");
                        clientesCompatiblesConNombreProvisto++;
                        //IDEmpleado
                        rwFacturacion[0] = 3;
                        //IDCliente
                        rwFacturacion[1] = row[0];
                        //IDNFC
                        rwFacturacion[2] = 1;
                        //fechaCreacion
                        rwFacturacion[3] = DateTime.Now;
                        //fechaModificacion
                        rwFacturacion[4] = DateTime.Now;
                        //subtotal
                        rwFacturacion[5] = tbxSubtotal.Text;
                        //ITBIS
                        rwFacturacion[6] = tbxITBIS.Text;
                        //transporte
                        rwFacturacion[7] = tbxTransporte.Text;
                        //descuento
                        rwFacturacion[8] = tbxDescuento.Text;
                        //total
                        rwFacturacion[9] = Math.Round(Convert.ToDouble(tbxTotal.Text), 2).ToString();
                       // MessageBox.Show(rwFacturacion[9].ToString());
                        //guardado
                        rwFacturacion[10] = true;
                        //descripcionModificacion
                        rwFacturacion[14] = IDUsuario.ToString();
                        //abono
                        string abonoValor = "";
                        int numeroLetras = 0;
                        double abono = 0;
                        if (cbxAbono.Checked == true)
                        {
                            while (true)
                            {
                                abonoValor = "";
                                numeroLetras = 0;
                                abono = 0;
                                try
                                {
                                    abonoValor = Convert.ToString(Interaction.InputBox("ingrese el valor que el cliente desea abonar", "abono", "0"));

                                    foreach (char Char in abonoValor)
                                    {
                                        if (Char.IsLetter(Char))
                                        {
                                            numeroLetras += 1;
                                        }
                                    }

                                    if (numeroLetras == 0)
                                    {
                                        break;
                                    }
                                }
                                catch { abono = 0; }

                            }
                        }
                        else
                        {
                            abono = 0;
                        }
                        rwFacturacion[11] = abono;
                        //entregado
                        if (cbxEntregado.Checked == true)
                        {
                            rwFacturacion[12] = true;
                            foreach (DataRow Row2 in dtArticulosDetalle.Rows)
                            {
                                Row2[12] = true;
                            }
                            
                        
                        }
                        else { 
                            rwFacturacion[12] = false;
                            foreach (DataRow Row2 in dtArticulosDetalle.Rows)
                            {
                                try
                                {
                                    Row2[12] = false;
                                }
                                catch (Exception ex)
                                { 
                                
                                }
                            }
                        }
                        //metodo de pago
                        rwFacturacion[13] = cbbMetodoPago.Text;
                        //pagada
                        if (cbxPagado.Checked = true)
                        {
                            rwFacturacion[15] = true;
                        }
                        else
                        {
                            rwFacturacion[15]=false;
                        }
                            dtFacturacion.Rows.Add(rwFacturacion);
                        facturasControlador.enviarFactura(dtFacturacion, IDUsuario.ToString());
                      //  MessageBox.Show("facturaEnviada2");
                      
                        foreach (DataRow dataRow in dtArticulosDetalle.Rows)
                        {
                            IDFactura = Convert.ToInt64(facturasControlador.cargarFactura(Convert.ToDateTime(rwFacturacion[3]), Convert.ToInt64(rwFacturacion[1])));
                          //     MessageBox.Show(IDFactura.ToString());
                            try
                            {
                                if (_modificar == false)
                                {
                                    dataRow[0] = IDFactura;
                          //          MessageBox.Show("_modificar=false");
                                }
                                else
                                {
                                    dataRow[1] = IDFactura;
                              //      MessageBox.Show("_modificar=true");

                                }
                            }
                            catch(Exception ex)
                            { 
                            
                            }

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

                            facturasControlador.enviarFacturasDetalle(dtArticulosDetalle, IDUsuario.ToString());
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
                            dtFacturacion.Rows.Clear();
                            if (_modificar == true)
                            {
                                this.Close();
                            }
                            limpiar();

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
                MessageBox.Show("Ingrese un cliente para poder facturar");
            }
        }

        private void cbxPagado_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxPagado.Checked == true)
            {
                cbxAbono.Checked = false;
            }
        }

        private void cbxAbono_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxAbono.Checked == true)
            {
                cbxPagado.Checked = false;
            }
        }
    }
}
