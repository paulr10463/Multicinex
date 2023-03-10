
using System.Data.SqlClient;
using Multicinex.Classes.Pelicula;

namespace Multicinex.GUI
{
    public partial class UC_Pelicula : UserControl
    {
        List<Pelicula> peliculasRegistradas;
        public static DataGridView data;
        public UC_Pelicula()
        {
            InitializeComponent();
            peliculasRegistradas = PeliculaMapper.ConsultarPelicula();
            llenarTablaPelicula(peliculasRegistradas);
        }

        private void siticoneButton1_Click(object sender, EventArgs e)
        {
            data = siticoneDataGridView1;
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


        }

        private void siticoneTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            llenarTablaPelicula(buscarPelicula(siticoneTextBox7.Text));
        }

        private void siticoneDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Pelicula peliculaAEditar = new Pelicula(
                    siticoneDataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(),
                    siticoneDataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    Convert.ToInt32(siticoneDataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString()),
                    Convert.ToInt32(siticoneDataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString()),
                    siticoneDataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString(),
                    siticoneDataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString(),
                    siticoneDataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString()
                    );
                Editar_Pelicula editar_Pelicula = new Editar_Pelicula(peliculaAEditar);
                editar_Pelicula.Visible = true;
                editar_Pelicula.BringToFront();
            }
            catch
            {

            }

        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            llenarTablaPelicula(buscarPelicula(siticoneTextBox7.Text));
        }

        public void llenarTablaEstadisticas(List<Pelicula> listaPelicula)
        {
            siticoneDataGridView1.Rows.Clear();
            foreach (Pelicula item in listaPelicula)
            {
                siticoneDataGridView1.Rows.Add(item.codigoPelicula, item.titulo, item.duracion, item.anio, item.nombreDirector, item.apellidoDirector, item.sinopsis);
            }

        }
        private void siticoneButton2_Click_1(object sender, EventArgs e)
        {
            siticoneDataGridView2.Rows.Clear();
            if (cbSucursal.Text=="Quito-Norte")
            {
                foreach (Estadisticas item in EstadisticasMapper.ConsultarEstadisticasNorte())
                {
                    siticoneDataGridView2.Rows.Add(item.nombrePelicula, item.cantidadBoletos);
                }
            }
            else
            {
                foreach (Estadisticas item in EstadisticasMapper.ConsultarEstadisticasSur())
                {
                    siticoneDataGridView2.Rows.Add(item.nombrePelicula, item.cantidadBoletos);
                }
            }

        }

        private void siticoneHtmlLabel8_Click(object sender, EventArgs e)
        {

        }
    }
}

