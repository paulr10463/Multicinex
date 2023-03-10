using Multicinex.Classes.Boleto;
using Multicinex.Classes.Empleado;
using Siticone.Desktop.UI.WinForms;
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
    public partial class EditarBoleto : Form
    {
        public EditarBoleto(Boleto boleto)
        {
            InitializeComponent();
            tbCodigoBoleto.Text = boleto.codigoBoleto;
            cbSucursal.Text = boleto.nombreSucursal;
            tbcodSala.Text = boleto.codigoSala;
            tbcodFuncion.Text = boleto.codigoFuncion;
            tbFila.Text = boleto.fila;
            tbColumna.Text = boleto.columna.ToString();
            dtHora.Value = DateTime.Parse(boleto.horaEmision.ToString());
            dtFecha.Value = boleto.fechaEmision;

        }

        //Editar boleto
        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            Boleto boletoAEditar = new Boleto(
                tbCodigoBoleto.Text,
                tbFila.Text,
                Convert.ToInt32(tbColumna.Text),
                cbSucursal.Text,
                tbcodSala.Text,
                tbcodFuncion.Text,
                dtFecha.Value,
                dtHora.Value.TimeOfDay);
            try
            {
                BoletoMapper.ModificarBoleto(boletoAEditar);
                MessageBox.Show("Boleto actualizado con exito");
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo modificar el boleto. "+ex.Message);
            }
        }
        //Eliminar boleto
        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            try
            {
                BoletoMapper.EliminarBoleto(tbCodigoBoleto.Text, cbSucursal.Text);
                MessageBox.Show("Boleto eliminado con exito");
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo eliminar el boleto. "+ex.Message);
            }
        }
    }
}
