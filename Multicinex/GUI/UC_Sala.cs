using Multicinex.Classes;
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
            llenarTablaSala(salasRegistrados);

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
            List<Sala> resultado = new List<Sala>();
            foreach (Sala item in SalaMapper.ConsultarSala())
            {
                if(item.codigoSala.Contains(codigoSala))
                {
                    resultado.Add(item);
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
                llenarTablaSala(SalaMapper.ConsultarSala());
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

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            try
            {
                SalaMapper.EliminarSala(tbEliminarSala.Text);
                MessageBox.Show("Registro Eliminado con exito");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("No se pudo eliminar el registro: " + ex.Message);
            }

        }
    }
}
