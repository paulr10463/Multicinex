using Multicinex.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multicinex.GUI
{
    public partial class UC_Empleado : UserControl
    {
        public UC_Empleado()
        {
            InitializeComponent();
            llenarTablaCliente();
        }

        public void llenarTablaCliente()
        {
                siticoneDataGridView1.Rows.Clear();
                List <EmpleadoInfo> empleadosRegistrados = EmpleadoInfoMapper.ConsultarEmpleado();
                foreach (EmpleadoInfo empleado in empleadosRegistrados)
                {
                    siticoneDataGridView1.Rows.Add(empleado.cc, empleado.nombre,empleado.apellido, empleado.nombreSucursal);
                }
            
        }
    }
}
