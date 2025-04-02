using Microsoft.Data.SqlClient;
using programaFacturacion.modelo;
using System.Data;

namespace programaFacturacion.controlador
{
    public class cotizacionesControlador
    {
        DataTable dtArticulos = new DataTable();
        cotizacionesModelo modelo = new cotizacionesModelo();
        DataTable dtCotizaciones = new DataTable();
        public DataTable getArticulos()
        {
            dtArticulos = modelo.getArticulos();
            return dtArticulos;
        }

        public DataTable buscadorArticulos(string buscador, string codigo)
        {
            dtArticulos = modelo.buscadorArticulos(buscador,codigo);

            return dtArticulos;
        }

        public void enviarCotizacionDetalle(DataTable cotizacionDetalle,string descripcionModificacion)
        {
            modelo.enviarCotizacionDetalle(cotizacionDetalle, descripcionModificacion);
        }

        public void enviarCotizacion(DataTable cotizacion,string descripcionModificacion)
        { 
         modelo.enviarCotizacion(cotizacion, descripcionModificacion);
        }

        public string cargarCotizacion(DateTime datetime, Int64 IDCliente)
        {
            string valor = modelo.cargarCotizacion(datetime,IDCliente);
            return valor;
        }

        public DataTable cargarCotizaciones()
        { 
            dtCotizaciones.Rows.Clear();
            dtCotizaciones = modelo.cargarCotizaciones();
            return dtCotizaciones;
        }

        public DataTable cargarDetalleCotizaciones(Int64 IDCotizacion)
        {
            DataTable detalleCotizaciones = modelo.cargarDetalleCotizaciones(IDCotizacion);
            return detalleCotizaciones ;
        }


        public void eliminarCotizacion(Int64 IDCotizacion,string comando)
        {
            modelo.eliminarCotizacion(IDCotizacion,comando);
        }

        public void actualizarCotizacion(string IDCotizacion,string total, string subtotal,string itbis, string transporte, string descuento,string descripcionModificacion)
        {
            modelo.actualizarCotizacion(IDCotizacion,total,subtotal,itbis,transporte,descuento, descripcionModificacion);
        }
    }
}
