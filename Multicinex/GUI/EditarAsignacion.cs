using Multicinex.Classes.Asignacion;
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
    public partial class EditarAsignacion : Form
    {
        public static Asignacion asignacionAHacer;
        public EditarAsignacion(Asignacion asignacion)
        {
            InitializeComponent();
            dtAsignacion.Value = asignacion.fecha;
            tbCC.Text = asignacion.cc;
            cbSucursal.Text = asignacion.nombreSucursal;
            tbCodigoSala.Text = asignacion.codigoSala;
            asignacionAHacer = asignacion;
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            try
            {
                AsignacionMapper.EliminarAsignacion(asignacionAHacer);
                MessageBox.Show("Asignacion Eliminada con exito");
                this.Dispose();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("No se pudo eliminar la Asignacion: " + ex.Message);
            }
        }
    }
}
