using programaFacturacion.modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programaFacturacion.controlador
{
    public class proovedorControlador
    {
        proovedorModelo proovedorModelo=new proovedorModelo();
        public DataTable cargarProovedor()
        { 
            return proovedorModelo.cargarProovedor();
        }

        public void agregarProovedor(string nombre, string telefono, string cedula, string correo, string empresa,string descripcionModificacion)
        {
            proovedorModelo.agregarProovedor(nombre,telefono,cedula,correo,empresa, descripcionModificacion);

        }
        public void eliminarProovedor(Int64 IDProovedor)
        {
            proovedorModelo.eliminarProovedor(IDProovedor);
        }


        public void modificarProovedor(Int64 IDProovedor, string nombre, string telefono, string cedula, string correo, string empresa,string descripcionModificacion)
        {
            proovedorModelo.modificarProovedor(IDProovedor,nombre,telefono,cedula,correo,empresa, descripcionModificacion);
        
        }

        public DataTable buscarProovedor(string buscador, string criterio)
        {
            return proovedorModelo.buscarProovedor(buscador,criterio);
        }
    }
}
