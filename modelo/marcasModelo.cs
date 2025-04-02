
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace programaFacturacion.modelo
{
    public class marcasModelo
    {
        conexion conexion1 = new conexion();
        public DataTable cargarMarcas()
        {
            string consulta = "select * from articuloMarca";
            DataTable dtMarcas = new DataTable();
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
                            dtMarcas.Load(reader);
                        }
                    }
                }
                ocon.Close();
            }
            return dtMarcas;
        }

        public DataTable buscarMarcas(string buscador, string criterio)
        {
            DataTable dtMarcas = new DataTable();
            try
            {

                string a = buscador;//cargamos nuestra variable 
                buscador = "";// si tiene algun contenido la variable lo vaceamos
                buscador = "%" + a + "%";//con estos signos antes y despues le decimos que no importa que contenido tenga antes
                // y que contenido tenga despues, da igual, solo buscara la palabra

                string consulta = "select * from articuloMarca where " + criterio + " like @buscador";// la variable criterio indica que
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
                                dtMarcas.Clear();
                                dtMarcas.Load(reader);
                            }

                        }
                    }
                    ocon.Close();
                }
            }
            catch (Exception ex) { }
            return dtMarcas;
        }


        public void agregarMarcas(string nombre, string descripcion, string otrosDatos,string descripcionModificacion)
        {
            string consulta = "insert into articuloMarca(nombreMarca,descripcion,otrosDatos,fechaCreacion,fechaModificacion,descripcionModificacion)" +
                " values(@nombreMarca,@descripcion,@otrosDatos,@fechaCreacion,@fechaModificacion,@descripcionModificacion)";
            using (SqlConnection ocon = new SqlConnection(conexion1.connectionString))
            {
                ocon.Open();
                using (SqlCommand cmd = new SqlCommand(consulta, ocon))
                {
                    cmd.Parameters.AddWithValue("@nombreMarca", nombre);
                    cmd.Parameters.AddWithValue("@descripcion", descripcion);
                    cmd.Parameters.AddWithValue("@otrosDatos", otrosDatos);
                    cmd.Parameters.AddWithValue("@fechaCreacion", DateTime.Now);
                    cmd.Parameters.AddWithValue("@fechaModificacion", DateTime.Now);
                    cmd.Parameters.AddWithValue("@descripcionModificacion", descripcionModificacion);
                    cmd.ExecuteNonQuery();
                }
                ocon.Close();
            }
        }


        public List<string> cargarNombreMarcas()
        {
            DataTable dtMarcas = cargarMarcas();
            List<string> nombreMarcas= new List<string>();
            if (dtMarcas.Rows.Count > 0)
            {
                foreach (DataRow row in dtMarcas.Rows)
                {
                    nombreMarcas.Add(row[1].ToString());
                }
            }
            return nombreMarcas;
        }


        public bool verificarExistenciaMarca(Int64 IDMarca)
        {
            string consulta = "select * from articuloMarca where IDArticuloMarca=@IDMarca";
            bool valor = false;
            using (SqlConnection ocon = new SqlConnection(conexion1.connectionString))
            {
                ocon.Open();
                using (SqlCommand cmd = new SqlCommand(consulta, ocon))
                {
                    cmd.Parameters.AddWithValue("@IDMarca", IDMarca);
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

        public void eliminarMarca(Int64 IDMarca)
        {
            try
            {
                if (verificarExistenciaMarca(IDMarca) == true)
                {
                    string consulta = "delete from articuloMarca where IDArticuloMarca=@IDMarca";
                    using (SqlConnection ocon = new SqlConnection(conexion1.connectionString))
                    {
                        ocon.Open();
                        using (SqlCommand cmd = new SqlCommand(consulta, ocon))
                        {
                            cmd.Parameters.AddWithValue("@IDMarca", IDMarca);
                            cmd.ExecuteNonQuery();
                        }
                        ocon.Close();
                    }
                    MessageBox.Show("Eliminado exitosamente");

                }
                else
                {
                    MessageBox.Show("Error al eliminar. La marca proporcionado no existe");
                }
            }
            catch
            {
                MessageBox.Show("Error. Tienes articulos registrados que hacen referencia a esta Marca");
            }
        }


        public void modificarMarca(Int64 IDMarca,string nombre, string descripcion, string otrosDatos,string  descripcionModificacion)
        {
            string consulta = "update articuloMarca set nombreMarca=@nombreMarca, descripcion=@descripcion,otrosDatos=@otrosDatos,fechaModificacion=@fechaModificacion,descripcionModificacion=@descripcionModificacion where IDArticuloMarca= @IDMarca";


            if (verificarExistenciaMarca(IDMarca) == true)
            {
                using (SqlConnection ocon = new SqlConnection(conexion1.connectionString))
                {
                    ocon.Open();
                    using (SqlCommand cmd = new SqlCommand(consulta, ocon))
                    {
                        try
                        {
                            cmd.Parameters.AddWithValue("@IDMarca", IDMarca);
                            cmd.Parameters.AddWithValue("@nombreMarca", nombre);
                            cmd.Parameters.AddWithValue("@descripcion", descripcion);
                            cmd.Parameters.AddWithValue("@otrosDatos", otrosDatos);
                            cmd.Parameters.AddWithValue("@fechaModificacion", DateTime.Now);
                            cmd.Parameters.AddWithValue("@descripcionModificacion", descripcionModificacion);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Modificado exitosamente");
                        }
                        catch (Exception ex) { MessageBox.Show("Error al modificar datos de la Marca" + ex); }
                    }
                    ocon.Close();

                }
            }
            else
            {
                MessageBox.Show("No existe una marca con los datos provistos");
            }
        }





    }
}
