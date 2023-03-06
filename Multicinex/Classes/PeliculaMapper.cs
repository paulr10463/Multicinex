using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Multicinex.Classes
{
    public class PeliculaMapper
    {
        private static readonly string _connectionString = "Data Source=DESKTOP-GLGPNIG; Initial Catalog= MulticinexSur; User ID=sa; Password=P@ssw0rd;";

        public static List<Pelicula> ConsultarPelicula()
        {
            List<Pelicula> peliculasRegistradas = new List<Pelicula>();
            SqlConnection connection = new SqlConnection(_connectionString);
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM PELICULA", connection);
                SqlDataReader reader = command.ExecuteReader();
                {
                    while (reader.Read())
                    {
                        peliculasRegistradas.Add(new Pelicula(reader.GetString(0), reader.GetString(1), reader.GetInt32(3), reader.GetInt32(4), reader.GetString(5), reader.GetString(6), reader.GetString(7)));
                    }
                }
            }
            return peliculasRegistradas;
        }

        public static void ingresarPelicula(Pelicula pelicula)
        {
            // Conexión a BD
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            using (var cmd = new SqlCommand("INSERT INTO PELICULA (codigo_pelicula, titulo, duracion, anio, sinopsis,nombre_director, apellido_director) VALUES (@codigo_pelicula, @titulo, @duracion, @anio, @sinopsis, @nombre_director, @apellido_director)", connection))
            {
                cmd.Parameters.AddWithValue("@codigo_pelicula", pelicula.codigoPelicula);
                cmd.Parameters.AddWithValue("@titulo", pelicula.titulo);
                cmd.Parameters.AddWithValue("@duracion", pelicula.duracion);
                cmd.Parameters.AddWithValue("@anio", pelicula.anio);
                cmd.Parameters.AddWithValue("@sinopsis", pelicula.sinopsis);
                cmd.Parameters.AddWithValue("@nombre_director", pelicula.nombreDirector);
                cmd.Parameters.AddWithValue("@apellido_director", pelicula.apellidoDirector);
                cmd.ExecuteNonQuery();
            }
        }

        public static async Task<bool> ModificarPelicula(Pelicula pelicula)
        {
            int result = 0;
            if (pelicula.codigoPelicula != null)
            {
                await using SqlConnection connection = new SqlConnection(_connectionString);
                connection.Open();
                await using SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE PELICULA SET titulo = @titulo, duracion = @duracion, anio = @anio, sinopsis = @sinopsis, nombre_director = @nombre_director, apellido_director = @apellido_director WHERE CODIGO_PELICULA = @codigo_pelicula";
                command.Parameters.AddWithValue("@titulo", pelicula.titulo);
                command.Parameters.AddWithValue("@duracion", pelicula.duracion);
                command.Parameters.AddWithValue("@anio", pelicula.anio);
                command.Parameters.AddWithValue("@sinopsis", pelicula.sinopsis);
                command.Parameters.AddWithValue("@nombre_director", pelicula.nombreDirector);
                command.Parameters.AddWithValue("@apellido_director", pelicula.apellidoDirector);
                command.Parameters.AddWithValue("@codigo_pelicula", pelicula.codigoPelicula);
                result = await command.ExecuteNonQueryAsync();
            }
            return result > 0;
        }

        /*
        public static async Task<bool> EliminarCliente(string codigoPelicula)
        {
            await using var connection = new SqlConnection(_connectionString);
            connection.Open();
            await using SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM public.\"CLiente\" WHERE \"cc_Cliente\" = @CC_Cliente;";
            command.Parameters.AddWithValue("@CC_Cliente", codigoPelicula);
            var result = await command.ExecuteNonQueryAsync();
            return result > 0;
        }
        */

    }
}
