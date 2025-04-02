using programaFacturacion.modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programaFacturacion.controlador
{
    public class usuarioControlador
    {
        usuarioModelo usuarioModelo = new usuarioModelo();
        public DataTable cargarUsuarios()
        {
            return usuarioModelo.cargarUsuarios();
        }
        public void agregarUsuarios(string usuario, string clave, string puesto, Int64 IDEmpleado,string descripcionModificacion)
        {
            //    MessageBox.Show("usuario controlador \n"+IDEmpleado.ToString());
            usuarioModelo.agregarUsuarios(usuario, clave, puesto, IDEmpleado, descripcionModificacion);
        }

        public bool verificarNombreUsuario(string nombreUsuario)
        {
            return usuarioModelo.verificarNombreUsuario(nombreUsuario);
        }

        public void eliminarUsuario(Int64 IDUsuario)
        {
            usuarioModelo.eliminarUsuario(IDUsuario);
        }

        public void modificarUsuario(Int64 IDUsuario, Int64 IDEmpleado, string usuario, string clave, string descripcionModificacion, string puesto)
        {
            usuarioModelo.modificarUsuario(IDUsuario, IDEmpleado, usuario, clave, descripcionModificacion, puesto);

        }
        public DataTable buscarUsuarios(string buscador, string criterio)
        {
            return usuarioModelo.buscarUsuarios(buscador, criterio);
        }

        public bool verificarExistenciaUsuario(Int64 IDUsuario)
        {
            return usuarioModelo.verificarExistenciaUsuario(IDUsuario);
        }
    }
}
