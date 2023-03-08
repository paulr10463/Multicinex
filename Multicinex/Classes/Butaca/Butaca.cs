using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multicinex.Classes.Butaca
{
    public class Butaca
    {
        public string fila;
        public int columna;
        public string nombreSucursal;
        public string codigoSala;

        public Butaca(string fila, int columna, string nombreSucursal, string codigoSala)
        {
            this.fila = fila;
            this.columna = columna;
            this.nombreSucursal = nombreSucursal;
            this.codigoSala = codigoSala;
        }
    }
}
