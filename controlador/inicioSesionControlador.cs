using programaFacturacion.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programaFacturacion.controlador
{
    public class inicioSesionControlador
    {
        inicioSesionModelo inicioSesionModelo = new inicioSesionModelo();
        public bool verificarUsuarioClave(string usuario, string clave)
        {
            return inicioSesionModelo.verificarUsuarioClave(usuario, clave);
        }
    }
}
