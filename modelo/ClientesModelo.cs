using Microsoft.Data.SqlClient;
using System.Data;

namespace programaFacturacion.modelo
{
    public class ClientesModelo
    {
        //variables
        //cadena de conexion 
        conexion conexion1 = new conexion();
        DataTable dtClientesModelo = new DataTable();
        //cargar clientes

        public void cambiarIDRNCporNombreRNC(SqlConnection ocon)
        {
            try
            {
                if (dtClientesModelo.Rows.Count > 0)
                {
                    for (int i = 0; i < dtClientesModelo.Rows.Count; i++)
                    {

                        using (SqlCommand cmd2 = new SqlCommand("select nombre from RNC where IDRNC=@IDRNC", ocon))
                        {
                            cmd2.Parameters.AddWithValue("@IDRNC", dtClientesModelo.Rows[i][1]);
                            cmd2.ExecuteNonQuery();
                            using (SqlDataReader reader = cmd2.ExecuteReader())
                            {
                                reader.Read();
                                var nombre = reader.GetString(0);
                                //  MessageBox.Show(nombre);
                                dtClientesModelo.Rows[i][1] = nombre;
                                // MessageBox.Show(dtClientesModelo.Rows[i][1].ToString());
                            }
                        }
                    }

                }
            }
            catch { }
        }

        public DataTable getClientes()
        {
            string consulta = "select * from Clientes";// tomar todos los clientes
            using (SqlConnection ocon = new SqlConnection(conexion1.connectionString))
            {

                ocon.Open();
                using (SqlCommand cmd = new SqlCommand(consulta, ocon))
                {
                    cmd.ExecuteNonQuery();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        dtClientesModelo.Load(reader);
                    }
                }

                //Esto es para que el RNC muestre los numeros del RNC en vez de el ID del RNC
                cambiarIDRNCporNombreRNC(ocon);

                ocon.Close();


            }
            return dtClientesModelo;
        }

