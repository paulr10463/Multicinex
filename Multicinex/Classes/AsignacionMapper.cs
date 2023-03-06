using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multicinex.Classes
{
    internal class AsignacionMapper
    {
        private static readonly string _connectionString = "Data Source=DESKTOP-GLGPNIG; Initial Catalog= MulticinexSur; User ID=sa; Password=P@ssw0rd;";

        public static List<Asignacion> ConsultarAsignacion()
        {
            List<Asignacion> asignacionesRegistradas = new List<Asignacion>();
            SqlConnection connection = new SqlConnection(_connectionString);
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM ASIGNACION_SUR", connection);
                SqlDataReader reader = command.ExecuteReader();
                {
                    while (reader.Read())
                    {
                        asignacionesRegistradas.Add(new Asignacion(reader.GetDateTime(0), reader.GetString(1), reader.GetString(2), reader.GetString(3)));
                    }
                }
            }
            return asignacionesRegistradas;
        }

        public static void IngresarAsignacion(Asignacion asignacion)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();

            using (var cmd = new SqlCommand("INSERT INTO ASIGNACION_SUR (fecha, cc, nombre_sucursal, codigo_sala) values (@fecha, @cc, @nombre_sucursal, @codigo_sala)", connection))
            {
                cmd.Parameters.AddWithValue("@fecha", asignacion.fecha);
                cmd.Parameters.AddWithValue("@cc", asignacion.cc);
                cmd.Parameters.AddWithValue("@nombre_sucursal", asignacion.nombreSucursal);
                cmd.Parameters.AddWithValue("@codigo_sala", asignacion.codigoSala);
                cmd.ExecuteNonQuery();
            }
        }

        public static async Task<bool> ModificarAsignacino(Asignacion asignacion, DateTime fechaModificar)
        {
            int result = 0;
            if (asignacion.cc != null && asignacion.nombreSucursal != null && asignacion.codigoSala != null)
            {
                await using SqlConnection connection = new SqlConnection(_connectionString);
                connection.Open();
                await using SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE ASIGNACION_SUR SET fecha = @fechaModificar WHERE NOMBRE_SUCURSAL = @nombre_sucursal AND FECHA = @fecha AND CC = @cc AND CODIGO_SALA = @codigo_sala";
                command.Parameters.AddWithValue("@fechaModificar", fechaModificar);
                command.Parameters.AddWithValue("@nombre_sucursal", asignacion.nombreSucursal);
                command.Parameters.AddWithValue("@fecha", asignacion.fecha);
                command.Parameters.AddWithValue("@cc", asignacion.cc);
                command.Parameters.AddWithValue("@codigo_sala", asignacion.codigoSala);
                result = await command.ExecuteNonQueryAsync();
            }
            return result > 0;
        }

        public static async Task<bool> EliminarAsignacion(Asignacion asignacion)
        {
            await using var connection = new SqlConnection(_connectionString);
            connection.Open();
            await using SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM ASIGNACION_SUR WHERE NOMBRE_SUCURSAL = @nombre_sucursal AND FECHA = @fecha AND CC = @cc AND CODIGO_SALA = @codigo_sala";
            command.Parameters.AddWithValue("@nombre_sucursal", asignacion.nombreSucursal);
            command.Parameters.AddWithValue("@fecha", asignacion.fecha);
            command.Parameters.AddWithValue("@cc", asignacion.cc);
            command.Parameters.AddWithValue("@codigo_sala", asignacion.codigoSala);

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
