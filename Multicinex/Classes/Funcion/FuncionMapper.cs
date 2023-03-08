using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Multicinex.Classes.Funcion
{
    internal class FuncionMapper
    {
        private static readonly string _connectionString = "Data Source=DESKTOP-GLGPNIG; Initial Catalog= MulticinexSur; User ID=sa; Password=P@ssw0rd;";

        public static List<Funcion> ConsultarFuncion()
        {
            List<Funcion> funcionesRegistradas = new List<Funcion>();
            SqlConnection connection = new SqlConnection(_connectionString);
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM V_FUNCION", connection);
                SqlDataReader reader = command.ExecuteReader();
                {
                    while (reader.Read())
                    {
                        funcionesRegistradas.Add(new Funcion(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetTimeSpan(4), reader.GetTimeSpan(5), reader.GetDateTime(6)));
                    }
                }
            }
            return funcionesRegistradas;
        }

        public static void IngresarFuncion(Funcion funcion)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();
            new SqlCommand("Set xact_abort on", connection).ExecuteNonQuery();
            using (var cmd = new SqlCommand("INSERT INTO V_FUNCION (codigo_pelicula, codigo_funcion, nombre_sucursal, codigo_sala,hora_inicio, hora_fin, fecha) values (@codigo_pelicula, @codigo_funcion, @nombre_sucursal, @codigo_sala, @hora_inicio, @hora_fin, @fecha) ", connection))
            {
                cmd.Parameters.AddWithValue("@codigo_pelicula", funcion.codigoPelicula);
                cmd.Parameters.AddWithValue("@codigo_funcion", funcion.codigoFuncion);
                cmd.Parameters.AddWithValue("@nombre_sucursal", funcion.nombreSucursal);
                cmd.Parameters.AddWithValue("@codigo_sala", funcion.codigoSala);
                cmd.Parameters.AddWithValue("@hora_inicio", funcion.horaInicio);
                cmd.Parameters.AddWithValue("@hora_fin", funcion.horaFin);
                cmd.Parameters.AddWithValue("@fecha", funcion.fecha);
                cmd.ExecuteNonQuery();
            }
        }

        public static bool ModificarFuncion(Funcion funcion)
        {
            int result = 0;
            if (funcion.nombreSucursal != null && funcion.codigoFuncion != null)
            {
                using SqlConnection connection = new SqlConnection(_connectionString);
                connection.Open();
                new SqlCommand("Set xact_abort on", connection).ExecuteNonQuery();
                using SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE V_FUNCION SET hora_inicio = @hora_inicio, codigo_pelicula = @codigo_pelicula, codigo_sala = @codigo_sala, hora_fin = @hora_fin, fecha = @fecha WHERE NOMBRE_SUCURSAL = @nombre_sucursal AND CODIGO_FUNCION = @codigo_funcion";
                command.Parameters.AddWithValue("@codigo_pelicula", funcion.codigoPelicula);
                command.Parameters.AddWithValue("@codigo_sala", funcion.codigoSala);
                command.Parameters.AddWithValue("@hora_inicio", funcion.horaInicio);
                command.Parameters.AddWithValue("@hora_fin", funcion.horaFin);
                command.Parameters.AddWithValue("@fecha", funcion.fecha);
                command.Parameters.AddWithValue("@nombre_sucursal", funcion.nombreSucursal);
                command.Parameters.AddWithValue("@codigo_funcion", funcion.codigoFuncion);
                result = command.ExecuteNonQuery();
            }
            return result > 0;
        }

        public static bool EliminarFuncion(string codigoFuncion)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();
            using SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM FUNCION_SUR WHERE CODIGO_FUNCION = @codigo_funcion";
            command.Parameters.AddWithValue("@codigo_funcion", codigoFuncion);

            var result = 0;
            try
            {
                result = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
            return result > 0;
        }
    }
}
