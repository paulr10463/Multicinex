using Multicinex.Classes.Funcion;
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
    public partial class EditarFuncion : Form
    {
        public EditarFuncion(Funcion funcion)
        {
            InitializeComponent();
            tbCodigoPelicula.Text = funcion.codigoPelicula;
            tbcodFuncion.Text = funcion.codigoFuncion;
            cbSucursal.Text = funcion.nombreSucursal;
            tbCodigoSala.Text = funcion.codigoSala;
            dtInicio.Value = funcion.horaInicio;
            dtFin.Value = funcion.horaFin;
            dtDia.Value = funcion.fecha;
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            try
            {
                FuncionMapper.EliminarFuncion(tbcodFuncion.Text, cbSucursal.Text);
                MessageBox.Show("Registro Eliminado con exito");
                this.Dispose();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("No se pudo eliminar el registro: " + ex.Message);
            }
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
                FuncionMapper.ModificarFuncion(funcionARegistrar);
                MessageBox.Show("Funcion añadida con exito");
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo añadir la funcion "+ ex.Message);
            }
        }
    }
}
