using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace programaFacturacion.modelo
{
    //Esta clase tiene un metodo que lo que hace es recibir la tabla, la columna que queremos recibir, la columna la cual tomaremos como referencia y el ID y transformarlo a el nombre que le conrresponde
    public class cambiarIDaNombreModelo
    {
        string nombre{ get; set; }

        public  string getID(string tabla, string columnaRecibir,string columnaReferencia, long ID) 
        {
            //el primer paso es abrir una conexion
            //para ello necesitaremos una cadena de conexion
            conexion conexion1 = new conexion();
            //tambien necesitaremos nuestra consulta sql
            string consulta = "select "+columnaRecibir+" from "+tabla+" where "+columnaReferencia+"=@valorColumna";
            //tambien necesitaremos una tabla para capturar los datos de la base de datos
            DataTable valorID= new DataTable();
            // el siguiente paso es abrir la conexion
            using (SqlConnection ocon = new SqlConnection(conexion1.connectionString))
            { 
                ocon.Open();
                // ahora debemos hacer la consulta
                //para ello abrimos nuestro comando
                using (SqlCommand cmd = new SqlCommand(consulta,ocon))
                {
                    cmd.Parameters.AddWithValue("@valorColumna",ID.ToString());
                    cmd.ExecuteNonQuery();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            valorID.Load(reader);
                            for (int i = 0; i < valorID.Rows.Count; i++)
                            {
                                
                                nombre = valorID.Rows[i][0].ToString();
                            }

                        }
                    }
                }
                ocon.Close();
            }
            
                return nombre;
        }
    }
}
