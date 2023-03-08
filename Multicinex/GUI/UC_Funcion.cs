using Multicinex.Classes.Empleado;
using Multicinex.Classes.Funcion;
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
    public partial class UC_Funcion : UserControl
    {
        List<Funcion> funcionesRegistradas;
        public UC_Funcion()
        {
            InitializeComponent();
            llenarTablaFuncion(buscarFuncion(tbcodFuncion.Text));
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            Funcion funcionARegistrar = new Funcion(
                tbCodigoPelicula.Text,
                tbcodFuncion.Text,
                cbSucursal.Text,
                tbCodigoSala.Text,
                dtInicio.Value,
                dtFin.Value,
                dtDia.Value
                );
            try
            {
                FuncionMapper.IngresarFuncion(funcionARegistrar);
                MessageBox.Show("Funcion añadida con exito");
                vaciarCampos();
                llenarTablaFuncion(buscarFuncion(tbcodFuncion.Text));
            }
            catch
            {
                MessageBox.Show("No se pudo añadir la pelicula");
            }

        }

        private void vaciarCampos()
        {
            tbCodigoPelicula.Text = string.Empty;
            tbcodFuncion.Text = string.Empty;
            tbCodigoSala.Text = string.Empty;
            dtInicio.Value = DateTime.Now;
            dtFin.Value = DateTime.Now;
            dtDia.Value = DateTime.Now;
        }

        private void tbConsultarFuncion_TextChanged(object sender, EventArgs e)
        {
            llenarTablaFuncion(buscarFuncion(tbConsultarFuncion.Text));
        }
        public void llenarTablaFuncion(List<Funcion> listaFunciones)
        {
            siticoneDataGridView1.Rows.Clear();
            foreach (Funcion item in listaFunciones)
            {
                siticoneDataGridView1.Rows.Add(item.codigoPelicula, item.codigoFuncion, item.nombreSucursal, item.codigoSala, item.horaInicio.TimeOfDay, item.horaFin.TimeOfDay, item.fecha.Date);
            }

        }
        public List<Funcion> buscarFuncion(string codigoFuncion)
        {
            var filtroNombreSucursal = siticoneComboBox1.Text;
            if (filtroNombreSucursal.Equals("Ambos"))
                filtroNombreSucursal = "";
            List<Funcion> resultado = new List<Funcion>();
            foreach (Funcion item in FuncionMapper.ConsultarFuncion())
            {
                if (siticoneComboBox1.Text.Equals("Ambos"))
                {
                    if (item.codigoFuncion.Contains(codigoFuncion))
                    {
                        resultado.Add(item);
                    }
                }
                else
                {
                    if (item.codigoFuncion.Contains(codigoFuncion) && item.nombreSucursal.Equals(siticoneComboBox1.Text))
                    {
                        resultado.Add(item);
                    }
                }
            }
            return resultado;

        }


        private void siticoneDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Funcion funcionAEditar = new Funcion(
                    siticoneDataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(),
                    siticoneDataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    siticoneDataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    siticoneDataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString(),
                    DateTime.Parse(siticoneDataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString()),
                    DateTime.Parse(siticoneDataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString()),
                    DateTime.Parse(siticoneDataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString())
                    );
                EditarFuncion editarFuncion = new EditarFuncion(funcionAEditar);
                editarFuncion.Visible = true;
                editarFuncion.BringToFront();
            }
            catch { }
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            llenarTablaFuncion(buscarFuncion(tbConsultarFuncion.Text));
        }

        private void siticoneComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarTablaFuncion(buscarFuncion(tbConsultarFuncion.Text));
        }
    }
}
