using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Multicinex.Classes;

namespace Multicinex.GUI
{
    public partial class UC_Pelicula : UserControl
    {
        List<Pelicula> peliculasRegistradas;
        public UC_Pelicula()
        {
            InitializeComponent();
            peliculasRegistradas = PeliculaMapper.ConsultarPelicula();
            llenarTablaPelicula(peliculasRegistradas);
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            Pelicula pelicula = new Pelicula(
                tbcodPelicula.Text,
                tbTitulo.Text,
                Convert.ToInt32(tbDuracion.Text),
                Convert.ToInt32(tbAnio.Text),
                rtbSinopsis.Text,
                tbNombreD.Text,
                tbApellido.Text
                );
            PeliculaMapper.ingresarPelicula( pelicula );
            vaciarCampos();
        }

        private void vaciarCampos()
        {
            tbcodPelicula.Text = string.Empty;
            tbTitulo.Text = string.Empty;
            tbDuracion.Text = string.Empty;
            tbAnio.Text = string.Empty;
            rtbSinopsis.Text = string.Empty;
            tbNombreD.Text = string.Empty;
            tbApellido.Text = string.Empty;
        }

        private void siticoneTextBox7_TextChanged(object sender, EventArgs e)
        {
            llenarTablaPelicula(buscarPelicula(siticoneTextBox7.Text));
        }

        public void llenarTablaPelicula(List<Pelicula> listaPelicula)
        {
            siticoneDataGridView1.Rows.Clear();
            foreach (Pelicula item in listaPelicula)
            {
                siticoneDataGridView1.Rows.Add(item.codigoPelicula, item.titulo, item.duracion, item.anio, item.nombreDirector, item.apellidoDirector, item.sinopsis);
            }

        }

        public List<Pelicula> buscarPelicula(string codigoPelicula)
        {
            List<Pelicula> resultado = new List<Pelicula>();
            foreach (Pelicula item in PeliculaMapper.ConsultarPelicula())
            {
                if (item.codigoPelicula.Contains(codigoPelicula))
                {
                    resultado.Add(item);
                }
            }
            return resultado;

        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            if (PeliculaMapper.EliminarPelicula(siticoneTextBox6.Text))
            {
                MessageBox.Show("Registro Eliminado con exito");
            }
            else
            {
                MessageBox.Show("No se encontró el registro");
            }
        }

        private void siticoneTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarTablaPelicula(buscarPelicula(siticoneTextBox7.Text));
        }
    }
}
