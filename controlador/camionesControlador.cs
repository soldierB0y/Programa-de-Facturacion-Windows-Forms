using programaFacturacion.modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programaFacturacion.controlador
{
    public class camionesControlador
    {
        camionesModelo camionesmodelo= new camionesModelo();
        public DataTable cargarCamiones()
        { 
            return camionesmodelo.cargarCamiones();
        }

        public void agregarCamiones(string modelo, string matricula, string color, string marca, double metraje, DateTime fechaAdquisicion, double numeroViajes, bool activo, DateTime fechaCreacion, DateTime fechaModificacion, string descripcionModificacion,string propietario, Array imagenParaEnviar)
        {
            camionesmodelo.agregarCamiones(modelo,matricula,color,marca,metraje,fechaAdquisicion,numeroViajes,activo,fechaCreacion,fechaModificacion,descripcionModificacion,propietario,imagenParaEnviar);
        }
        public DataTable buscarCamiones(string buscador, string criterio)
        {
            return camionesmodelo.buscarCamiones(buscador, criterio);
        }

        public void eliminarCamiones(Int64 IDCamion)
        { 
            camionesmodelo.eliminarCamion(IDCamion);
        }

        public void modificarCamiones(Int64 IDCamion, string modelo, string matricula, string color, string marca, double metraje, DateTime fechaAdquisicion, bool activo, DateTime fechaModificacion, string descripcionModificacion, string propietario, Array imagenParaEnviar)
        {

            camionesmodelo.modificarCamion(IDCamion,modelo,matricula,color,marca,metraje,fechaAdquisicion,activo,fechaModificacion,descripcionModificacion,propietario,imagenParaEnviar);
        }
    }
}
