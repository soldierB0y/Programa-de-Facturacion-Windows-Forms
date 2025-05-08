using Microsoft.Data.SqlClient;
using System.Data;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
namespace programaFacturacion.modelo
{
    public class facturasModelo
    {
        conexion conexion1 = new conexion();
        public DataTable dtArticulos = new DataTable();
        public DataTable dtCotizaciones = new DataTable();
        public DataTable getArticulos()
        {
            string consulta = "select nombreArticulo,codigo,IDArticulo,precioventa,preciominimo,inventario,facturarSinInventario,precioModificable from Articulos";
            using (SqlConnection ocon = new SqlConnection(conexion1.connectionString))
            {
                ocon.Open();
                using (SqlCommand cmd = new SqlCommand(consulta, ocon))
                {
                    cmd.ExecuteNonQuery();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();
                        if (reader.HasRows)
                        {
                            dtArticulos.Load(reader);
                        }
                    }
                }
                ocon.Close();
            }

            return dtArticulos;
        }

        public DataTable buscadorArticulos(string buscador, string codigo)
        {
            string consulta = "";
            using (SqlConnection ocon = new SqlConnection(conexion1.connectionString))
            {
                ocon.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    if ((!string.IsNullOrEmpty(buscador)) && (string.IsNullOrEmpty(codigo)))
                    {
                        buscador = "%" + buscador + "%";
                        consulta = "select nombreArticulo,codigo,IDArticulo,precioventa,preciominimo,inventario,facturarSinInventario,precioModificable from articulos where nombreArticulo like @nombreArticulo ";
                        cmd.Parameters.AddWithValue("@nombreArticulo", buscador);
                    }
                    else if ((!string.IsNullOrEmpty(buscador)) && (!string.IsNullOrEmpty(codigo)))
                    {
                        buscador = "%" + buscador + "%";
                        codigo = "%" + codigo + "%";
                        consulta = "select nombreArticulo,codigo,IDArticulo,precioventa,preciominimo,inventario,facturarSinInventario,precioModificable from articulos where (nombreArticulo like @nombreArticulo or codigo like @codigo) ";
                        cmd.Parameters.AddWithValue("@nombreArticulo", buscador);
                        cmd.Parameters.AddWithValue("@codigo", codigo);
                    }
                    else if ((string.IsNullOrEmpty(buscador)) && (!string.IsNullOrEmpty(codigo)))
                    {
                        codigo = "%" + codigo + "%";
                        consulta = "select nombreArticulo,codigo,IDArticulo,precioventa,preciominimo,inventario,facturarSinInventario,precioModificable from articulos where codigo like @codigo ";
                        cmd.Parameters.AddWithValue("@codigo", codigo);
                    }
                    if (!((string.IsNullOrEmpty(buscador)) && (string.IsNullOrEmpty(codigo))))
                    {


                        cmd.Connection = ocon;
                        cmd.CommandText = consulta;
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dtArticulos.Clear();
                                dtArticulos.Load(reader);
                            }
                        }
                    }

                }
                ocon.Close();
                return dtArticulos;
            }
        }


        public string cargarFactura(DateTime datetime, Int64 IDCLiente)
        {
            Int64 IDFactura = 0;
            string consulta = "select * from factura where fechaCreacion= @fechaCreacion and IDCliente= @IDCliente";
            using (SqlConnection ocon = new SqlConnection(conexion1.connectionString))
            {
                ocon.Open();
                using (SqlCommand cmd = new SqlCommand(consulta, ocon))
                {

                    cmd.Parameters.AddWithValue("@fechaCreacion", datetime);
                    cmd.Parameters.AddWithValue("@IDCliente", IDCLiente);
                    cmd.ExecuteNonQuery();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            DataTable dtReader = new DataTable();
                            dtReader.Load(reader);
                            IDFactura = Convert.ToInt64(dtReader.Rows[0][0]);
                        }
                    }
                }
                ocon.Close();
            }

            return IDFactura.ToString();
        }


        public DataTable cargarFacturas()
        {
            DataTable dtFacturas= new DataTable();
            string consulta = "select * from factura";
            using (SqlConnection ocon = new SqlConnection(conexion1.connectionString))
            {
                ocon.Open();
                using (SqlCommand cmd = new SqlCommand(consulta, ocon))
                {

                    cmd.ExecuteNonQuery();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            dtFacturas.Clear();
                            dtFacturas.Load(reader);
                        }
                    }
                }
                ocon.Close();
            }

            return dtFacturas;
        }

        public DataTable buscarFacturas(Int64 IDCliente)
        {
            DataTable dtFacturas= new DataTable();
            string consulta = "select * from factura where IDCliente=@IDCliente";
            using (SqlConnection ocon = new SqlConnection(conexion1.connectionString))
            {
                ocon.Open();
                using (SqlCommand cmd = new SqlCommand(consulta, ocon))
                {
                    cmd.Parameters.AddWithValue("@IDCliente",IDCliente);
                    cmd.ExecuteNonQuery();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {

                            dtFacturas.Load(reader);
                        }
                    }
                }
                ocon.Close();
            }

            return dtFacturas;
        }


        public void enviarFacturas(DataTable factura,string descripcionModificacion)
        {
            string consulta = "insert into factura(IDEmpleado,IDCliente,NCF,fechaCreacion,fechaModificacion,subtotal,ITBIS,transporte,descuento,total,pagado,guardado,abono,entregado,metodoPago,descripcionModificacion)" +
                "values(@IDEmpleado,@IDCliente,@NCF,@fechaCreacion,@fechaModificacion,@subtotal,@ITBIS,@transporte,@descuento,@total,@pagado,@guardado,@abono,@entregado,@metodoPago,@descripcionModificacion)";
            using (SqlConnection ocon = new SqlConnection(conexion1.connectionString))
            {
                ocon.Open();
                using (SqlCommand cmd = new SqlCommand(consulta, ocon))
                {
                    cmd.Parameters.AddWithValue("@IDempleado", Convert.ToInt64(factura.Rows[0][0]));
                    cmd.Parameters.AddWithValue("@IDCliente", Convert.ToInt64(factura.Rows[0][1]));
                    cmd.Parameters.AddWithValue("@NCF", Convert.ToInt64(factura.Rows[0][2]));
                    cmd.Parameters.AddWithValue("@fechaCreacion", factura.Rows[0][3]);
                    cmd.Parameters.AddWithValue("@fechaModificacion", factura.Rows[0][4]);
                    cmd.Parameters.AddWithValue("@subtotal", Convert.ToDouble(factura.Rows[0][5]));
                    cmd.Parameters.AddWithValue("@ITBIS", Convert.ToDouble(factura.Rows[0][6]));
                    cmd.Parameters.AddWithValue("@transporte", Convert.ToDouble(factura.Rows[0][7]));
                    cmd.Parameters.AddWithValue("@descuento", Convert.ToDouble(factura.Rows[0][8]));
                    cmd.Parameters.AddWithValue("@total", Convert.ToDouble(factura.Rows[0][9]));
                    cmd.Parameters.AddWithValue("@guardado", Convert.ToBoolean(factura.Rows[0][10]));
                    cmd.Parameters.AddWithValue("@abono", Convert.ToDouble(factura.Rows[0][11]));
                    cmd.Parameters.AddWithValue("@entregado", Convert.ToBoolean(factura.Rows[0][12]));
                    cmd.Parameters.AddWithValue("@metodoPago",(factura.Rows[0][13].ToString()));
                    cmd.Parameters.AddWithValue("@pagado", (factura.Rows[0][15].ToString()));
                    cmd.Parameters.AddWithValue("@descripcionModificacion",descripcionModificacion);
                    cmd.ExecuteNonQuery();
                    // cmd.Parameters.AddWithValue("@IDCliente");
                    //  cmd.Parameters.AddWithValue("");
                }
                ocon.Close();
            }
        }

        public void enviarFacturasDetalle(DataTable facturacionDetalle,string descripcionModificacion)
        {
            string consulta = "insert into facturaDetalle(IDFacturacion,IDArticulo,codigo,nombre,cantidad,precioUnitario,precioCompra,ITBIS,subtotal,estado,guardado,entregado,descuento,Monto,fechaCreacion,fechaModificacion,descripcionModificacion)" +
                "values(@IDFacturacion,@IDArticulo,@codigo,@nombre,@cantidad,@precioUnitario,@precioCompra,@ITBIS,@subtotal,@estado,@guardado,@entregado,@descuento,@Monto,@fechaCreacion,@fechaModificacion,@descripcionModificacion)";

            using (SqlConnection ocon = new SqlConnection(conexion1.connectionString))
            {
                ocon.Open();
                foreach (DataRow row in facturacionDetalle.Rows)
                {
                   // try
                  //  {
                        using (SqlCommand cmd = new SqlCommand(consulta, ocon))
                        {

                            cmd.Parameters.AddWithValue("@IDFacturacion", row[0]);
                            cmd.Parameters.AddWithValue("@IDArticulo", row[1]);
                            cmd.Parameters.AddWithValue("@nombre", row[2]);
                            cmd.Parameters.AddWithValue("@codigo", row[3]);
                            cmd.Parameters.AddWithValue("@cantidad", row[4]);
                            cmd.Parameters.AddWithValue("@precioUnitario", row[5]);
                            cmd.Parameters.AddWithValue("@precioCompra",row[13]);
                            cmd.Parameters.AddWithValue("@ITBIS", row[6]);
                            cmd.Parameters.AddWithValue("@subtotal", row[7]);
                            cmd.Parameters.AddWithValue("@estado",1);
                            cmd.Parameters.AddWithValue("@guardado",1);
                            cmd.Parameters.AddWithValue("@entregado", row[12]);
                            cmd.Parameters.AddWithValue("@descuento", row[8]);
                            cmd.Parameters.AddWithValue("Monto", row[9]);
                            cmd.Parameters.AddWithValue("@fechaCreacion", DateTime.Now);
                            cmd.Parameters.AddWithValue("@fechaModificacion", DateTime.Now);
                            cmd.Parameters.AddWithValue("@descripcionModificacion",descripcionModificacion );
                            cmd.ExecuteNonQuery();
                        }
                 //   }
                //    catch(Exception ex)
                //    { MessageBox.Show(ex.ToString()); }
                }

                ocon.Close();
            }
        }


        public void enviarFacturasDetalleModificar(DataTable facturacionDetalle, string descripcionModificacion)
        {
            string consulta = "insert into facturaDetalle(IDFacturacion,IDArticulo,codigo,nombre,cantidad,precioUnitario,precioCompra,ITBIS,subtotal,estado,guardado,entregado,descuento,Monto,fechaCreacion,fechaModificacion,descripcionModificacion)" +
                "values(@IDFacturacion,@IDArticulo,@codigo,@nombre,@cantidad,@precioUnitario,@precioCompra,@ITBIS,@subtotal,@estado,@guardado,@entregado,@descuento,@Monto,@fechaCreacion,@fechaModificacion,@descripcionModificacion)";

            using (SqlConnection ocon = new SqlConnection(conexion1.connectionString))
            {
                ocon.Open();
                foreach (DataRow row in facturacionDetalle.Rows)
                {
                    // try
                    //  {
                    using (SqlCommand cmd = new SqlCommand(consulta, ocon))
                    {

                        cmd.Parameters.AddWithValue("@IDFacturacion", row[1]);
                        cmd.Parameters.AddWithValue("@IDArticulo", row[3]);
                        cmd.Parameters.AddWithValue("@nombre", row[2]);
                        cmd.Parameters.AddWithValue("@codigo", row[17]);
                        cmd.Parameters.AddWithValue("@cantidad", row[4]);
                        cmd.Parameters.AddWithValue("@precioUnitario", row[5]);
                        cmd.Parameters.AddWithValue("@precioCompra", 0);
                        cmd.Parameters.AddWithValue("@ITBIS", row[6]);
                        cmd.Parameters.AddWithValue("@subtotal", row[8]);
                        cmd.Parameters.AddWithValue("@estado", 1);
                        cmd.Parameters.AddWithValue("@guardado", 1);
                        cmd.Parameters.AddWithValue("@entregado", row[12]);
                        cmd.Parameters.AddWithValue("@descuento", row[13]);
                        cmd.Parameters.AddWithValue("Monto", row[9]);
                        cmd.Parameters.AddWithValue("@fechaCreacion", DateTime.Now);
                        cmd.Parameters.AddWithValue("@fechaModificacion", DateTime.Now);
                        cmd.Parameters.AddWithValue("@descripcionModificacion", descripcionModificacion);
                        cmd.ExecuteNonQuery();
                    }
                    //   }
                    //    catch(Exception ex)
                    //    { MessageBox.Show(ex.ToString()); }
                }

                ocon.Close();
            }
        }

        public DataTable cargarDetalleFactura(Int64 IDFacturacion)
        {
            DataTable dtDetalleFactura = new DataTable();
            try
            {

                string consulta = "select * from facturaDetalle where IDFacturacion= @IDFacturacion";
                using (SqlConnection ocon = new SqlConnection(conexion1.connectionString))
                {
                    ocon.Open();
                    using (SqlCommand cmd = new SqlCommand(consulta, ocon))
                    {
                        cmd.Parameters.AddWithValue("@IDFacturacion", IDFacturacion);
                        cmd.ExecuteNonQuery();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dtDetalleFactura.Load(reader);
                            }
                        }
                    }
                    ocon.Close();
                    return dtDetalleFactura;
                }
            }catch (Exception ex) {return dtDetalleFactura=new DataTable(); }
            
           
        }
        public void modificarFactura()
        {

        }

        public void eliminarFactura(Int64 IDFacturacionDetalle, string comando)
        {
            //comando= detalle, elimina solo los detalles
            // comando= "" o comando="ambos" elimina ambos registros
            //eliminaremos la cotizacion detalle primero y luego la cotizacion
            string consulta = "delete from facturaDetalle where IDFacturacion= @IDFactura";
            string consulta2 = "delete from factura where IDFactura = @IDFactura";
            using (SqlConnection ocon = new SqlConnection(conexion1.connectionString))
            {
                ocon.Open();
                if (comando == "" || comando == "ambos" || comando == "detalle")
                {
                    using (SqlCommand cmd = new SqlCommand(consulta, ocon))
                    {
                        cmd.Parameters.AddWithValue("@IDFactura",IDFacturacionDetalle);
                        cmd.ExecuteNonQuery();
                    }
                }
                if (comando == "" || comando == "ambos")
                {
                    using (SqlCommand cmd2 = new SqlCommand(consulta2, ocon))
                    {
                        cmd2.Parameters.AddWithValue("@IDFactura", IDFacturacionDetalle);
                        cmd2.ExecuteNonQuery();
                    }
                }
                ocon.Close();
            }
        }


        public void actualizarFactura(string IDFactura, string total, string subtotal, string itbis,string transporte, string descuento,string descripcionModificacion)
        {
            string consulta = "update cotizaciones set total = @total, subtotal = @subtotal, itbis=@itbis, transporte=@transporte, descuento=@descuento,descripcionModificacion=@descripcionModificacion where IDFactura = @IDFactura";
            using (SqlConnection ocon = new SqlConnection(conexion1.connectionString))
            {
                ocon.Open();
                using (SqlCommand cmd = new SqlCommand(consulta, ocon))
                {
                    cmd.Parameters.AddWithValue("@IDFacturacion",IDFactura);
                    cmd.Parameters.AddWithValue("@total", Convert.ToDouble(total));
                    cmd.Parameters.AddWithValue("@subtotal", Convert.ToDouble(subtotal));
                    cmd.Parameters.AddWithValue("@itbis", Convert.ToDouble(itbis));
                    cmd.Parameters.AddWithValue("@transporte", Convert.ToDouble(transporte));
                    cmd.Parameters.AddWithValue("@descuento", Convert.ToDouble(descuento));
                    cmd.Parameters.AddWithValue("@descripcionModificacion", Convert.ToDouble(descuento));
                    cmd.ExecuteNonQuery();
                }
                ocon.Close();
            }
        }
    }
}
