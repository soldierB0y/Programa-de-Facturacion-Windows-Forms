using programaFacturacion.modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programaFacturacion.controlador
{
    public class facturasControlador
    {
        facturasModelo facturasModelo = new facturasModelo();
        public DataTable cargarFacturas()
        {
            return facturasModelo.cargarFacturas();
        }

        public void enviarFacturasDetalle(DataTable facturaDetalle, string descripcionModificacion)
        {
            facturasModelo.enviarFacturasDetalle(facturaDetalle, descripcionModificacion);
        }


        public void enviarFacturasDetalleModificar(DataTable facturaDetalle, string descripcionModificacion)
        {
            facturasModelo.enviarFacturasDetalleModificar(facturaDetalle, descripcionModificacion);
        }



        public void enviarFactura(DataTable factura, string descripcionModificacion)
        {
            facturasModelo.enviarFacturas(factura, descripcionModificacion);
        }

        public string cargarFactura(DateTime datetime, Int64 IDCliente)
        {
            string valor = facturasModelo.cargarFactura(datetime, IDCliente);
            return valor;
        }

        public DataTable cargarDetallesFacturas(Int64 IDFactura)
        {
            DataTable detalleFacturas = facturasModelo.cargarDetalleFactura(IDFactura);
            return detalleFacturas;
        }


        public void eliminarFactura(Int64 IDFactura, string comando)
        {
            facturasModelo.eliminarFactura(IDFactura, "ambos");
            cargarFacturas();
            
        }

        public void actualizarFactura(string IDCotizacion, string total, string subtotal, string itbis, string transporte, string descuento, string descripcionModificacion)
        {
            facturasModelo.actualizarFactura(IDCotizacion, total, subtotal, itbis, transporte, descuento, descripcionModificacion);
        }

        public DataTable buscarFacturas(Int64 IDCliente)
        {
            return facturasModelo.buscarFacturas(IDCliente);

        }
    }
}
