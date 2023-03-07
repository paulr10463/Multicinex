using Multicinex.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            llenarTablaInfoEmpleado(EmpleadoInfoMapper.ConsultarEmpleado());
            llenarTablaSueldoEmpleado(EmpleadoSueldoMapper.ConsultarEmpleadoSueldo());
        }

        public void llenarTablaInfoEmpleado(List<Empleado> listaEmpleados)
        {
            siticoneDataGridView1.Rows.Clear();
            foreach (Empleado empleado in listaEmpleados)
            {
                siticoneDataGridView1.Rows.Add(empleado.cc, empleado.nombre, empleado.apellido, empleado.nombreSucursal);
            }
        }

        public void llenarTablaSueldoEmpleado(List<EmpleadoSueldo> listaEmpleadosSueldo)
        {
            siticoneDataGridView2.Rows.Clear();
            foreach (EmpleadoSueldo empleado in listaEmpleadosSueldo)
            {
                siticoneDataGridView2.Rows.Add(empleado.cc, empleado.sueldo, empleado.fechaContratacion);
            }
        }

        public List<Empleado> buscarEmpleadoInfo(string cc)
        {
            List<Empleado> resultado = new List<Empleado>();
            foreach (Empleado item in EmpleadoInfoMapper.ConsultarEmpleado())
            {
                if (item.cc.Contains(cc))
                {
                    resultado.Add(item);
                }
            }
            return resultado;

        }

        public List<EmpleadoSueldo> buscarEmpleadoSueldo(string cc)
        {
            List<EmpleadoSueldo> resultado = new List<EmpleadoSueldo>();
            foreach (EmpleadoSueldo item in EmpleadoSueldoMapper.ConsultarEmpleadoSueldo())
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
            llenarTablaInfoEmpleado(buscarEmpleadoInfo(siticoneTextBox7.Text));
        }

        private void siticoneTextBox4_TextChanged(object sender, EventArgs e)
        {
            llenarTablaSueldoEmpleado(buscarEmpleadoSueldo(siticoneTextBox4.Text));
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            Empleado empleadoRegistrado = new Empleado(
                tbAnadirEmpleado.Text,
                tbAnadirNombre.Text,
                tbAnadirApellido.Text,
                Convert.ToDouble(tbAnadirSueldo.Text),
                tbFechaContratacion.Value,
                cbSucursal.Text);
            
            try
            {
                EmpleadoInfoMapper.IngresarEmpleado(empleadoRegistrado);
                MessageBox.Show("Empleado añadido con exito");
                vaciarCampos();
                llenarTablaInfoEmpleado(EmpleadoInfoMapper.ConsultarEmpleado());
                llenarTablaSueldoEmpleado(EmpleadoSueldoMapper.ConsultarEmpleadoSueldo());
            }
            catch
            {
                MessageBox.Show("No se pudo añadir la pelicula");
            }

        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            try
            {
                EmpleadoInfoMapper.EliminarEmpleadoInfo(tbEliminarEmpleado.Text);
                MessageBox.Show("Empleado Eliminado con exito");
                llenarTablaInfoEmpleado(EmpleadoInfoMapper.ConsultarEmpleado());
            }
            catch (SqlException ex)
            {
                MessageBox.Show("No se pudo eliminar el registro: " + ex.Message);
            }
        }

        private void vaciarCampos()
        {
            tbAnadirEmpleado.Text = string.Empty;
            tbAnadirNombre.Text = string.Empty;
            tbAnadirApellido.Text = string.Empty; 
            tbAnadirSueldo.Text = string.Empty;
            tbFechaContratacion.Value = DateTime.Now;
            cbSucursal.Text = string.Empty;
        }
    }
}
