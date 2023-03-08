using Multicinex.Classes.Asignacion;
using Multicinex.Classes.Empleado;
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
    public partial class UC_Asignacion : UserControl
    {
        public UC_Asignacion()
        {
            InitializeComponent();
            llenarTablaAsignacion(buscarAsignacion(siticoneTextBox7.Text));
        }

        private void UC_Asignacion_Load(object sender, EventArgs e)
        {

        }

        private void vaciarCampos()
        {
            dtAsignacion.Value = DateTime.Now;
            tbCC.Text = string.Empty;
            cbSucursal.SelectedIndex = -1;
            tbCodigoSala.Text = string.Empty;
        }
        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            Asignacion asignacion = new Asignacion(
                dtAsignacion.Value,
                tbCC.Text,
                cbSucursal.Text,
                tbCodigoSala.Text
                );
            try
            {
                AsignacionMapper.IngresarAsignacion(asignacion);
                MessageBox.Show("Asignación realizada con exito");
                vaciarCampos();
                llenarTablaAsignacion(buscarAsignacion(siticoneTextBox7.Text));
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo añadir la asignación "+ ex.Message);
            }
        }
        public void llenarTablaAsignacion(List<Asignacion> listaAsignaciones)
        {
            siticoneDataGridView1.Rows.Clear();
            foreach (Asignacion item in listaAsignaciones)
            {
                siticoneDataGridView1.Rows.Add(item.fecha, item.cc, item.nombreSucursal, item.codigoSala);
            }

        }

        public List<Asignacion> buscarAsignacion(string cc)
        {
            var filtroNombreSucursal = siticoneComboBox1.Text;
            if (filtroNombreSucursal.Equals("Ambos"))
                filtroNombreSucursal = "";
            List<Asignacion> resultado = new List<Asignacion>();
            foreach (Asignacion item in AsignacionMapper.ConsultarAsignacion())
            {
                if (siticoneComboBox1.Text.Equals("Ambos"))
                {
                    if (item.cc.Contains(cc))
                    {
                        resultado.Add(item);
                    }
                }
                else
                {
                    if (item.cc.Contains(cc) && item.nombreSucursal.Equals(siticoneComboBox1.Text))
                    {
                        resultado.Add(item);
                    }
                }
            }
            return resultado;

        }

        private void siticoneTextBox7_TextChanged(object sender, EventArgs e)
        {
            llenarTablaAsignacion(buscarAsignacion(siticoneTextBox7.Text));
        }

        private void siticoneDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Asignacion asignacion = new Asignacion(
                    DateTime.Parse(siticoneDataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()),
                    siticoneDataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    siticoneDataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    siticoneDataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString()
                    );
                EditarAsignacion editarAsignacion = new EditarAsignacion(asignacion);
                editarAsignacion.Visible = true;
                editarAsignacion.BringToFront();
            }
            catch { }
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            llenarTablaAsignacion(buscarAsignacion(siticoneTextBox7.Text));
        }

        private void siticoneComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarTablaAsignacion(buscarAsignacion(siticoneTextBox7.Text));
        }
    }
}
