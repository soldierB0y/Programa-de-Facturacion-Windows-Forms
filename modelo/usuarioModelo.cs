using Microsoft.Data.SqlClient;
using System.Data;

namespace programaFacturacion.modelo
{
    public class usuarioModelo
    {
        conexion conexion1 = new conexion();
        public DataTable cargarUsuarios()
        {
            string consulta = "select * from usuario";
            DataTable dtUsuarios = new DataTable();
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
                            dtUsuarios.Load(reader);
                        }
                    }
                }
                ocon.Close();
            }
            return dtUsuarios;
        }

        public void agregarUsuarios(string usuario, string clave, string puesto, Int64 IDEmpleado,string  descripcionModificacion)
        {
          //  MessageBox.Show("usuario modelo \n"+IDEmpleado.ToString());
            string consulta = "insert into usuario(usuario,clave,puesto,IDEmpleado,fechaCreacion,fechaModificacion,descripcionModificacion)" +
                " values(@usuario,@clave,@puesto,@IDEmpleado,@fechaCreacion,@fechaModificacion,@descripcionModificacion)";
            using (SqlConnection ocon = new SqlConnection(conexion1.connectionString))
            {
                ocon.Open();
                using (SqlCommand cmd = new SqlCommand(consulta, ocon))
                {
                    cmd.Parameters.AddWithValue("@usuario", usuario);
                    cmd.Parameters.AddWithValue("@clave", clave);
                    cmd.Parameters.AddWithValue("@puesto", puesto);
                    if (IDEmpleado > 0)
                    {
                        cmd.Parameters.AddWithValue("@IDEmpleado", IDEmpleado);
                    }
                    cmd.Parameters.AddWithValue("@fechaCreacion", DateTime.Now);
                    cmd.Parameters.AddWithValue("@fechaModificacion", DateTime.Now);
                    cmd.Parameters.AddWithValue("@descripcionModificacion", descripcionModificacion);
                    cmd.ExecuteNonQuery();
                }
                ocon.Close();
            }
        }

        public bool verificarExistenciaUsuario(Int64 IDUsuario)
        {
            string consulta = "select * from usuario where IDUsuario=@IDUsuario";
            bool valor = false;
            using (SqlConnection ocon = new SqlConnection(conexion1.connectionString))
            {
                ocon.Open();
                using (SqlCommand cmd = new SqlCommand(consulta, ocon))
                {
                    cmd.Parameters.AddWithValue("@IDUsuario", IDUsuario);
                    cmd.ExecuteNonQuery();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            valor = true;
                        }
                        else
                        {
                            valor = false;
                        }
                    }
                }


                ocon.Close();
            }
            return valor;
        }


        public bool verificarNombreUsuario(string nombreUsuario)
        { 
            bool valor= false;
            DataTable dtUsuarios = new DataTable();
            dtUsuarios = cargarUsuarios();
            if (dtUsuarios.Rows.Count > 0)
            {
                foreach (DataRow row in dtUsuarios.Rows)
                {
                    if (row[2].ToString() == nombreUsuario)
                    {
                        valor = true;
                        break;
                    }
                }
            }
            return valor;
        }


        public void eliminarUsuario(Int64 IDUsuario)
        {

            if (verificarExistenciaUsuario(IDUsuario) == true)
            {
                string consulta = "delete from usuario where IDUsuario=@IDUsuario";
                using (SqlConnection ocon = new SqlConnection(conexion1.connectionString))
                {
                    ocon.Open();
                    using (SqlCommand cmd = new SqlCommand(consulta, ocon))
                    {
                        cmd.Parameters.AddWithValue("@IDUsuario", IDUsuario);
                        cmd.ExecuteNonQuery();
                    }
                    ocon.Close();
                }
                MessageBox.Show("Eliminado exitosamente");

            }
            else
            {
                MessageBox.Show("Error al eliminar. El usuario proporcionado no existe");
            }
        }

        public void modificarUsuario(Int64 IDUsuario,Int64 IDEmpleado,string usuario, string clave,string descripcionModificacion, string puesto)
        {
            string consulta = "update usuario set IDEmpleado=@IDEmpleado,usuario=@usuario, clave=@clave,fechaModificacion= @fechaModificacion, descripcionModificacion=@descripcionModificacion,puesto=@puesto" +
                " where IDUsuario= @IDUsuario";


            if (verificarExistenciaUsuario(IDUsuario) == true)
            {
                using (SqlConnection ocon = new SqlConnection(conexion1.connectionString))
                {
                    ocon.Open();
                    using (SqlCommand cmd = new SqlCommand(consulta, ocon))
                    {
                        try
                        {
                            cmd.Parameters.AddWithValue("@IDUsuario", IDUsuario);
                            cmd.Parameters.AddWithValue("@IDEmpleado", IDEmpleado);
                            cmd.Parameters.AddWithValue("@usuario", usuario);
                            cmd.Parameters.AddWithValue("@clave", clave);
                            cmd.Parameters.AddWithValue("@descripcionModificacion", descripcionModificacion);
                            cmd.Parameters.AddWithValue("@fechaModificacion", DateTime.Now);
                            cmd.Parameters.AddWithValue("@puesto", puesto);

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Modificado exitosamente");
                        }
                        catch (Exception ex) { MessageBox.Show("Error al modificar datos del Usuario \n" + ex); }
                    }
                    ocon.Close();

                }
            }
            else
            {
                MessageBox.Show("No existe un usuario con estos datos");
            }
        }

        public DataTable buscarUsuarios(string buscador, string criterio)
        {
            DataTable dtUsuarios = new DataTable();
            try
            {

                string a = buscador;//cargamos nuestra variable 
                buscador = "";// si tiene algun contenido la variable lo vaceamos
                buscador = "%" + a + "%";//con estos signos antes y despues le decimos que no importa que contenido tenga antes
                // y que contenido tenga despues, da igual, solo buscara la palabra

                string consulta = "select * from usuario where " + criterio + " like @buscador";// la variable criterio indica que
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
                                dtUsuarios.Clear();
                                dtUsuarios.Load(reader);
                            }

                        }
                    }
                    ocon.Close();
                }
            }
            catch (Exception ex) { }
            return dtUsuarios;
        }


    }
}
