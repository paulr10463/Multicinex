using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multicinex.Classes
{
    public class Sala
    {
        public string nombreSucursal;
        public string codigoSala;
        public int capacidadFilas;
        public int capacidadColumnas;
        public string tipo; 

        public Sala() { 
        }

        public Sala(string nombreSucursal, string codigoSala, int capacidadFilas, int capacidadColumnas, string tipo)
        {
            this.nombreSucursal = nombreSucursal;
            this.codigoSala = codigoSala;
            this.capacidadFilas = capacidadFilas;
            this.capacidadColumnas = capacidadColumnas;
            this.tipo = tipo;
        }
    }
}
