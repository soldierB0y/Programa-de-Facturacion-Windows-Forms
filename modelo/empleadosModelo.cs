using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Runtime.InteropServices;

namespace programaFacturacion.modelo
{
    public class empleadosModelo
    {
        conexion conexion1 = new conexion();

        //verificar si existe algun registro con el mismo nombre o la misma cedula
        public bool verificarExistenciaEmpleado(Int64 IDEmpleado)
        {
            string consulta = "select * from empleados where IDEmpleado=@IDEmpleado";
            bool valor = false;
            using (SqlConnection ocon = new SqlConnection(conexion1.connectionString))
            {
                ocon.Open();
                using (SqlCommand cmd = new SqlCommand(consulta, ocon))
                {
                    cmd.Parameters.AddWithValue("@IDEmpleado", IDEmpleado);
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

        public DataTable cargarEmpleados()
        {
            string consulta = "select * from empleados";
            DataTable dtEmpleado = new DataTable();
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
                            dtEmpleado.Load(reader);
                        }
                    }
                }
                ocon.Close();
            }
            return dtEmpleado;

        }

        public void agregarEmpleado(string nombre, string sexo, string cedula, string direccion, string posicion, string telefono, string correo, double salario, DateTime fechaEntrada, DateTime fechaSalida, byte[] imagenParaEnviar, string numeroLicencia, string tipoLicencia, string descripcionModificacion)
        {

            string consulta = "";
            if (imagenParaEnviar != null)
            {
                if (!string.IsNullOrEmpty(salario.ToString()))
                {
                    consulta = "insert into empleados(nombre,sexo,cedula,direccion,telefono,correo,salario,fechaEntrada,fechaSalida,fechaCreacion,fechaModificacion,descripcionModificacion,estado,imagen,numeroLicencia, tipoLicencia,posicion)" +
                       " values(@nombre,@sexo,@cedula,@direccion,@telefono,@correo,@salario,@fechaEntrada,@fechaSalida,@fechaCreacion,@fechaModificacion,@descripcionModificacion,@estado,@imagen,@numeroLicencia, @tipoLicencia,@posicion)";
                }
                else
                {
                    consulta = "insert into empleados(nombre,sexo,cedula,direccion,telefono,correo,fechaEntrada,fechaSalida,fechaCreacion,fechaModificacion,descripcionModificacion,estado,imagen, numeroLicencia,tipoLicencia,posicion)" +
   " values(@nombre,@sexo,@cedula,@direccion,@telefono,@correo,@fechaEntrada,@fechaSalida,@fechaCreacion,@fechaModificacion,@descripcionModificacion,@estado,@imagen, @numeroLicencia, @tipoLicencia,@posicion)";

                }
            }
            else
            {
                if (!string.IsNullOrEmpty(salario.ToString()))
                {
                    consulta = "insert into empleados(nombre,sexo,cedula,direccion,telefono,correo,salario,fechaEntrada,fechaSalida,fechaCreacion,fechaModificacion,descripcionModificacion,estado, numeroLicencia, tipoLicencia,posicion)" +
       " values(@nombre,@sexo,@cedula,@direccion,@telefono,@correo,@salario,@fechaEntrada,@fechaSalida,@fechaCreacion,@fechaModificacion,@descripcionModificacion,@estado,@numeroLicencia, @tipoLicencia,@posicion)";
                }
                else
                {
                    consulta = "insert into empleados(nombre,sexo,cedula,direccion,telefono,correo,fechaEntrada,fechaSalida,fechaCreacion,fechaModificacion,descripcionModificacion,estado,numeroLicencia, tipoLicencia,posicion)" +
" values(@nombre,@sexo,@cedula,@direccion,@telefono,@correo,@fechaEntrada,@fechaSalida,@fechaCreacion,@fechaModificacion,@descripcionModificacion,@estado,@numeroLicencia, @tipoLicencia,@posicion)";

                }
            }
            using (SqlConnection ocon = new SqlConnection(conexion1.connectionString))
            {
                ocon.Open();
                using (SqlCommand cmd = new SqlCommand(consulta, ocon))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@sexo", sexo);
                    cmd.Parameters.AddWithValue("@cedula", cedula);
                    cmd.Parameters.AddWithValue("@direccion", direccion);
                    cmd.Parameters.AddWithValue("@telefono", telefono);
                    cmd.Parameters.AddWithValue("@correo", correo);
                    cmd.Parameters.AddWithValue("@salario", salario);
                    cmd.Parameters.AddWithValue("@fechaEntrada", fechaEntrada);
                    cmd.Parameters.AddWithValue("@fechaSalida", fechaSalida);
                    cmd.Parameters.AddWithValue("@fechaCreacion", DateTime.Now);
                    cmd.Parameters.AddWithValue("@fechaModificacion", DateTime.Now);
                    cmd.Parameters.AddWithValue("@descripcionModificacion",descripcionModificacion);
                    cmd.Parameters.AddWithValue("@estado", true);
                    if (imagenParaEnviar != null)
                    {
                        cmd.Parameters.AddWithValue("@imagen", imagenParaEnviar);
                    }
                    cmd.Parameters.AddWithValue("@posicion",posicion);
                    cmd.Parameters.AddWithValue("@numeroLicencia", numeroLicencia);
                    cmd.Parameters.AddWithValue("@tipoLicencia", tipoLicencia);
                    cmd.ExecuteNonQuery();
                }
                ocon.Close();
            }
        }

        public void eliminarEmpleado(Int64 IDEmpleado)
        {

            if (verificarExistenciaEmpleado(IDEmpleado) == true)
            {
                string consulta = "delete from empleados where IDEmpleado=@IDEmpleado";
                using (SqlConnection ocon = new SqlConnection(conexion1.connectionString))
                {
                    ocon.Open();
                    using (SqlCommand cmd = new SqlCommand(consulta, ocon))
                    {
                        cmd.Parameters.AddWithValue("@IDEmpleado", IDEmpleado);
                        cmd.ExecuteNonQuery();
                    }
                    ocon.Close();
                }

            }
        }

        public void modificarEmpleado(Int64 IDEmpleado, string nombre, string sexo, string cedula, string direccion, string posicion, string telefono, string correo, double salario, DateTime fechaModificacion, byte[] imagenParaEnviar, string numeroLicencia, string tipoLicencia,string descripcionModificacion)
        {
            string consulta = "";
            if (imagenParaEnviar != null)
            {
                if (!string.IsNullOrEmpty(numeroLicencia))
                {
                    if (!string.IsNullOrEmpty(tipoLicencia))
                    {
                        consulta = "update empleados set nombre=@nombre,posicion=@posicion, sexo=@sexo,cedula=@cedula,direccion=@direccion,telefono=@telefono, correo=@correo, salario=@salario,fechaModificacion=@fechaModificacion, imagen=@imagen, numeroLicencia=@numeroLicencia, tipoLicencia=@tipoLicencia, descripcionModificacion=@descripcionModificacion where IDEmpleado= @IDEmpleado";

                    }
                    else
                    {
                        consulta = "update empleados set nombre=@nombre,posicion=@posicion, sexo=@sexo,cedula=@cedula,direccion=@direccion,telefono=@telefono, correo=@correo, salario=@salario,fechaModificacion=@fechaModificacion, imagen=@imagen, numeroLicencia=@numeroLicencia,descripcionModificacion=@descripcionModificacion where IDEmpleado= @IDEmpleado";

                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(tipoLicencia))
                    {
                        consulta = "update empleados set nombre=@nombre,posicion=@posicion ,sexo=@sexo,cedula=@cedula,direccion=@direccion,telefono=@telefono, correo=@correo, salario=@salario,fechaModificacion=@fechaModificacion, imagen=@imagen, tipoLicencia=@tipoLicencia,descripcionModificacion=@descripcionModificacion where IDEmpleado= @IDEmpleado";
                    }
                    else
                    {
                        consulta = "update empleados set nombre=@nombre,posicion=@posicion ,sexo=@sexo,cedula=@cedula,direccion=@direccion,telefono=@telefono, correo=@correo, salario=@salario,fechaModificacion=@fechaModificacion, imagen=@imagen,descripcionModificacion=@descripcionModificacion where IDEmpleado= @IDEmpleado";

                    }
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(numeroLicencia))
                {
                    if (!string.IsNullOrEmpty(tipoLicencia))
                    {
                        consulta = "update empleados set nombre=@nombre,posicion=@posicion, sexo=@sexo,cedula=@cedula,direccion=@direccion,telefono=@telefono, correo=@correo, salario=@salario,fechaModificacion=@fechaModificacion, numeroLicencia=@numeroLicencia, tipoLicencia=@tipoLicencia,descripcionModificacion=@descripcionModificacion where IDEmpleado= @IDEmpleado";

                    }
                    else
                    {
                        consulta = "update empleados set nombre=@nombre,posicion=@posicion, sexo=@sexo,cedula=@cedula,direccion=@direccion,telefono=@telefono, correo=@correo, salario=@salario,fechaModificacion=@fechaModificacion,  numeroLicencia=@numeroLicencia,descripcionModificacion=@descripcionModificacion where IDEmpleado= @IDEmpleado";

                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(tipoLicencia))
                    {
                        consulta = "update empleados set nombre=@nombre,posicion=@posicion, sexo=@sexo,cedula=@cedula,direccion=@direccion,telefono=@telefono, correo=@correo, salario=@salario,fechaModificacion=@fechaModificacion,  tipoLicencia=@tipoLicencia,descripcionModificacion=@descripcionModificacion where IDEmpleado= @IDEmpleado";
                    }
                    else
                    {
                        consulta = "update empleados set nombre=@nombre,posicion=@posicion, sexo=@sexo,cedula=@cedula,direccion=@direccion,telefono=@telefono, correo=@correo, salario=@salario,fechaModificacion=@fechaModificacion,descripcionModificacion=@descripcionModificacion where IDEmpleado= @IDEmpleado";

                    }
                }

            }

            if (verificarExistenciaEmpleado(IDEmpleado) == true)
            {
                using (SqlConnection ocon = new SqlConnection(conexion1.connectionString))
                {
                    ocon.Open();
                    using (SqlCommand cmd = new SqlCommand(consulta, ocon))
                    {
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@posicion", posicion);
                        cmd.Parameters.AddWithValue("@sexo", sexo);
                        cmd.Parameters.AddWithValue("@cedula", cedula);
                        cmd.Parameters.AddWithValue("@direccion", direccion);
                        cmd.Parameters.AddWithValue("@telefono", telefono);
                        cmd.Parameters.AddWithValue("@correo", correo);
                        cmd.Parameters.AddWithValue("@salario", salario);
                        cmd.Parameters.AddWithValue("@fechaModificacion", fechaModificacion);
                        cmd.Parameters.AddWithValue("descripcionModificacion", descripcionModificacion);
                        cmd.Parameters.AddWithValue("@IDEmpleado", IDEmpleado);
                        if (imagenParaEnviar != null)
                        {
                            cmd.Parameters.AddWithValue("@imagen", imagenParaEnviar);
                        }
                        if (!string.IsNullOrEmpty(numeroLicencia))
                        {
                            cmd.Parameters.AddWithValue("@numeroLicencia", numeroLicencia);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@numeroLicencia", "");
                        }
                        if (!string.IsNullOrEmpty(tipoLicencia))
                        {
                            cmd.Parameters.AddWithValue("@tipoLicencia", tipoLicencia);
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@tipoLicencia", "");
                        }
                        cmd.ExecuteNonQuery();
                    }
                    ocon.Close();

                }
                MessageBox.Show("Modificado Exitosamente");
            }
            else
            {
                MessageBox.Show("No existe un empleado con los datos seleccionados");
            }
        }

        public DataTable buscarEmpleado(string buscador, string criterio)
        {
            string a = buscador;
            buscador = "";
            buscador = "%" +a+ "%";
            string consulta = "select * from empleados where "+criterio+" like @buscador";
            DataTable dtEmpleado = new DataTable();
            using (SqlConnection ocon = new SqlConnection(conexion1.connectionString))
            {
                ocon.Open();
                using (SqlCommand cmd = new SqlCommand(consulta,ocon))
                {
                    cmd.Parameters.AddWithValue("@buscador",buscador);
                    cmd.ExecuteNonQuery();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            dtEmpleado.Load(reader);
                        }
                    }
                }
                    ocon.Close();
            }
            return dtEmpleado;
        }
    
    }
}
