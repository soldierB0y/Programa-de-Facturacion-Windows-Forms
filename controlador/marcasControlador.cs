using programaFacturacion.modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programaFacturacion.controlador
{
    public class marcasControlador
    {
        marcasModelo marcasModelo = new marcasModelo();
        public DataTable cargarMarcas()
        {
            return marcasModelo.cargarMarcas();
        }

        public DataTable buscarMarcas(string buscador, string criterio)
        {
            return marcasModelo.buscarMarcas(buscador, criterio);
        }

        public void agregarMarcas(string nombre, string descripcion, string otrosDatos,string descripcionModificacion)
        {
            marcasModelo.agregarMarcas(nombre,descripcion,otrosDatos, descripcionModificacion);
            
        }

        public List<string> cargarNombreMarcas()
        {
            return marcasModelo.cargarNombreMarcas();
        }

        public void eliminarMarca(Int64 IDMarca)
        {
            marcasModelo.eliminarMarca(IDMarca);
        }

        public void modificarMarca(Int64 IDMarca, string nombre, string descripcion, string otrosDatos,string descripcionModificacion)
        {
            marcasModelo.modificarMarca(IDMarca,nombre,descripcion,otrosDatos, descripcionModificacion);
        }
    }
}
