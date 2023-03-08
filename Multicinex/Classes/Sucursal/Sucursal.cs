using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multicinex.Classes.Sucursal
{
    public class Sucursal
    {
        public string nombreSucursal;
        public string telefono;
        public string ubicacion;

        public Sucursal(string nombreSucursal, string telefono, string ubicacion)
        {
            this.nombreSucursal = nombreSucursal;
            this.telefono = telefono;
            this.ubicacion = ubicacion;
        }

    }
}