        //buscador 
        public DataTable BuscadorClientesModelo(string criterio, string buscador)
        {
            try
            {

                string a = buscador;//cargamos nuestra variable 
                buscador = "";// si tiene algun contenido la variable lo vaceamos
                buscador = "%" + a + "%";//con estos signos antes y despues le decimos que no importa que contenido tenga antes
                // y que contenido tenga despues, da igual, solo buscara la palabra

                string consulta = "select * from Clientes where " + criterio + " like @buscador";// la variable criterio indica que
                // el valor que posea la columna a buscar debe ser como lo que posea el buscador, para 
                using (SqlConnection ocon = new SqlConnection(conexion1.connectionString))
                {
                    ocon.Open();
                    using (SqlCommand cmd = new SqlCommand(consulta, ocon))
                    {
                        cmd.Parameters.AddWithValue("@buscador", buscador);
                        cmd.ExecuteNonQuery();

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dtClientesModelo.Clear();
                                dtClientesModelo.Load(reader);
                            }

                        }
                    }
                    cambiarIDRNCporNombreRNC(ocon);
                    ocon.Close();
                }
            }
            catch (Exception ex) { }
            return dtClientesModelo;

        }

        //CRUD

        //agregar Clientes
        public string AgregarClientesModelo(string nombre, string sexo, Array imagen, string cedula, string empresa, string direccion, string tipoCliente, string telefono, string correo, double balance, double deuda, double limiteCredito, string fechaCreacion, string fechaModificacion, string RNC, string descripcionModificacion)
        {
            string consulta = "select * from clientes where nombreRepresentante= @nombreRepresentante";
            long IDRNC = 0;
            //RNC
            DataTable tbRNC = new DataTable();


            using (SqlConnection ocon = new SqlConnection(conexion1.connectionString))
            {
                //El primer paso es validar si existe un RNC con este nombre
                //para ello aqui tenemos nuestra consulta
                string consultaRNC = "select IDRNC from RNC where nombre=@nombre";
                //ahora hacemos un sqlcommand
                ocon.Open();

                // la primera condicion es que el RNC no sea igual a null o este vacio
                if (!string.IsNullOrEmpty(RNC))
                {
                    //capturamos el ID que posee el RNC en la base de datos
                    using (SqlCommand cmdRNCBuscar = new SqlCommand(consultaRNC, ocon))
                    {
                        cmdRNCBuscar.Parameters.AddWithValue("@nombre", RNC);
                        cmdRNCBuscar.ExecuteNonQuery();
                        using (SqlDataReader readerBuscar = cmdRNCBuscar.ExecuteReader())
                        {
                            if (readerBuscar.HasRows)
                            {
                                tbRNC.Load(readerBuscar);
                                for (int i = 0; i < tbRNC.Rows.Count; i++)
                                {
                                    IDRNC = Convert.ToInt64(tbRNC.Rows[i][0]);
                                    // MessageBox.Show(IDRNC.ToString());
                                }
                            }
                            else// si no existe lo que debemos hacer es agregarlo a la base de datos 
                            {
                                readerBuscar.Close();
                                string consultaRNC2 = "insert into RNC(nombre,fechaCreacion,fechaModificacion,descripcionModificacion) values(@nombre,@fechaCreacion,@fechaModificacion,@descripcionModificacion)";
                                using (SqlCommand cmdRNCAgregar = new SqlCommand(consultaRNC2, ocon))
                                {
                                    cmdRNCAgregar.Parameters.AddWithValue("@nombre", RNC);
                                    cmdRNCAgregar.Parameters.AddWithValue("@fechaCreacion", DateTime.Now);
                                    cmdRNCAgregar.Parameters.AddWithValue("@fechaModificacion", DateTime.Now);
                                    cmdRNCAgregar.Parameters.AddWithValue("descripcionModificacion", descripcionModificacion);
                                    cmdRNCAgregar.ExecuteNonQuery();
                                }

                                //ahora lo que necesitamos es darle el ID del RNC nuevo creado
                                using (SqlCommand cmdRNCBuscar2 = new SqlCommand("select IDRNC from RNC where nombre=@nombre", ocon))
                                {
                                    tbRNC.Clear();
                                    cmdRNCBuscar2.Parameters.AddWithValue("@nombre", RNC);
                                    cmdRNCBuscar2.ExecuteNonQuery();
                                    using (SqlDataReader readerBuscar2 = cmdRNCBuscar2.ExecuteReader())
                                    {
                                        if (readerBuscar2.HasRows)
                                        {
                                            tbRNC.Load(readerBuscar2);
                                            for (int i = 0; i < tbRNC.Rows.Count; i++)
                                            {
                                                IDRNC = Convert.ToInt64(tbRNC.Rows[i][0]);
                                                //  MessageBox.Show(IDRNC.ToString());
                                            }
                                        }

                                    }
                                }
                            }

                        }

                    }
                }



                using (SqlCommand cmd = new SqlCommand(consulta, ocon))
                {
                    cmd.Parameters.AddWithValue("@nombreRepresentante", nombre);
                    cmd.ExecuteNonQuery();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if ((reader.HasRows))
                        {
                            return "ya existe un cliente con este nombre";
                        }
                        else
                        {
                            string consulta2;
                            //la siguiente condicion en esta consulta es para que no haya errores
                            // a la hora de modificar datos en la base de datos puesto que si no existe la imagen 
                            //no debe solicitarla a la variable puesto que no existe
                            if (!string.IsNullOrEmpty(RNC))
                            {
                                //    MessageBox.Show("RNC no es null");
                                if (imagen != null)
                                {
                                    consulta2 = "insert into Clientes(nombreRepresentante,sexo,imagen,cedula,empresa,direccion,tipoCliente,telefono,correo,balance,deuda,limiteCredito,fechaCreacion,fechaModificacion,IDRNC,descripcionModificacion)" +
                          "\r\nvalues(@nombreRepresentante,@sexo,@imagen,@cedula,@empresa,@direccion,@tipoCliente,@telefono,@correo,@balance,@deuda,@limiteCredito,@fechaCreacion,@fechaModificacion,@RNC,@descripcionModificacion)";
                                }
                                else
                                {
                                    consulta2 = "insert into Clientes(nombreRepresentante,sexo,cedula,empresa,direccion,tipoCliente,telefono,correo,balance,deuda,limiteCredito,fechaCreacion,fechaModificacion,IDRNC,descripcionModificacion)" +
                           "\r\nvalues(@nombreRepresentante,@sexo,@cedula,@empresa,@direccion,@tipoCliente,@telefono,@correo,@balance,@deuda,@limiteCredito,@fechaCreacion,@fechaModificacion,@RNC,@descripcionModificacion)";
                                }
                            }
                            else
                            {
                                if (imagen != null)
                                {
                                    consulta2 = "insert into Clientes(nombreRepresentante,sexo,imagen,cedula,empresa,direccion,tipoCliente,telefono,correo,balance,deuda,limiteCredito,fechaCreacion,fechaModificacion,descripcionModificacion)" +
                          "\r\nvalues(@nombreRepresentante,@sexo,@imagen,@cedula,@empresa,@direccion,@tipoCliente,@telefono,@correo,@balance,@deuda,@limiteCredito,@fechaCreacion,@fechaModificacion,@descripcionModificacion)";
                                }
                                else
                                {
                                    //   MessageBox.Show("imagen  es null");
                                    consulta2 = "insert into Clientes(nombreRepresentante,sexo,cedula,empresa,direccion,tipoCliente,telefono,correo,balance,deuda,limiteCredito,fechaCreacion,fechaModificacion,descripcionModificacion)" +
                           "\r\nvalues(@nombreRepresentante,@sexo,@cedula,@empresa,@direccion,@tipoCliente,@telefono,@correo,@balance,@deuda,@limiteCredito,@fechaCreacion,@fechaModificacion,@descripcionModificacion)";
                                }
                            }
                            // Cerrar el DataReader antes de ejecutar el siguiente comando
                            reader.Close();

                            using (SqlCommand cmd3 = new SqlCommand(consulta2, ocon))
                            {
                                cmd3.Parameters.AddWithValue("@nombreRepresentante", nombre);
                                cmd3.Parameters.AddWithValue("@sexo", sexo);
                                //la siguiente condicion en este parametro es para que no haya errores
                                // a la hora de modificar datos en la base de datos puesto que si no existe la imagen 
                                //no debe solicitarla a la variable puesto que no existe
                                if (imagen != null)
                                {
                                    cmd3.Parameters.AddWithValue("@imagen", imagen);
                                }
                                cmd3.Parameters.AddWithValue("@cedula", cedula);
                                cmd3.Parameters.AddWithValue("@empresa", empresa);
                                cmd3.Parameters.AddWithValue("@direccion", direccion);
                                cmd3.Parameters.AddWithValue("@tipoCliente", tipoCliente);
                                cmd3.Parameters.AddWithValue("@telefono", telefono);
                                cmd3.Parameters.AddWithValue("@correo", correo);
                                cmd3.Parameters.AddWithValue("@balance", balance);
                                cmd3.Parameters.AddWithValue("descripcionModificacion", descripcionModificacion);
                                cmd3.Parameters.AddWithValue("@deuda", deuda);
                                cmd3.Parameters.AddWithValue("@limiteCredito", limiteCredito);
                                cmd3.Parameters.AddWithValue("@fechaCreacion", Convert.ToDateTime(fechaCreacion));
                                cmd3.Parameters.AddWithValue("@fechaModificacion", Convert.ToDateTime(fechaModificacion));
                                //necesitamos capturar el IDRNC del RNC brindado para insertarlo en la tabla Clientes
                                //primeramente creamos nuestra consulta SQL
                                if (!string.IsNullOrEmpty(RNC))// Si el RNC no es un campo vacio
                                {


                                    cmd3.Parameters.AddWithValue("@RNC", IDRNC);
                                }
                                cmd3.ExecuteNonQuery();
                            }

                            return "Agregado Exitosamente!!!";
                        }
                    }

                }

                ocon.Close();
            }
        }


        //modificar Clientes
        public string ModificarClientesModelo(string nombre, string sexo, Array imagen, string cedula, string empresa, string direccion, string tipoCliente, string telefono, string correo, double balance, double deuda, double limiteCredito, string fechaModificacion, string RNC, string descripcionModificacion)
        {           //el segundo paso es validar que el cliente exista en la base de datos nuevamente
            //par ello primero creamos nuestra consulta
            //datatable donde vamos a almacenar la informacion
            DataTable dtModificarClientes = new DataTable();
            //variable donde se almacenara
            string valorClienteCapturadoNombre = "";
            string consulta = "select nombreRepresentante from clientes where nombreRepresentante=@nombreRepresentante";
            DataTable tbRNC = new DataTable();
            long IDRNC = 0;
            using (SqlConnection ocon = new SqlConnection(conexion1.connectionString))
            {
                //El primer paso es validar si existe un RNC con este nombre
                //para ello aqui tenemos nuestra consulta
                string consultaRNC = "select IDRNC from RNC where nombre=@nombre";
                //ahora hacemos un sqlcommand
                ocon.Open();

                // la primera condicion es que el RNC no sea igual a null o este vacio
                if (!string.IsNullOrEmpty(RNC))
                {
                    //capturamos el ID que posee el RNC en la base de datos
                    using (SqlCommand cmdRNCBuscar = new SqlCommand(consultaRNC, ocon))
                    {
                        cmdRNCBuscar.Parameters.AddWithValue("@nombre", RNC);
                        cmdRNCBuscar.ExecuteNonQuery();
                        using (SqlDataReader readerBuscar = cmdRNCBuscar.ExecuteReader())
                        {
                            if (readerBuscar.HasRows)
                            {
                                tbRNC.Load(readerBuscar);
                                for (int i = 0; i < tbRNC.Rows.Count; i++)
                                {
                                    IDRNC = Convert.ToInt64(tbRNC.Rows[i][0]);
                                    // MessageBox.Show(IDRNC.ToString());
                                }
                            }
                            else// si no existe lo que debemos hacer es agregarlo a la base de datos 
                            {
                                readerBuscar.Close();
                                string consultaRNC2 = "insert into RNC(nombre,descripcionModificacion) values(@nombre,@descripcionModificacion)";
                                using (SqlCommand cmdRNCAgregar = new SqlCommand(consultaRNC2, ocon))
                                {
                                    cmdRNCAgregar.Parameters.AddWithValue("@nombre", RNC);
                                    cmdRNCAgregar.Parameters.AddWithValue("@descripcionModificacion", descripcionModificacion);
                                    cmdRNCAgregar.ExecuteNonQuery();
                                }

                                //ahora lo que necesitamos es darle el ID del RNC nuevo creado
                                using (SqlCommand cmdRNCBuscar2 = new SqlCommand("select IDRNC from RNC where nombre=@nombre", ocon))
                                {
                                    tbRNC.Clear();
                                    cmdRNCBuscar2.Parameters.AddWithValue("@nombre", RNC);
                                    cmdRNCBuscar2.ExecuteNonQuery();
                                    using (SqlDataReader readerBuscar2 = cmdRNCBuscar2.ExecuteReader())
                                    {
                                        if (readerBuscar2.HasRows)
                                        {
                                            tbRNC.Load(readerBuscar2);
                                            for (int i = 0; i < tbRNC.Rows.Count; i++)
                                            {
                                                IDRNC = Convert.ToInt64(tbRNC.Rows[i][0]);
                                                //  MessageBox.Show(IDRNC.ToString());
                                            }
                                        }

                                    }
                                }
                            }

                        }

                    }
                }




                // ejecutamos nuestro comando y capturamos el resultado
                using (SqlCommand cmd = new SqlCommand(consulta, ocon))
                {
                    cmd.Parameters.AddWithValue("nombreRepresentante", nombre);
                    cmd.ExecuteNonQuery();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            dtModificarClientes.Load(reader);
                            for (int i = 0; i < dtModificarClientes.Rows.Count; i++)
                            {
                                valorClienteCapturadoNombre = dtModificarClientes.Rows[i][0].ToString();

                            }
                        }
                    }
                    if (string.IsNullOrEmpty(valorClienteCapturadoNombre))
                    {
                        //aqui termina el codigo del modificador si no existe un cliente con el nombre 
                        //especificado
                        return "No existe un cliente con este nombre";
                    }
                    //en caso de que si exista un cliente con el nombre especificado pues continuara con la modificacion
                    else
                    {

                        string consulta2;
                        //la siguiente condicion en esta consulta es para que no haya errores
                        // a la hora de modificar datos en la base de datos puesto que si no existe la imagen 
                        //no debe solicitarla a la variable puesto que no existe. Lo mismo con el RNC
                        if (!string.IsNullOrEmpty(RNC))
                        {
                            //    MessageBox.Show("RNC no es null");
                            if (imagen != null)
                            {
                                //consulta2 = "update Articulos set nombreArticulo= @nombre,codigo=@codigo,imagen=@imagen,descripcion=@descripcion, precioCompra=@precioCompra, precioVenta=@precioVenta,precioMinimo=@precioMinimo,precioModificable=@precioModificable,estado=@estado,facturarSinInventario=@facturarSinInventario,inventario=@inventario,IDMarca=@IDMarca, IDProovedor=@IDProovedor where codigo= @codigo";

                                consulta2 = "update  Clientes set nombreRepresentante=@nombreRepresentante,sexo=@sexo,imagen=@imagen,cedula=@cedula,empresa=@empresa,direccion=@direccion,tipoCliente=@tipoCliente,telefono=@telefono,correo=@correo,balance=@balance,deuda=@deuda,limiteCredito=@limiteCredito,fechaModificacion=@fechaModificacion,RNC=@IDRNC, descripcionModificacion=@descripcionModificacion where nombreRepresentante=@nombreRepresentante";
                            }
                            else
                            {
                                consulta2 = "update  Clientes set nombreRepresentante = @nombreRepresentante,sexo = @sexo,cedula = @cedula,empresa = @empresa,direccion = @direccion,tipoCliente = @tipoCliente,telefono = @telefono,correo = @correo,balance = @balance,deuda = @deuda,limiteCredito = @limiteCredito,fechaModificacion = @fechaModificacion,IDRNC = @RNC, descripcionModificacion=@descripcionModificacion where nombreRepresentante=@nombreRepresentante";


                            }
                        }
                        else
                        {
                            if (imagen != null)
                            {
                                consulta2 = "update  Clientes set nombreRepresentante = @nombreRepresentante,sexo = @sexo,imagen=@imagen,cedula = @cedula,empresa = @empresa,direccion = @direccion,tipoCliente = @tipoCliente,telefono = @telefono,correo = @correo,balance = @balance,deuda = @deuda,limiteCredito = @limiteCredito,fechaModificacion = @fechaModificacion,descripcionModificacion=@descripcionModificacion where nombreRepresentante=@nombreRepresentante";

                            }
                            else
                            {
                                consulta2 = "update  Clientes set nombreRepresentante = @nombreRepresentante,sexo = @sexo,cedula = @cedula,empresa = @empresa,direccion = @direccion,tipoCliente = @tipoCliente,telefono = @telefono,correo = @correo,balance = @balance,deuda = @deuda,limiteCredito = @limiteCredito,fechaModificacion = @fechaModificacion,descripcionModificacion=@descripcionModificacion where nombreRepresentante=@nombreRepresentante";
                            }
                        }

                        using (SqlCommand cmd3 = new SqlCommand(consulta2, ocon))
                        {
                            cmd3.Parameters.AddWithValue("@nombreRepresentante", nombre);
                            cmd3.Parameters.AddWithValue("@sexo", sexo);
                            //la siguiente condicion en este parametro es para que no haya errores
                            // a la hora de modificar datos en la base de datos puesto que si no existe la imagen 
                            //no debe solicitarla a la variable puesto que no existe
                            if (imagen != null)
                            {
                                cmd3.Parameters.AddWithValue("@imagen", imagen);
                            }
                            cmd3.Parameters.AddWithValue("@cedula", cedula);
                            cmd3.Parameters.AddWithValue("@empresa", empresa);
                            cmd3.Parameters.AddWithValue("@direccion", direccion);
                            cmd3.Parameters.AddWithValue("@tipoCliente", tipoCliente);
                            cmd3.Parameters.AddWithValue("@telefono", telefono);
                            cmd3.Parameters.AddWithValue("@correo", correo);
                            cmd3.Parameters.AddWithValue("@balance", balance);
                            cmd3.Parameters.AddWithValue("@deuda", deuda);
                            cmd3.Parameters.AddWithValue("@descripcionModificacion", descripcionModificacion);
                            cmd3.Parameters.AddWithValue("@limiteCredito", limiteCredito);
                            cmd3.Parameters.AddWithValue("@fechaModificacion", Convert.ToDateTime(fechaModificacion));
                            //necesitamos capturar el IDRNC del RNC brindado para insertarlo en la tabla Clientes
                            //primeramente creamos nuestra consulta SQL
                            if (!string.IsNullOrEmpty(RNC))// Si el RNC no es un campo vacio
                            {


                                cmd3.Parameters.AddWithValue("@RNC", IDRNC);
                            }
                            cmd3.ExecuteNonQuery();
                        }

                        return "Modificado Exitosamente!!!";



                    }


                }
                ocon.Close();
            }



        }
        //eliminar clientes
        public string EliminarClientesModelo(string nombreRepresentante)
        {
            string consulta2 = "select nombreRepresentante from Clientes where nombreRepresentante=@nombreRepresentante";
            DataTable dtCliente = new DataTable();
            string valorNombreCliente = null;
            using (SqlConnection ocon = new SqlConnection(conexion1.connectionString))
            {
                ocon.Open();

                using (SqlCommand cmd2 = new SqlCommand(consulta2, ocon))
                {
                    cmd2.Parameters.AddWithValue("@nombreRepresentante", nombreRepresentante);
                    cmd2.ExecuteNonQuery();
                    using (SqlDataReader reader = cmd2.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            dtCliente.Load(reader);
                            for (int i = 0; i < dtCliente.Rows.Count; i++)
                            {
                                valorNombreCliente = dtCliente.Rows[i][0].ToString();
                            }
                        }
                    }
                }
                //Primero debemos verificar que el registro exista

                //Esta es la parte en donde eliminamos el registro si es que existe
                //aqui tenemos el query a ejecutar
                if (valorNombreCliente != null)
                {
                    try
                    {
                        string consulta = "delete from clientes where nombreRepresentante=@nombreRepresentante";

                        //hacemos la gestion para ejecutar el query 


                        using (SqlCommand cmd = new SqlCommand(consulta, ocon))
                        {
                            cmd.Parameters.AddWithValue("@nombreRepresentante", nombreRepresentante);
                            cmd.ExecuteNonQuery();
                        }
                        ocon.Close();



                        return "¡Se ha eliminado exitosamente!";
                    }
                    catch (Exception ex) { return "Error al eliminar Cliente \n" + ex; }
                }
                else
                {
                    return "No existe ningun cliente para eliminar con este nombre";
                }
            }
        }
    }
}
