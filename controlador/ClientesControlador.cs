using programaFacturacion.modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace programaFacturacion.controlador
{
    public class ClientesControlador
    {
        public DataTable dtClientesControlador;
        ClientesModelo modelo= new ClientesModelo();
        public DataTable getClientesControlador()
        {
            dtClientesControlador = modelo.getClientes();
            return dtClientesControlador;
        }

        public DataTable buscarClientesControlador(string criterio,string buscador)
        {
            dtClientesControlador = modelo.BuscadorClientesModelo(criterio,buscador);
            return dtClientesControlador;
        }
        //agregar clientes
        public string agregarClientesControlador(string nombre,string sexo,Array imagen,string cedula,string empresa,string direccion, string tipoCliente,string telefono,string correo,double balance, double deuda, double limiteCredito,string fechaCreacion,string fechaModificacion, string RNC,string descripcionModificacion)
        {
            string resultado = modelo.AgregarClientesModelo(nombre,sexo,imagen,cedula,empresa,direccion,tipoCliente,telefono,correo,balance,deuda,limiteCredito,fechaCreacion,fechaModificacion,RNC, descripcionModificacion);
            return resultado;
        }

        //eliminar clientes

        public string eliminarClientesControlador(string nombreRepresentante)
        {
            string resultado = modelo.EliminarClientesModelo(nombreRepresentante);
            return resultado;
        }

        //modificar clientes

        public string modificarClientesControlador(string nombre,string sexo,Array imagen,string cedula,string empresa,string direccion,string tipoCliente,string telefono,string correo,double balance,double deuda,double limiteCredito,string  fechaModificacion,string RNC,string  descripcionModificacion)
        {
            string resultado = modelo.ModificarClientesModelo(nombre, sexo, imagen, cedula, empresa, direccion, tipoCliente, telefono, correo, balance, deuda, limiteCredito, fechaModificacion, RNC, descripcionModificacion);
            return resultado;
        }



        
    }
}
