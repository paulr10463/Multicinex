using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multicinex.Classes.Empleado
{
    public class EmpleadoSueldo
    {
        public string cc;
        public double? sueldo;
        public DateTime? fechaContratacion;

        public EmpleadoSueldo(string cc, double? sueldo, DateTime? fechaContratacion)
        {
            this.cc = cc;
            this.sueldo = sueldo ?? 0;
            this.fechaContratacion = fechaContratacion;
        }
    }
}
