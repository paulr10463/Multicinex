using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multicinex.Classes.Empleado
{
    public class Empleado
    {
        public string cc;
        public string nombre;
        public string apellido;
        public double? sueldo;
        public DateTime? fechaContratacion;
        public string nombreSucursal;

        public Empleado(string cc, string nombre, string apellido, double? sueldo, DateTime? fechaContratacion, string nombreSucursal)
        {
            this.cc = cc;
            this.nombre = nombre;
            this.apellido = apellido;
            this.sueldo = sueldo ?? 0;
            this.fechaContratacion = fechaContratacion;
            this.nombreSucursal = nombreSucursal;
        }
    }



}
