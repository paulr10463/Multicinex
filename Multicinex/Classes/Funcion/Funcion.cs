using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multicinex.Classes.Funcion
{
    public class Funcion
    {
        public string codigoPelicula;
        public string codigoFuncion;
        public string nombreSucursal;
        public string codigoSala;
        public DateTime horaInicio;
        public DateTime horaFin;
        public DateTime fecha;

        public Funcion(string codigoPelicula, string codigoFuncion, string nombreSucursal, string codigoSala, DateTime horaInicio, DateTime horaFin, DateTime fecha)
        {
            this.codigoPelicula = codigoPelicula;
            this.codigoFuncion = codigoFuncion;
            this.nombreSucursal = nombreSucursal;
            this.codigoSala = codigoSala;
            this.horaInicio = horaInicio;
            this.horaFin = horaFin;
            this.fecha = fecha;
        }
        public Funcion(string codigoPelicula, string codigoFuncion, string nombreSucursal, string codigoSala, TimeSpan horaInicio, TimeSpan horaFin, DateTime fecha)
        {
            this.codigoPelicula = codigoPelicula;
            this.codigoFuncion = codigoFuncion;
            this.nombreSucursal = nombreSucursal;
            this.codigoSala = codigoSala;
            this.horaInicio = this.horaInicio.Date + horaInicio;
            this.horaFin = this.horaInicio.Date + horaFin;
            this.fecha = fecha;
        }

        public Funcion()
        {

        }
    }
}
