using programaFacturacion.controlador;
using System.Data;

namespace programaFacturacion.vistas
{
    public partial class frmClientesFacturacion : Form
    {
        Int64 IDUsuario;
        //clientes
        ClientesControlador clientesControlador = new ClientesControlador();
        DataTable dtClientes = new DataTable();
        Int64 IDCliente = -1;
        //facturas
        facturasControlador facturasControlador = new facturasControlador();
        DataTable dtFacturas = new DataTable();
        Int64 IDFactura = -1;
        //facturasDetalle
        DataTable dtFacturasDetalle = new DataTable();
        //fila y columna
        int fila = -1;
        int columna = -1;

        //impresora
        impresora imprimir;


        //comodin
        cambiarIDaNombreControlador CINC = new cambiarIDaNombreControlador();

        public void limpirarFacturasDetalle()
        {

            dgvFacturasDetalle.DataSource = null;
            dtFacturasDetalle.Clear();
        }

        public void buscarFacturasDetalle(Int64 idfactura)
        {
            limpirarFacturasDetalle();
            dtFacturasDetalle = facturasControlador.cargarDetallesFacturas(idfactura);
            dtFacturasDetalle.Columns[16].SetOrdinal(2);
            dtFacturasDetalle.Columns[7].SetOrdinal(6);
            dtFacturasDetalle.Columns[17].SetOrdinal(9);
            /* dtFacturasDetalle.Columns[17].SetOrdinal(3);*/
            dgvFacturasDetalle.DataSource = dtFacturasDetalle;
        }

        public void cargarFacturas()
        {
            dtFacturas.Clear();
            dgvFacturas.DataSource = null;
            dtFacturasDetalle.Clear();
            dgvFacturasDetalle.DataSource = null;
            dtFacturas = facturasControlador.cargarFacturas();
            dgvFacturas.DataSource = dtFacturas;
        }

        public void buscarFacturas(Int64 idcliente)
        {
            dtFacturas.Clear();
            dgvFacturas.DataSource = null;
            dtFacturas = facturasControlador.buscarFacturas(idcliente);
            dgvFacturas.DataSource = dtFacturas;
        }

        public void eliminarFactura(Int64 idfactura)
        {
            facturasControlador.eliminarFactura(IDFactura, "ambos");
            cargarFacturas();
        }

        public frmClientesFacturacion(Int64 MyIDUsuario)
        {
            InitializeComponent();
            IDUsuario = MyIDUsuario;
            //agregar todos los clientes
            dtClientes = clientesControlador.getClientesControlador();
            //asignar clientes a la combobox
            foreach (DataRow row in dtClientes.Rows)
            {
                cbbClientes.Items.Add(row[3].ToString());
            }

            //asignar facturas
            cargarFacturas();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmFactura2>().Count() == 0)
            {




                frmFactura2 factura = new frmFactura2(IDUsuario);
                factura.Show();
                factura.Visible = true;
            }
        }

        private void frmClientesFacturacion_Load(object sender, EventArgs e)
        {

        }

