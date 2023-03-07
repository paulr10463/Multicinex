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
                MessageBox.Show("Asignación realizadacon exito");
                vaciarCampos();
                llenarTablaAsignacion(buscarAsignacion(siticoneTextBox7.Text));
            }
            catch
            {
                MessageBox.Show("No se pudo añadir la pelicula");
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
            List<Asignacion> resultado = new List<Asignacion>();
            foreach (Asignacion item in AsignacionMapper.ConsultarAsignacion())
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
            llenarTablaAsignacion(buscarAsignacion(siticoneTextBox7.Text));
        }
    }
}
