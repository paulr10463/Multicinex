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
    public partial class EditarEmpleadoSueldo : Form
    {
        public EditarEmpleadoSueldo(EmpleadoSueldo empleadoSueldo)
        {
            InitializeComponent();
            tbAnadirEmpleado.Text = empleadoSueldo.cc;
            tbFechaContratacion.Value = (DateTime)empleadoSueldo.fechaContratacion;
            tbSueldo.Text = empleadoSueldo.sueldo.ToString();

        }

        //Actualizar
        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            EmpleadoSueldo empleadoSueldo = new EmpleadoSueldo(
                tbAnadirEmpleado.Text,
                Convert.ToDouble(tbSueldo.Text),
                tbFechaContratacion.Value);

            try
            {
                EmpleadoSueldoMapper.ModificarEmpleadoSueldo(empleadoSueldo);
                MessageBox.Show("Registro actualizado con exito");
                this.Close();
            }
            catch
            {
                MessageBox.Show("No se pudo modificar el registro");
            }
        }

        //Eliminar
        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            try
            {
                EmpleadoSueldoMapper.EliminarEmpleadoSueldo(tbAnadirEmpleado.Text);
                MessageBox.Show("Registro Eliminado con exito");
                this.Dispose();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("No se pudo eliminar el registro: " + ex.Message);
            }
        }
    }
}
