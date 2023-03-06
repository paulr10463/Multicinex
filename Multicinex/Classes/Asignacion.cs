using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multicinex.Classes
{
    public class Asignacion
    {
        public DateTime fecha;
        public string cc;
        public string nombreSucursal;
        public string codigoSala;

        public Asignacion(DateTime fecha, string cc, string nombreSucursal, string codigoSala)
        {
            this.fecha = fecha;
            this.cc = cc;
            this.nombreSucursal = nombreSucursal;
            this.codigoSala = codigoSala;
        }
    }
}
