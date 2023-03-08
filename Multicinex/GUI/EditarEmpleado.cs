using Multicinex.Classes.Empleado;
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
    public partial class EditarEmpleado : Form
    {
        public EditarEmpleado(Empleado empleadoAEditar)
        {
            InitializeComponent();
            tbAnadirEmpleado.Text = empleadoAEditar.cc;
            tbAnadirNombre.Text = empleadoAEditar.nombre;
            tbAnadirApellido.Text = empleadoAEditar.apellido;
            cbSucursal.Text = empleadoAEditar.nombreSucursal;
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            Empleado empleadoRegistrado = new Empleado(
                tbAnadirEmpleado.Text,
                tbAnadirNombre.Text,
                tbAnadirApellido.Text,
                null,
                null,
                cbSucursal.Text);

            try
            {
                EmpleadoInfoMapper.ModificarEmpleadoInfo(empleadoRegistrado);
                MessageBox.Show("Empleado actualizado con exito");
                this.Close();
            }
            catch
            {
                MessageBox.Show("No se pudo modificar el empleado");
            }
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            try
            {
                EmpleadoInfoMapper.EliminarEmpleadoInfo(tbAnadirEmpleado.Text);
                MessageBox.Show("Empleado Eliminado con exito");
                this.Dispose();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("No se pudo eliminar el registro: " + ex.Message);
            }
        }
    }
}
