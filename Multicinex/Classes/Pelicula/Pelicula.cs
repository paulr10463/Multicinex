using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multicinex.Classes.Pelicula
{
    public class Pelicula
    {
        public string codigoPelicula { get; set; }
        public string titulo { get; set; }
        public int duracion { get; set; }
        public int anio { get; set; }
        public string sinopsis { get; set; }
        public string nombreDirector { get; set; }
        public string apellidoDirector { get; set; }


        public Pelicula(string codigoPelicula, string titulo, int duracion, int anio, string sinopsis, string nombreDirector, string apellidoDirector)
        {
            this.codigoPelicula = codigoPelicula;
            this.titulo = titulo;
            this.duracion = duracion;
            this.anio = anio;
            this.sinopsis = sinopsis;
            this.nombreDirector = nombreDirector;
            this.apellidoDirector = apellidoDirector;
        }
    }
}
