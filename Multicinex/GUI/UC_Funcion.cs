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
    public partial class UC_Funcion : UserControl
    {
        List<Funcion> funcionesRegistradas;
        public UC_Funcion()
        {
            InitializeComponent();
            funcionesRegistradas = FuncionMapper.ConsultarFuncion();
            llenarTablaFuncion(funcionesRegistradas);
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
                llenarTablaFuncion(FuncionMapper.ConsultarFuncion());
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
            List<Funcion> resultado = new List<Funcion>();
            foreach (Funcion item in FuncionMapper.ConsultarFuncion())
            {
                if (item.codigoFuncion.Contains(codigoFuncion))
                {
                    resultado.Add(item);
                }
            }
            return resultado;

        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            try
            {
                FuncionMapper.EliminarFuncion(tbEliminarFuncion.Text);
                MessageBox.Show("Registro Eliminado con exito");
                llenarTablaFuncion(FuncionMapper.ConsultarFuncion());
            }
            catch (SqlException ex)
            {
                MessageBox.Show("No se pudo eliminar el registro: " + ex.Message);
            }
        }
    }
}