        private void cbbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (DataRow row in dtClientes.Rows)
            {

                if (row[3].ToString() == cbbClientes.Text)
                {
                    IDCliente = Convert.ToInt64(row[0].ToString());
                    buscarFacturas(IDCliente);
                    break;
                }
            }
        }

        private void cbbClientes_TextChanged(object sender, EventArgs e)
        {
            if (cbbClientes.Text == "")
            {
                IDCliente = -1;
                cargarFacturas();
            }
        }

        private void dgvFacturas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                fila = e.RowIndex;
                columna = e.ColumnIndex;

                if (fila >= 0 && columna >= 0)
                {
                    IDFactura = Convert.ToInt64(dgvFacturas.Rows[fila].Cells[0].Value.ToString());
                    IDCliente = Convert.ToInt64(dgvFacturas.Rows[fila].Cells[2].Value.ToString());
                    //   MessageBox.Show(IDFactura.ToString());
                    buscarFacturasDetalle(IDFactura);

                }
            } catch { }
        }

        private void btnEliminarCotizacoin_Click(object sender, EventArgs e)
        {
            // MessageBox.Show(IDFactura.ToString());
            if (IDFactura >= 0)
            {
                eliminarFactura(IDFactura);
            }
            else
            {
                MessageBox.Show("Debe seleccionar una factura para eliminar");
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

            if (IDFactura >= 0)
            {
                MessageBox.Show(IDCliente.ToString());
                foreach (DataRow row in dtClientes.Rows)
                {
                    if (IDCliente == Convert.ToInt64(row[0].ToString()))
                    {
               //         MessageBox.Show("el cliente#" + row[0].ToString() + "\n" + " es igual al IDCliente:" + IDCliente.ToString());

                        foreach (DataRow row2 in dtFacturas.Rows)
                        {
                            if ((Convert.ToInt64(row2[0].ToString()) == IDFactura))
                            {
                                //obtener el nombre del cliente
                                string nombreCliente = CINC.getID("Clientes", "nombreRepresentante", "IDCliente", IDCliente).ToString();


                                imprimir = new impresora(IDFactura, nombreCliente, row[8].ToString(), row[7].ToString(), dtFacturasDetalle, Convert.ToInt64(row2[10].ToString()), IDUsuario, "Factura");
                                imprimir.imprimirCotizacion();
                                limpirarFacturasDetalle();
                                break;

                            }

                        }
                        break;
                    }
                    else
                    {
                        MessageBox.Show("el cliente#" + row[0].ToString() + "\n" + "no es igual al IDCliente:" + IDCliente.ToString());
                    }

                }
            }
            else
            {
                MessageBox.Show("Asegurese de seleccionar una factura para imprimir");
            }

        }

        private void btnModificarCotizacion_Click(object sender, EventArgs e)
        {
            if ((IDFactura > 0) && (Application.OpenForms.OfType<frmFactura2>().Count() == 0))
            {




                frmFactura2 factura = new frmFactura2(IDUsuario);

                factura.Show();
                factura.Visible = true;
              //  MessageBox.Show(dtFacturasDetalle.Rows.Count.ToString());
                factura._dtValoresCotizacion = dtFacturasDetalle;
                //      frmCotizacion.ClientIndex = 4;
                factura.modificar = true;
                //asignar cliente
                foreach (DataRow row in dtClientes.Rows)
                {
                    string nombreCliente;
                    if (row[0].ToString() == IDCliente.ToString())
                    {
                        nombreCliente = row[3].ToString();
                        for (int i = 0; i < factura.cbbCliente.Items.Count; i++)
                        {
                            if (factura.cbbCliente.Items[i].ToString() == nombreCliente)
                            {
                                factura.cbbCliente.SelectedIndex = i;
                                // MessageBox.Show(i.ToString());
                                break;
                            }

                        }


                    }
                }
                //asignar valores transporte, itbis,total,subtotal,descuento
                factura.tbxTransporte.Text = dgvFacturas.Rows[fila].Cells[8].Value.ToString();
                factura.tbxDescuento.Text = dgvFacturas.Rows[fila].Cells[9].Value.ToString();
                factura.tbxITBIS.Text = dgvFacturas.Rows[fila].Cells[7].Value.ToString();
                factura.tbxSubtotal.Text = dgvFacturas.Rows[fila].Cells[6].Value.ToString();
                factura.tbxTotal.Text = dgvFacturas.Rows[fila].Cells[10].Value.ToString();
                factura.total = Convert.ToDouble(dgvFacturas.Rows[fila].Cells[10].Value);
                factura.IDFactura = Convert.ToInt64(dgvFacturas.Rows[fila].Cells[0].Value.ToString());
                this.Close();
            }
            else
            {
                MessageBox.Show("Asegurese de seleccionar una factura para modificar. Tambien que no exista otro modulo de facturacion abierto.");
            
            }
        }
    }
}
