using Multicinex.Classes;
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
    
    public partial class UC_Boleto : UserControl
    {
        public  Sala salaSeleccionada;
        public  List<Sala> listaSalas;
        private System.Data.DataSet dataSet;
        public UC_Boleto()
        {
            InitializeComponent();
            MakeParentTable();
        }
        private void MakeParentTable()
        {
             
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            siticoneDataGridView1.Columns.Clear();
            listaSalas = SalaMapper.ConsultarSala();
            foreach (Sala item in listaSalas)
            {
                if (siticoneTextBox1.Text.Equals(item.codigoSala))
                    salaSeleccionada = item;
            }
            int filas = salaSeleccionada.capacidadFilas;
            int columnas = salaSeleccionada.capacidadColumnas;
            List<DataGridViewButtonColumn> listaColumnas = new List<DataGridViewButtonColumn>();
            for (int i = 0; i < columnas; i++)
            {
                listaColumnas.Add(new DataGridViewButtonColumn());
            }
            this.siticoneDataGridView1.Columns.AddRange(listaColumnas.ToArray());
            // Create a new DataTable.
            DataTable table = new DataTable("ParentTable");
            // Declare variables for DataColumn and DataRow objects.
            DataColumn column;
            DataRow row;

            // Create three new DataRow objects and add
            // them to the DataTable
            for (int i = 1; i < filas; i++)
            {
                row = table.NewRow();
                table.Rows.Add(row);
            }
            siticoneDataGridView1.DataSource = table;
        }

    }
}
