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
        List<EmpleadoInfo> empleadosRegistrados;
        public UC_Empleado()
        {
            InitializeComponent();
            empleadosRegistrados = EmpleadoInfoMapper.ConsultarEmpleado();
            llenarTablaInfoEmpleado(empleadosRegistrados);
        }

        public void llenarTablaInfoEmpleado(List<EmpleadoInfo> listaEmpleados)
        {
            siticoneDataGridView1.Rows.Clear();
            foreach (EmpleadoInfo empleado in listaEmpleados)
            {
                siticoneDataGridView1.Rows.Add(empleado.cc, empleado.nombre, empleado.apellido, empleado.nombreSucursal);
            }
        }

        /*public void llenarTablaSueldoEmpleado(List<EmpleadoInfo> listaEmpleados)
        {
            siticoneDataGridView2.Rows.Clear();
            foreach (EmpleadoInfo empleado in listaEmpleados)
            {
                siticoneDataGridView1.Rows.Add(empleado.cc, empleado.nombre, empleado.apellido, empleado.nombreSucursal);
            }
        }*/

        public List<EmpleadoInfo> buscarEmpleado(string cc)
        {
            List<EmpleadoInfo> resultado = new List<EmpleadoInfo>();
            foreach (EmpleadoInfo item in EmpleadoInfoMapper.ConsultarEmpleado())
            {
                if (item.cc.Contains(cc))
                {
                    resultado.Add(item);
                }
            }
            return resultado;

        }

        private void siticoneTextBox7_TextChanged(object sender, EventArgs e)
        {
            llenarTablaInfoEmpleado(buscarEmpleado(siticoneTextBox7.Text));
        }

        private void siticoneTextBox4_TextChanged(object sender, EventArgs e)
        {
            //llenarTablaSueldoEmpleado(buscarEmpleado(siticoneTextBox4.Text));
        }
    }
}
