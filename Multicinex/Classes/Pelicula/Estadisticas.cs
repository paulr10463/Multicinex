using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multicinex.Classes.Pelicula
{
    public class Estadisticas
    {
        public string nombrePelicula;
        public int cantidadBoletos;

        public Estadisticas(string nombrePelicula, int cantidadBoletos)
        {
            this.nombrePelicula = nombrePelicula;
            this.cantidadBoletos = cantidadBoletos;
        }

    }
}
