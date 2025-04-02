using Microsoft.Identity.Client.NativeInterop;
using programaFacturacion.modelo;
using programaFacturacion.Resources;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace programaFacturacion.controlador
{
    public class empleadosControlador
    {
        empleadosModelo empleadosModelo = new empleadosModelo();
        public bool verificarExistenciaEmpleado(Int64 IDEmpleado)
        {
            return empleadosModelo.verificarExistenciaEmpleado(IDEmpleado);
        }

        public DataTable cargarEmpleados()
        {

            return empleadosModelo.cargarEmpleados();
        }

        public void agregarEmpleado(string nombre, string sexo, string cedula, string direccion, string posicion, string telefono, string correo, double salario, DateTime fechaEntrada, DateTime fechaSalida, byte[] imagenParaEnviar,string numeroLicencia,string tipoLicencia,string descripcionModificacion)
        {
            empleadosModelo.agregarEmpleado(nombre, sexo, cedula, direccion, posicion, telefono, correo, salario, fechaEntrada, fechaSalida,imagenParaEnviar,numeroLicencia,tipoLicencia, descripcionModificacion);
        }
        public void eliminarEmpleados(Int64 IDEmpleado)
        {
            empleadosModelo.eliminarEmpleado(IDEmpleado);
        }

        public void modificarEmpleados(Int64 IDEmpleado,  string nombre,string  sexo,string  cedula,string  direccion,string  posicion, string telefono,string correo, double salario, DateTime fechaModificacion, byte[] imagenParaEnviar, string numeroLicencia, string tipoLicencia,string  descripcionModificacion)
        {
            empleadosModelo.modificarEmpleado(IDEmpleado,nombre,sexo,cedula,direccion,posicion,telefono,correo,salario,fechaModificacion,imagenParaEnviar,numeroLicencia,tipoLicencia, descripcionModificacion);
        }

        public DataTable buscarEmpleado(string buscador, string criterio)
        {
            return empleadosModelo.buscarEmpleado(buscador,criterio);
        }
    }
}
