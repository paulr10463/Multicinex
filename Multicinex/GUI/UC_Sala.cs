using Multicinex.Classes;
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
    public partial class UC_Sala : UserControl
    {
        List<Sala> salasRegistrados;
        public UC_Sala()
        {
            InitializeComponent();
            salasRegistrados = SalaMapper.ConsultarSala();
            llenarTablaSala(buscarSala(siticoneTextBox7.Text));

        }

        public void llenarTablaSala(List<Sala> listaSala)
        {
            siticoneDataGridView1.Rows.Clear();
            foreach (Sala item in listaSala)
            {
                siticoneDataGridView1.Rows.Add(item.nombreSucursal, item.codigoSala, item.capacidadFilas, item.capacidadColumnas,item.tipo);
            }

        }

        public List<Sala> buscarSala(string  codigoSala)
        {
            var filtroNombreSala = siticoneComboBox1.Text;
            if (filtroNombreSala.Equals("Ambos"))
                filtroNombreSala = "";
            List<Sala> resultado = new List<Sala>();
            foreach (Sala item in SalaMapper.ConsultarSala())
            {
                if (siticoneComboBox1.Text.Equals("Ambos"))
                {
                    if (item.codigoSala.Contains(codigoSala))
                    {
                        resultado.Add(item);
                    }
                }
                else
                {
                    if(item.codigoSala.Contains(codigoSala) && item.nombreSucursal.Equals(siticoneComboBox1.Text))
                    {
                        resultado.Add(item);
                    }
                }
            }
            return resultado;

        }

        private void siticoneTextBox7_TextChanged(object sender, EventArgs e)
        {
            llenarTablaSala(buscarSala(siticoneTextBox7.Text));
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            Sala salaARegistrar = new Sala(
                cbSucursal.Text,
                tbcodigoSala.Text,
                (int)numFila.Value,
                (int)numColumna.Value,
                cbTipo.Text);
            
            try
            {
                SalaMapper.IngresarSala(salaARegistrar);
                MessageBox.Show("Sala añadida con exito");
                vaciarCampos();
                llenarTablaSala(buscarSala(siticoneTextBox7.Text));
            }
            catch
            {
                MessageBox.Show("No se pudo añadir la Sala");
            }

        }

        private void vaciarCampos()
        {
            cbSucursal.Text = string.Empty;
            tbcodigoSala.Text = string.Empty;
            numFila.Value = 0;
            numColumna.Value = 0;
            cbTipo.Text = string.Empty;
        }


        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            llenarTablaSala(buscarSala(siticoneTextBox7.Text));
        }

        private void siticoneComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarTablaSala(buscarSala(siticoneTextBox7.Text));
        }

        private void siticoneDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Sala sala = new Sala(
                    siticoneDataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(),
                    siticoneDataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    Convert.ToInt32(siticoneDataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString()),
                    Convert.ToInt32(siticoneDataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString()),
                    siticoneDataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString()
                    );
                EditarSala editarSala = new EditarSala(sala);
                editarSala.Visible = true;
                editarSala.BringToFront();
            }
            catch { }
        }
    
    }
}
