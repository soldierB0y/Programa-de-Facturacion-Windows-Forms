using Microsoft.Extensions.Options;
using Microsoft.Identity.Client;
using programaFacturacion.modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programaFacturacion.controlador
{
    public class ArticulosControlador
    {
       public ArticulosModelo modelo=new ArticulosModelo();
       public  DataTable dtArticulosControlador= new DataTable();

        public DataTable getArticulos() {

            modelo.getArticulos();
            dtArticulosControlador = modelo.dtArticulosModelo;
            try
            {
                dtArticulosControlador.Columns[2].ColumnName = "RNC";
            }
            catch (Exception ex) {}
            return dtArticulosControlador;
        }

        public string AgregarArticulosControlador(string nombre, string codigo, Array imagen, string descripcion, double precioCompra, double precioVenta, double precioMinimo, bool precioModificable, bool estado, bool facturarSinInventario, double inventario,string marca,string proovedor,string descripcionModificacion)
        {
           string valor= modelo.AgregarArticulosModelo(nombre,codigo,imagen,descripcion,precioCompra,precioVenta,precioMinimo,precioModificable,estado,facturarSinInventario,inventario,marca,proovedor, descripcionModificacion);
           return valor;
        }

        public string ModificarArticulosControlador(string nombre, string codigo, Array imagen, string descripcion, double precioCompra, double precioVenta, double precioMinimo, bool precioModificable, bool estado, bool facturarSinInventario, double inventario,string marca,string proovedor,string  descripcionModificacion)
        {
            string valor = modelo.ModificarArticulosModelo(nombre, codigo, imagen, descripcion, precioCompra, precioVenta, precioMinimo, precioModificable, estado, facturarSinInventario, inventario,marca,proovedor, descripcionModificacion);

            return valor;
        }

        public string EliminarArticulosControlador(string codigo)
        {
            string valor = modelo.EliminarArticulosControlador(codigo);
            return valor;
        }
        public DataTable BuscadorArticulosControlador(string criterio, string buscador)
        {
            try
            {
                DataTable valor = modelo.BuscadorArticulosModelo(criterio, buscador);
                valor.Columns[2].ColumnName = "RNC";
                return valor;
            }
            catch
            (Exception ex) {return new DataTable(); }
        }


        public List<string> cargarProovedores()
        {
            List<string> values = new List<string>();
            values= modelo.cargarProovedores();
            return values;
        }



        public List<string> cargarMarca()
        {
            List<string> values = new List<string>();
            values = modelo.cargarMarca();
            return values;
        }
    }
}
