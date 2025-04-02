using programaFacturacion.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programaFacturacion.controlador
{
    public class cambiarIDaNombreControlador
    {
        public cambiarIDaNombreModelo CINM= new cambiarIDaNombreModelo();

        public string getID(string tabla, string columnaRecibir,string columnaReferencia,long ID)
        {
            string nombre = CINM.getID(tabla,columnaRecibir,columnaReferencia,ID);
            return nombre;
        }
    }
}
