using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Multicinex.Classes.Conexion;

namespace Multicinex.Classes.Pelicula
{
    public class EstadisticasMapper
    {
        private static readonly string _connectionString = Connection.getConnectionString();

        public static List<Estadisticas> ConsultarEstadisticasNorte()
        {
            List<Estadisticas> estadisticas = new List<Estadisticas>();
            SqlConnection connection = new SqlConnection(_connectionString);
            {
                connection.Open();
                new SqlCommand("Set xact_abort on", connection);
                SqlCommand command = new SqlCommand("EXECUTE ["+ Connection.getNorteServerName() +"].MulticinexNorte.dbo.SPBoletosVendidosPorPelicula", connection);
                SqlDataReader reader = command.ExecuteReader();
                {
                    while (reader.Read())
                    {
                        estadisticas.Add(new Estadisticas(reader.GetString(0), reader.GetInt32(1)));
                    }
                }
            }
            return estadisticas;
        }

        public static List<Estadisticas> ConsultarEstadisticasSur()
        {
            List<Estadisticas> estadisticas = new List<Estadisticas>();
            SqlConnection connection = new SqlConnection(_connectionString);
            {
                connection.Open();
                new SqlCommand("Set xact_abort on", connection);
                SqlCommand command = new SqlCommand("EXECUTE [" + Connection.getSurServerName() + "].MulticinexSur.dbo.SPBoletosVendidosPorPelicula", connection);
                SqlDataReader reader = command.ExecuteReader();
                {
                    while (reader.Read())
                    {
                        estadisticas.Add(new Estadisticas(reader.GetString(0), reader.GetInt32(1)));
                    }
                }
            }
            return estadisticas;
        }

    }
}
