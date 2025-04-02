using Microsoft.Extensions.Options;
using programaFacturacion.vistas;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programaFacturacion.modelo
{
    public class inicioSesionModelo
    {
        usuarioModelo usuarioModelo= new usuarioModelo();
        DataTable dtUsuario=new DataTable();


        public bool verificarUsuarioClave(string usuario,string clave)
        {
            dtUsuario.Clear();

            dtUsuario = usuarioModelo.cargarUsuarios();
            bool valor=false;
            foreach (DataRow row in dtUsuario.Rows)
            {
                if (row[2].ToString() == usuario && row[3].ToString() == clave)
                {
                    valor = true;
                    break;
                }

            }

            return valor;
        }
    }
}
