using Multicinex.Classes.Empleado;
using Siticone.Desktop.UI.WinForms;
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
            llenarTablaInfoEmpleado(buscarEmpleadoInfo(siticoneTextBox7.Text));
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
            var filtroNombreSucursal = siticoneComboBox1.Text;
            if (filtroNombreSucursal.Equals("Ambos"))
                filtroNombreSucursal = "";
            List<Empleado> resultado = new List<Empleado>();
            foreach (Empleado item in EmpleadoInfoMapper.ConsultarEmpleado())
            {
                if (siticoneComboBox1.Text.Equals("Ambos")){
                    if (item.cc.Contains(cc)){
                        resultado.Add(item);
                    }
                }
                else if (item.cc.Contains(cc) && item.nombreSucursal.Equals(siticoneComboBox1.Text))
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
                llenarTablaInfoEmpleado(buscarEmpleadoInfo(siticoneTextBox7.Text));
                llenarTablaSueldoEmpleado(EmpleadoSueldoMapper.ConsultarEmpleadoSueldo());
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo añadir la pelicula" +ex.Message);
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

        private void siticoneDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Empleado empleadoAEditar = new Empleado(
                    siticoneDataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(),
                    siticoneDataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    siticoneDataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    null,
                    null,
                    siticoneDataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString()
                    );
                EditarEmpleado editarEmpleado = new EditarEmpleado(empleadoAEditar);
                editarEmpleado.Visible = true;
                editarEmpleado.BringToFront();
            }
            catch { }
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            llenarTablaInfoEmpleado(buscarEmpleadoInfo(siticoneTextBox7.Text));
        }

        private void siticoneComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarTablaInfoEmpleado(buscarEmpleadoInfo(siticoneTextBox7.Text));
        }

        private void siticoneDataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                EmpleadoSueldo empleadoSueldo = new EmpleadoSueldo(
                    siticoneDataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString(),
                    Convert.ToDouble(siticoneDataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString()),
                    DateTime.Parse(siticoneDataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString())
                    );
                EditarEmpleadoSueldo editarEmpleadoSueldo = new EditarEmpleadoSueldo(empleadoSueldo);
                editarEmpleadoSueldo.Visible = true;
                editarEmpleadoSueldo.BringToFront();
            }
            catch { }
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            llenarTablaSueldoEmpleado(buscarEmpleadoSueldo(siticoneTextBox4.Text));
        }
    }
}
