using Multicinex.Classes;
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
    public partial class EditarSala : Form
    {
        public EditarSala(Sala sala)
        {
            InitializeComponent();
            cbSucursal.Text = sala.nombreSucursal;
            tbcodigoSala.Text = sala.codigoSala;
            numFila.Value = sala.capacidadFilas;
            numColumna.Value = sala.capacidadColumnas;
            cbTipo.Text = sala.tipo;
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
                SalaMapper.ModificarSala(salaARegistrar);
                MessageBox.Show("Sala modificada con exito");
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo modificar la Sala " + ex.Message);
            }
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            try
            {
                SalaMapper.EliminarSala(tbcodigoSala.Text,cbSucursal.Text);
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
