
using System.Data.SqlClient;
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
            try
            {
                PeliculaMapper.IngresarPelicula(pelicula);
                MessageBox.Show("Película añadida con exito");
                vaciarCampos();
                llenarTablaPelicula(PeliculaMapper.ConsultarPelicula());
            }
            catch
            {
                MessageBox.Show("No se pudo añadir la pelicula");
            }
            
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

        //Eliminar Pelicula
        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            try
            {
                 PeliculaMapper.EliminarPelicula(siticoneTextBox6.Text);
                 MessageBox.Show("Registro Eliminado con exito");
            }
            catch(SqlException ex)
            {
                MessageBox.Show("No se pudo eliminar el registro: " + ex.Message);
            }

        }

        private void siticoneTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarTablaPelicula(buscarPelicula(siticoneTextBox7.Text));
        }

        private void siticoneDataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        { 
            
        }

        private void siticoneDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            Pelicula peliculaAEditar = new Pelicula(
                siticoneDataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(),
                siticoneDataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(),
                Convert.ToInt32(siticoneDataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString()),
                Convert.ToInt32(siticoneDataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString()),
                siticoneDataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString(),
                siticoneDataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString(),
                siticoneDataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString()
                );
            Editar_Pelicula editar_Pelicula = new Editar_Pelicula(peliculaAEditar);
            editar_Pelicula.Visible = true;
            editar_Pelicula.BringToFront();

        }
    }
}
    
