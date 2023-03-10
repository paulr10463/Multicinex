using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Multicinex.Classes.Conexion;

namespace Multicinex.Classes.Asignacion
{
    internal class AsignacionMapper
    {
        private static readonly string _connectionString = Connection.getConnectionString();

        public static List<Asignacion> ConsultarAsignacion()
        {
            List<Asignacion> asignacionesRegistradas = new List<Asignacion>();
            SqlConnection connection = new SqlConnection(_connectionString);
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM V_ASIGNACION", connection);
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
            using (var cmd = new SqlCommand("INSERT INTO V_ASIGNACION (fecha, cc, nombre_sucursal, codigo_sala) values (@fecha, @cc, @nombre_sucursal, @codigo_sala)", connection))
            {
                cmd.Parameters.AddWithValue("@fecha", asignacion.fecha);
                cmd.Parameters.AddWithValue("@cc", asignacion.cc);
                cmd.Parameters.AddWithValue("@nombre_sucursal", asignacion.nombreSucursal);
                cmd.Parameters.AddWithValue("@codigo_sala", asignacion.codigoSala);
                cmd.ExecuteNonQuery();
            }
        }

        

        public static bool EliminarAsignacion(Asignacion asignacion)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();
            using SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM V_ASIGNACION WHERE NOMBRE_SUCURSAL = @nombre_sucursal AND FECHA = @fecha AND CC = @cc AND CODIGO_SALA = @codigo_sala";
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
