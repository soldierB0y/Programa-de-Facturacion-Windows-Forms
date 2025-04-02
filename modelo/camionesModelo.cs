using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programaFacturacion.modelo
{
    public class camionesModelo
    {
        conexion conexion1 = new conexion();
        public void agregarCamiones(string modelo,string matricula,string color,string marca,double metraje,DateTime fechaAdquisicion,double numeroViajes,bool activo,DateTime fechaCreacion, DateTime fechaModificacion, string descripcionModificacion,string propietario, Array imagenParaEnviar)
        {
            string consulta = "";
            if (imagenParaEnviar == null)
            {
                consulta = "insert into camion(modelo, placa, color, marca, metraje, fechaAdquisicion, numeroViaje, activo, fechaCreacion, fechaModificacion, descripcionModificacion,propietario)" +
" values(@modelo,@matricula,@color,@marca,@metraje,@fechaAdquisicion,@numeroViaje,@activo, @fechaCreacion,@fechaModificacion,@descripcionModificacion,@propietario)";





            }
            else
            {
                consulta = "insert into camion(modelo, placa, color, marca, metraje, fechaAdquisicion, numeroViaje, activo, fechaCreacion, fechaModificacion, descripcionModificacion,propietario,imagen)" +
                    " values(@modelo,@matricula,@color,@marca,@metraje,@fechaAdquisicion,@numeroViaje,@activo, @fechaCreacion,@fechaModificacion,@descripcionModificacion,@propietario,@imagen)";

            }

            using (SqlConnection ocon = new SqlConnection(conexion1.connectionString))
            { 
                ocon.Open();
                using (SqlCommand cmd = new SqlCommand(consulta, ocon))
                {
                    cmd.Parameters.AddWithValue("@modelo",modelo);
                    cmd.Parameters.AddWithValue("@matricula", matricula);
                    cmd.Parameters.AddWithValue("@color", color);
                    cmd.Parameters.AddWithValue("@marca", marca);
                    cmd.Parameters.AddWithValue("@metraje", metraje);
                    cmd.Parameters.AddWithValue("@fechaAdquisicion", fechaAdquisicion);
                    cmd.Parameters.AddWithValue("@numeroViaje", numeroViajes);
                    cmd.Parameters.AddWithValue("@activo", activo);
                    cmd.Parameters.AddWithValue("@fechaCreacion", DateTime.Now);
                    cmd.Parameters.AddWithValue("@fechaModificacion", DateTime.Now);
                    cmd.Parameters.AddWithValue("@descripcionModificacion", descripcionModificacion);
                    cmd.Parameters.AddWithValue("@propietario", propietario);
                    if (imagenParaEnviar != null)
                    {
                        cmd.Parameters.AddWithValue("@imagen", imagenParaEnviar);
                    }
                    cmd.ExecuteNonQuery();
                }
                    ocon.Close();
            }
        }

        public DataTable cargarCamiones()
        {
            string consulta = "select * from camion";
            DataTable dtCamiones = new DataTable();
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
                            dtCamiones.Load(reader);
                        }
                    }
                }
                ocon.Close();
            }
            return dtCamiones;
        }

        public DataTable buscarCamiones(string buscador, string criterio)
        {
            DataTable dtCamiones= new DataTable();
            try
            {

                string a = buscador;//cargamos nuestra variable 
                buscador = "";// si tiene algun contenido la variable lo vaceamos
                buscador = "%" + a + "%";//con estos signos antes y despues le decimos que no importa que contenido tenga antes
                // y que contenido tenga despues, da igual, solo buscara la palabra

                string consulta = "select * from camion where " + criterio + " like @buscador";// la variable criterio indica que
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
                                dtCamiones.Clear();
                                dtCamiones.Load(reader);
                            }

                        }
                    }
                    ocon.Close();
                }
            }
            catch (Exception ex) { }
            return dtCamiones;
        }

        public bool verificarExistenciaCamion(Int64 IDCamion)
        {
            string consulta = "select * from Camion where IDCamion=@IDCamion";
            bool valor = false;
            using (SqlConnection ocon = new SqlConnection(conexion1.connectionString))
            {
                ocon.Open();
                using (SqlCommand cmd = new SqlCommand(consulta, ocon))
                {
                    cmd.Parameters.AddWithValue("@IDCamion", IDCamion);
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

        public void eliminarCamion(Int64 IDCamion)
        {

            if (verificarExistenciaCamion(IDCamion) == true)
            {
                string consulta = "delete from Camion where IDCamion=@IDCamion";
                using (SqlConnection ocon = new SqlConnection(conexion1.connectionString))
                {
                    ocon.Open();
                    using (SqlCommand cmd = new SqlCommand(consulta, ocon))
                    {
                        cmd.Parameters.AddWithValue("@IDCamion", IDCamion);
                        cmd.ExecuteNonQuery();
                    }
                    ocon.Close();
                }
                MessageBox.Show("Eliminado exitosamente");

            }
            else
            {
                MessageBox.Show("Error al eliminar. El camion proporcionado no existe");
            }
        }

        public void modificarCamion(Int64 IDCamion, string modelo, string matricula, string color, string marca, double metraje, DateTime fechaAdquisicion, bool activo, DateTime fechaModificacion, string descripcionModificacion, string propietario, Array imagenParaEnviar)
        {
            string consulta = "";

            if (imagenParaEnviar == null)
            {
                consulta = "update camion set modelo=@modelo, placa=@matricula, color=@color, marca=@marca, metraje=@metraje, fechaAdquisicion=@fechaAdquisicion," +
                           " activo=@activo, fechaModificacion=@fechaModificacion, descripcionModificacion=@descripcionModificacion, " +
                           "propietario=@propietario where IDCamion=@IDCamion";
            }
            else
            {
                consulta = "update camion set modelo=@modelo, placa=@matricula, color=@color, marca=@marca, metraje=@metraje, fechaAdquisicion=@fechaAdquisicion," +
                           " activo=@activo, fechaModificacion=@fechaModificacion, descripcionModificacion=@descripcionModificacion, " +
                           "propietario=@propietario, imagen=@imagen where IDCamion=@IDCamion";
            }

            if (verificarExistenciaCamion(IDCamion))
            {
                using (SqlConnection ocon = new SqlConnection(conexion1.connectionString))
                {
                    ocon.Open();
                    using (SqlCommand cmd = new SqlCommand(consulta, ocon))
                    {
                        try
                        {
                            cmd.Parameters.AddWithValue("@modelo", modelo);
                            cmd.Parameters.AddWithValue("@matricula", matricula);
                            cmd.Parameters.AddWithValue("@color", color);
                            cmd.Parameters.AddWithValue("@marca", marca);
                            cmd.Parameters.AddWithValue("@metraje", metraje);
                            cmd.Parameters.AddWithValue("@fechaAdquisicion", fechaAdquisicion);
                            cmd.Parameters.AddWithValue("@activo", activo);
                            cmd.Parameters.AddWithValue("@fechaModificacion", fechaModificacion);
                            cmd.Parameters.AddWithValue("@descripcionModificacion", descripcionModificacion);
                            cmd.Parameters.AddWithValue("@IDCamion", IDCamion);
                            cmd.Parameters.AddWithValue("@propietario", propietario);

                            if (imagenParaEnviar != null)
                            {
                                cmd.Parameters.AddWithValue("@imagen", imagenParaEnviar);
                            }

                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Modificado exitosamente");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al modificar datos del camion: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No existe un Camion con estos datos");
            }
        }

    }
}
