using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programaFacturacion.modelo
{
    public  class CombustibleModelo
    {
        conexion conexion1 = new conexion();
        public void agregarCombustible(Int64 IDChofer, string nombreChofer, Int64 IDCamion, double gasto, double galones, DateTime fechaCompra, string  notas, string descripcionModificacion, string nombreCamion)
        {
            string consulta = "insert into combustible(IDChofer, nombreChofer, IDCamion,gasto,galones, fechaCompra, notas,descripcionModificacion,fechaCreacion,nombreCamion)" +
                " values(@IDChofer,@nombreChofer,@IDCamion,@gasto,@galones,@fechaCompra,@notas,@descripcionModificacion,@fechaCreacion,@nombreCamion )";
            using (SqlConnection ocon = new SqlConnection(conexion1.connectionString))
            {
                ocon.Open();
                using (SqlCommand cmd = new SqlCommand(consulta, ocon))
                {
                    cmd.Parameters.AddWithValue("@IDChofer", IDChofer);
                    cmd.Parameters.AddWithValue("@nombreChofer", nombreChofer);
                    cmd.Parameters.AddWithValue("@IDCamion", IDCamion);
                    cmd.Parameters.AddWithValue("@gasto", gasto);
                    cmd.Parameters.AddWithValue("@nombreCamion",nombreCamion);
                    cmd.Parameters.AddWithValue("@galones", galones);
                    cmd.Parameters.AddWithValue("@fechaCompra", fechaCompra);
                    cmd.Parameters.AddWithValue("@notas", notas);
                    cmd.Parameters.AddWithValue("@descripcionModificacion", descripcionModificacion);
                    cmd.Parameters.AddWithValue("@fechaCreacion", DateTime.Now);
                    cmd.ExecuteNonQuery();
                }
                ocon.Close();
            }
        }


        public DataTable cargarCombustible()
        {
            string consulta = "select * from combustible";
            DataTable dtCombustible = new DataTable();
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
                            dtCombustible.Load(reader);
                        }
                    }
                }
                ocon.Close();
            }
            return dtCombustible;
        }

        public DataTable buscarCombustible(string buscador, string criterio)
        {
            DataTable dtCombustible = new DataTable();
            try
            {

                string a = buscador;//cargamos nuestra variable 
                buscador = "";// si tiene algun contenido la variable lo vaceamos
                buscador = "%" + a + "%";//con estos signos antes y despues le decimos que no importa que contenido tenga antes
                // y que contenido tenga despues, da igual, solo buscara la palabra

                string consulta = "select * from combustible where " + criterio + " like @buscador";// la variable criterio indica que
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
                                dtCombustible.Clear();
                                dtCombustible.Load(reader);
                            }

                        }
                    }
                    ocon.Close();
                }
            }
            catch (Exception ex) { }
            return dtCombustible;
        }

        public string eliminarCombustible(Int64 IDCombustible)
        {
            
            string consulta = "delete  from combustible where IDCombustible=@IDCombustible";
            try
            {
                using (SqlConnection ocon = new SqlConnection(conexion1.connectionString))
                {
                    ocon.Open();
                    using (SqlCommand cmd = new SqlCommand(consulta, ocon))
                    {
                        cmd.Parameters.AddWithValue("@IDCombustible", IDCombustible);
                        cmd.ExecuteNonQuery();

                    }

                    ocon.Close();
                    return "se ha eliminado exitosamente el registro de combustible";
                }
            }
            catch(Exception ex){

                return "no se pudo eliminar el registro de combustible."+"\n"+ex.Message;
            
            }

        }

    }
}
