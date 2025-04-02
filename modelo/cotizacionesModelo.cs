using Microsoft.Data.SqlClient;
using System.Data;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
namespace programaFacturacion.modelo
{
    public class cotizacionesModelo
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
                           // MessageBox.Show(dtArticulos.Rows.Count.ToString());
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


        public string cargarCotizacion(DateTime datetime, Int64 IDCLiente)
        {
            Int64 IDCotizacion = 0;
            string consulta = "select * from cotizaciones where fechaCreacion= @fechaCreacion and IDCliente= @IDCliente";
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
                            IDCotizacion = Convert.ToInt64(dtReader.Rows[0][0]);
                        }
                    }
                }
                ocon.Close();
            }

            return IDCotizacion.ToString();
        }


        public DataTable cargarCotizaciones()
        {
            string consulta = "select * from cotizaciones";
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
                            dtCotizaciones.Clear();
                            dtCotizaciones.Load(reader);
                        }
                    }
                }
                ocon.Close();
            }

            return dtCotizaciones;
        }

        public DataTable buscarCotizaciones(Int64 IDCliente)
        {
            string consulta = "select * from cotizaciones where";
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

                            dtCotizaciones.Load(reader);
                        }
                    }
                }
                ocon.Close();
            }

            return dtCotizaciones;
        }


        public void enviarCotizacion(DataTable cotizacion,string descripcionModificacion)
        {
            string consulta = "insert into cotizaciones(IDEmpleado,IDCliente,IDNCF,fechaCreacion,fechaModificacion,subtotal,ITBIS,transporte,descuento,total,guardado,descripcionModificacion)" +
                "values(@IDEmpleado,@IDCliente,@IDNCF,@fechaCreacion,@fechaModificacion,@subtotal,@ITBIS,@transporte,@descuento,@total,@guardado,@descripcionModificacion)";
            using (SqlConnection ocon = new SqlConnection(conexion1.connectionString))
            {
                ocon.Open();
                using (SqlCommand cmd = new SqlCommand(consulta, ocon))
                {
                    cmd.Parameters.AddWithValue("@IDempleado", Convert.ToInt64(cotizacion.Rows[0][0]));
                    cmd.Parameters.AddWithValue("@IDCliente", Convert.ToInt64(cotizacion.Rows[0][1]));
                    cmd.Parameters.AddWithValue("@IDNCF", Convert.ToInt64(cotizacion.Rows[0][2]));
                    cmd.Parameters.AddWithValue("@fechaCreacion", cotizacion.Rows[0][3]);
                    cmd.Parameters.AddWithValue("@fechaModificacion", cotizacion.Rows[0][4]);
                    cmd.Parameters.AddWithValue("@subtotal", Convert.ToDouble(cotizacion.Rows[0][5]));
                    cmd.Parameters.AddWithValue("@ITBIS", Convert.ToDouble(cotizacion.Rows[0][6]));
                    cmd.Parameters.AddWithValue("@transporte", Convert.ToDouble(cotizacion.Rows[0][7]));
                    cmd.Parameters.AddWithValue("@descuento", Convert.ToDouble(cotizacion.Rows[0][8]));
                    cmd.Parameters.AddWithValue("@total", Convert.ToDouble(cotizacion.Rows[0][9]));
                    cmd.Parameters.AddWithValue("@guardado", Convert.ToBoolean(cotizacion.Rows[0][10]));
                    cmd.Parameters.AddWithValue("@descripcionModificacion",descripcionModificacion);
                    cmd.ExecuteNonQuery();
                    // cmd.Parameters.AddWithValue("@IDCliente");
                    //  cmd.Parameters.AddWithValue("");
                }
                ocon.Close();
            }
        }

        public void enviarCotizacionDetalle(DataTable facturacionDetalle,string descripcionModificacion)
        {
            string consulta = "insert into cotizacionDetalle(IDCotizacion,IDArticulo,codigo,nombre,cantidad,precioUnitario,ITBIS,subtotal,estado,guardado,descuento,Monto,fechaCreacion,fechaModificacion,descripcionModificacion)" +
                "values(@IDCotizacion,@IDArticulo,@codigo,@nombre,@cantidad,@precioUnitario,@ITBIS,@subtotal,@estado,@guardado,@descuento,@Monto,@fechaCreacion,@fechaModificacion,@descripcionModificacion)";

            using (SqlConnection ocon = new SqlConnection(conexion1.connectionString))
            {
                ocon.Open();
                foreach (DataRow row in facturacionDetalle.Rows)
                {
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand(consulta, ocon))
                        {

                            cmd.Parameters.AddWithValue("@IDCotizacion", row[0]);
                            cmd.Parameters.AddWithValue("IDArticulo", row[1]);
                            cmd.Parameters.AddWithValue("nombre", row[2]);
                            cmd.Parameters.AddWithValue("@codigo", row[3]);
                            cmd.Parameters.AddWithValue("@cantidad", row[4]);
                            cmd.Parameters.AddWithValue("@precioUnitario", row[5]);
                            cmd.Parameters.AddWithValue("@ITBIS", row[6]);
                            cmd.Parameters.AddWithValue("@subtotal", row[7]);
                            cmd.Parameters.AddWithValue("estado", 1);
                            cmd.Parameters.AddWithValue("@guardado", 1);
                            cmd.Parameters.AddWithValue("@descuento", row[8]);
                            cmd.Parameters.AddWithValue("Monto", row[9]);
                            cmd.Parameters.AddWithValue("@fechaCreacion", DateTime.Now);
                            cmd.Parameters.AddWithValue("@fechaModificacion", DateTime.Now);
                            cmd.Parameters.AddWithValue("@descripcionModificacion",descripcionModificacion );
                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch
                    { }
                }

                ocon.Close();
            }
        }

        public DataTable cargarDetalleCotizaciones(Int64 IDCotizacion)
        {
            DataTable dtDetalleCotizaciones = new DataTable();
            string consulta = "select idcotizaciondetalle, idcotizacion,nombre, idarticulo,cantidad, codigo, preciounitario, precioCompra, itbis, subtotal, estado, guardado, descuento, monto, fechaCreacion, fechaModificacion, descripcionModificacion from cotizacionDetalle where IDCotizacion= @IDCotizacion";
            using (SqlConnection ocon = new SqlConnection(conexion1.connectionString))
            {
                ocon.Open();
                using (SqlCommand cmd = new SqlCommand(consulta, ocon))
                {
                    cmd.Parameters.AddWithValue("@IDCotizacion", IDCotizacion);
                    cmd.ExecuteNonQuery();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            dtDetalleCotizaciones.Load(reader);
                        }
                    }
                }
                ocon.Close();
            }

            return dtDetalleCotizaciones;
        }
        public void modificarCotizacion()
        {

        }

        public void eliminarCotizacion(Int64 IDCotizacion, string comando)
        {
            //comando= detalle, elimina solo los detalles
            // comando= "" o comando="ambos" elimina ambos registros
            //eliminaremos la cotizacion detalle primero y luego la cotizacion
            string consulta = "delete from cotizacionDetalle where IDCotizacion= @IDCotizacion";
            string consulta2 = "delete from cotizaciones where IDCotizacion = @IDCotizacion";
            using (SqlConnection ocon = new SqlConnection(conexion1.connectionString))
            {
                ocon.Open();
                if (comando == "" || comando == "ambos" || comando == "detalle")
                {
                    using (SqlCommand cmd = new SqlCommand(consulta, ocon))
                    {
                        cmd.Parameters.AddWithValue("IDCotizacion", IDCotizacion);
                        cmd.ExecuteNonQuery();
                    }
                }
                if (comando == "" || comando == "ambos")
                {
                    using (SqlCommand cmd2 = new SqlCommand(consulta2, ocon))
                    {
                        cmd2.Parameters.AddWithValue("IDCotizacion", IDCotizacion);
                        cmd2.ExecuteNonQuery();
                    }
                }
                ocon.Close();
            }
        }


        public void actualizarCotizacion(string IDCotizacion, string total, string subtotal, string itbis,string transporte, string descuento,string descripcionModificacion)
        {
            string consulta = "update cotizaciones set total = @total, subtotal = @subtotal, itbis=@itbis, transporte=@transporte, descuento=@descuento,descripcionModificacion=@descripcionModificacion where IDCotizacion = @IDCotizacion";
            using (SqlConnection ocon = new SqlConnection(conexion1.connectionString))
            {
                ocon.Open();
                using (SqlCommand cmd = new SqlCommand(consulta, ocon))
                {
                    cmd.Parameters.AddWithValue("@IDCotizacion",Convert.ToInt64(IDCotizacion));
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
