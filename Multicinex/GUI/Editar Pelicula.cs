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
    public partial class Editar_Pelicula : Form
    {
        public Editar_Pelicula(Pelicula pelicula)
        {
            InitializeComponent();
            tbcodPelicula.Text = pelicula.codigoPelicula.ToString();
            tbTitulo.Text = pelicula.titulo;
            tbDuracion.Text = pelicula.duracion.ToString();
            tbAnio.Text = pelicula.anio.ToString();
            rtbSinopsis.Text = pelicula.sinopsis;
            tbNombreD.Text = pelicula.nombreDirector;
            tbApellido.Text = pelicula.apellidoDirector;
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
            try
            {
                bool result = PeliculaMapper.ModificarPelicula(pelicula);
                if (result)
                {
                    MessageBox.Show("Película actualizada con exito");
                }
                else
                {
                    MessageBox.Show("No se pudo editar la pelicula. Revise los campos");
                }
                MessageBox.Show("Película añadida con exito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo añadir la pelicula" + ex.Message);
            }
        }
    }
}
