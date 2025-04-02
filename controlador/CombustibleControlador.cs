using programaFacturacion.modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programaFacturacion.controlador
{
    public class CombustibleControlador
    {
        CombustibleModelo CombustibleModelo = new CombustibleModelo();
        public void agregarCombustible(Int64 IDChofer, string nombreChofer, Int64 IDCamion, double gasto, double galones, DateTime fechaCompra, string notas, string descripcionModificacion, string nombreCamion)
        {
            CombustibleModelo.agregarCombustible(IDChofer, nombreChofer, IDCamion, gasto, galones, fechaCompra, notas, descripcionModificacion,nombreCamion);
        }

        public DataTable cargarCombustible()
        {
            return CombustibleModelo.cargarCombustible();
        }
        public DataTable buscarCombustible(string buscador, string criterio)
        {
            return CombustibleModelo.buscarCombustible(buscador,criterio);
        }

        public string eliminarCombustible(Int64 IDCombustible)
        {

            return CombustibleModelo.eliminarCombustible(IDCombustible);
        }
    }
}
