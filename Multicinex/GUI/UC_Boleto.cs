using Multicinex.Classes;
using Siticone.Desktop.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multicinex.GUI
{

    public partial class UC_Boleto : UserControl
    {
        public Boleto boletoAVender;
        public List<Funcion> listaFunciones;
        string filaBoletoVenta = "";
        int columnaBoletoVenta = 0;
        Funcion funcionBoletoVenta;
        Sala salaSeleccionada;
        public UC_Boleto()
        {
            InitializeComponent();

        }

        public Funcion buscarFuncion(string codigoFuncion)
        {
            foreach (Funcion item in FuncionMapper.ConsultarFuncion())
            {
                if (item.codigoFuncion.Equals(codigoFuncion))
                {
                    return item;
                }
            }
            return null;

        }
        public Sala buscarSala(string codigoSala)
        {
            foreach (Sala item in SalaMapper.ConsultarSala())
            {
                if (item.codigoSala.Contains(codigoSala))
                {
                    return item;
                }
            }
            return null;
        }
        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            funcionBoletoVenta = buscarFuncion(tbcodFuncion.Text);
            if (funcionBoletoVenta != null)
            {
                List<Boleto> boletosVendidos = BoletoMapper.ConsultarBoletoFuncion(funcionBoletoVenta.codigoFuncion);
                siticoneDataGridView1.Columns.Clear();
                salaSeleccionada = buscarSala(funcionBoletoVenta.codigoSala);
                if (salaSeleccionada != null)
                {
                    int filas = salaSeleccionada.capacidadFilas;
                    int columnas = salaSeleccionada.capacidadColumnas;
                    List<DataGridViewButtonColumn> listaColumnas = new List<DataGridViewButtonColumn>();
                    for (int i = 0; i < columnas; i++)
                    {
                        //Asiento Ocupado
                        this.siticoneDataGridView1.Columns.Add(new DataGridViewButtonColumn());
                        //Asiento Libre    
                        //this.siticoneDataGridView1.Columns.Add(new DataGridViewTextBoxColumn());
                    }
                    
                    // Create a new DataTable.
                    DataTable table = new DataTable("ParentTable");
                    // Declare variables for DataColumn and DataRow objects.
                    DataColumn column;
                    DataRow row;


                    for (int i = 1; i < filas; i++)
                    {
                        row = table.NewRow();
                        table.Rows.Add(row);
                    }
                    siticoneDataGridView1.DataSource = table;

                    foreach (Boleto boleto in boletosVendidos)
                    {
                        int fila = Convert.ToInt32(boleto.fila.ToCharArray()[0]) - 96;
                        int columna= boleto.columna-1;
                        siticoneDataGridView1.Rows[fila].Cells[columna].Value = "Ocupado";
                    }            
                }
            }       
        }

        private void siticoneDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LabelFila.Text = "Fila = " + Convert.ToChar(e.RowIndex+97);
            filaBoletoVenta = Convert.ToChar(e.RowIndex + 97).ToString();
            columnaBoletoVenta = e.ColumnIndex + 1;
            LabelColumna.Text = "Columna = " + columnaBoletoVenta;
        }

        private void Añadir_Click(object sender, EventArgs e)
        {

        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            Boleto boletoVenta = new Boleto(
                tbCodigoBoleto.Text,
                filaBoletoVenta,
                columnaBoletoVenta,
                cbSucursal.Text,
                salaSeleccionada.codigoSala,
                funcionBoletoVenta.codigoFuncion,
                DateTime.Now,
                DateTime.Now.TimeOfDay);
            try
            {
                BoletoMapper.IngresarBoleto(boletoVenta);
                MessageBox.Show(boletoVenta.ToString());
                vaciarCampos();

                //llenarTablaBoleto(PeliculaMapper.ConsultarPelicula());
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo añadir la pelicula" + ex.Message);
            }
            
        }

        private void vaciarCampos()
        {
            tbCodigoBoleto.Text = "";
            filaBoletoVenta = "";
            columnaBoletoVenta = 0;
            salaSeleccionada = null;
            funcionBoletoVenta = null;
            siticoneDataGridView1.Columns.Clear();
        }
    }
}
