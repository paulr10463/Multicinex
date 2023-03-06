using Multicinex.Classes;
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
    public partial class UC_Sala : UserControl
    {
        List<Sala> salasRegistrados;
        public UC_Sala()
        {
            InitializeComponent();
            salasRegistrados = SalaMapper.ConsultarSala();
            llenarTablaSala(salasRegistrados);

        }

        public void llenarTablaSala(List<Sala> listaSala)
        {
            siticoneDataGridView1.Rows.Clear();
            foreach (Sala item in listaSala)
            {
                siticoneDataGridView1.Rows.Add(item.nombreSucursal, item.codigoSala, item.capacidadFilas, item.capacidadColumnas,item.tipo);
            }

        }

        public List<Sala> buscarSala(string  codigoSala)
        {
            List<Sala> resultado = new List<Sala>();
            foreach (Sala item in SalaMapper.ConsultarSala())
            {
                if(item.codigoSala.Contains(codigoSala))
                {
                    resultado.Add(item);
                }
            }
            return resultado;

        }

        private void siticoneTextBox7_TextChanged(object sender, EventArgs e)
        {
            llenarTablaSala(buscarSala(siticoneTextBox7.Text));
        }
    }
}
