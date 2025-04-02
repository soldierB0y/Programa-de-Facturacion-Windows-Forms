using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programaFacturacion.modelo
{
    public class proovedorModelo
    {
        conexion conexion1= new conexion();
        public DataTable cargarProovedor()
        {
            string consulta = "select * from proovedor";
            DataTable dtProovedor = new DataTable();
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
                            dtProovedor.Load(reader);
                        }
                    }
                }
                ocon.Close();
            }
            return dtProovedor;
        }

        public void agregarProovedor(string nombre,string telefono,string cedula, string correo, string empresa,string  descripcionModificacion)
        {
            string consulta = "insert into proovedor(nombreProovedor,telefono,cedulaRNC,email,fechaCreacion,fechaModificacion,descripcionModificacion,empresa)" +
                " values(@nombreProovedor,@telefono,@cedulaRNC,@email,@fechaCreacion,@fechaModificacion,@descripcionModificacion,@empresa)";
            using (SqlConnection ocon = new SqlConnection(conexion1.connectionString))
            {
                ocon.Open();
                using (SqlCommand cmd = new SqlCommand(consulta, ocon))
                {
                    cmd.Parameters.AddWithValue("@nombreProovedor", nombre);
                    cmd.Parameters.AddWithValue("@telefono", telefono);
                    cmd.Parameters.AddWithValue("@cedulaRNC", cedula);
                    cmd.Parameters.AddWithValue("@email", correo);
                    cmd.Parameters.AddWithValue("@fechaCreacion", DateTime.Now);
                    cmd.Parameters.AddWithValue("@fechaModificacion", DateTime.Now);
                    cmd.Parameters.AddWithValue("@descripcionModificacion", descripcionModificacion);
                    cmd.Parameters.AddWithValue("@empresa",empresa);

                    cmd.ExecuteNonQuery();
                }
                ocon.Close();
            }
        }

        public bool verificarExistenciaProovedor(Int64 IDProovedor)
        {
            string consulta = "select * from proovedor where IDProovedor=@IDProovedor";
            bool valor = false;
            using (SqlConnection ocon = new SqlConnection(conexion1.connectionString))
            {
                ocon.Open();
                using (SqlCommand cmd = new SqlCommand(consulta, ocon))
                {
                    cmd.Parameters.AddWithValue("@IDProovedor", IDProovedor);
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


        public void eliminarProovedor(Int64 IDProovedor)
        {

            if (verificarExistenciaProovedor(IDProovedor) == true)
            {
                try
                {
                    string consulta = "delete from proovedor where IDProovedor=@IDProovedor";
                    using (SqlConnection ocon = new SqlConnection(conexion1.connectionString))
                    {
                        ocon.Open();
                        using (SqlCommand cmd = new SqlCommand(consulta, ocon))
                        {
                            cmd.Parameters.AddWithValue("@IDProovedor", IDProovedor);
                            cmd.ExecuteNonQuery();
                        }
                        ocon.Close();
                    }
                    MessageBox.Show("Eliminado exitosamente");
                }
                catch
                {
                    MessageBox.Show("No puede eliminar este proovedor, sin antes eliminar el articulo al cual le hace referencia");
                }

            }
            else
            {
                MessageBox.Show("Error al eliminar. El proovedor proporcionado no existe");
            }
        }


        public void modificarProovedor(Int64 IDProovedor,string nombre, string telefono, string cedula, string correo, string empresa, string descripcionModificacion)
        {
            string consulta = "update proovedor set nombreProovedor=@nombreProovedor,telefono=@telefono,cedulaRNC=@cedulaRNC, email=@correo, empresa=@empresa, descripcionModificacion=@descripcionModificacion,fechaCreacion=@fechaCreacion,fechaModificacion=@fechaModificacion where IDProovedor= @IDProovedor";


            if (verificarExistenciaProovedor(IDProovedor) == true)
            {
                using (SqlConnection ocon = new SqlConnection(conexion1.connectionString))
                {
                    ocon.Open();
                    using (SqlCommand cmd = new SqlCommand(consulta, ocon))
                    {
                        try
                        {
                            cmd.Parameters.AddWithValue("@IDProovedor", IDProovedor);
                            cmd.Parameters.AddWithValue("@nombreProovedor", nombre);
                            cmd.Parameters.AddWithValue("@telefono", telefono);
                            cmd.Parameters.AddWithValue("@cedulaRNC", cedula);
                            cmd.Parameters.AddWithValue("@correo", correo);
                            cmd.Parameters.AddWithValue("@empresa", empresa);
                            cmd.Parameters.AddWithValue("@descripcionModificacion", descripcionModificacion);
                            cmd.Parameters.AddWithValue("@fechaCreacion", DateTime.Now);
                            cmd.Parameters.AddWithValue("@fechaModificacion", DateTime.Now);
                  

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Modificado exitosamente");
                        }
                        catch (Exception ex) { MessageBox.Show("Error al modificar datos del proovedor" + ex); }
                    }
                    ocon.Close();

                }
            }
            else
            {
                MessageBox.Show("No existe un proovedor con estos datos");
            }
        }

        public DataTable buscarProovedor(string buscador, string criterio)
        {
            DataTable dtProovedor = new DataTable();
            try
            {

                string a = buscador;//cargamos nuestra variable 
                buscador = "";// si tiene algun contenido la variable lo vaceamos
                buscador = "%" + a + "%";//con estos signos antes y despues le decimos que no importa que contenido tenga antes
                // y que contenido tenga despues, da igual, solo buscara la palabra

                string consulta = "select * from proovedor where " + criterio + " like @buscador";// la variable criterio indica que
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
                                dtProovedor.Clear();
                                dtProovedor.Load(reader);
                            }

                        }
                    }
                    ocon.Close();
                }
            }
            catch (Exception ex) { }
            return dtProovedor;
        }



    }
}
