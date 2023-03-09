using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Multicinex.Classes.Conexion;

namespace Multicinex.Classes
{
    
    public class SalaMapper
    {
        private static readonly string _connectionString = Connection.getConnectionString();
        public static List<Sala> ConsultarSala()
        {
            List<Sala> empleadosRegistrados = new List<Sala>();
            SqlConnection connection = new SqlConnection(_connectionString);
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM V_SALA", connection);
                SqlDataReader reader = command.ExecuteReader();
                {
                    while (reader.Read())
                    {
                        empleadosRegistrados.Add(new Sala(reader.GetString(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetString(4)));
                    }
                }
            }
            return empleadosRegistrados;
        }

        public static void IngresarSala(Sala sala)
        {
            // Conexión a BD
            using var connection = new SqlConnection(_connectionString);
            connection.Open();
            new SqlCommand("Set xact_abort on", connection).ExecuteNonQuery();
            using (var cmd = new SqlCommand("INSERT INTO V_SALA (nombre_sucursal, codigo_sala, capacidad_filas, capacidad_columnas, tipo) values (@nombre_sucursal, @codigo_sala, @capacidad_filas, @capacidad_columnas, @tipo);", connection))
            {
                //(nombre_sucursal, codigo_sala, capacidad_filas, capacidad_columnas, tipo)
                cmd.Parameters.AddWithValue("@nombre_sucursal", sala.nombreSucursal);
                cmd.Parameters.AddWithValue("@codigo_sala", sala.codigoSala);
                cmd.Parameters.AddWithValue("@capacidad_filas", sala.capacidadFilas);
                cmd.Parameters.AddWithValue("@capacidad_columnas", sala.capacidadColumnas);
                cmd.Parameters.AddWithValue("@tipo", sala.tipo);
                cmd.ExecuteNonQuery();
            }
        }

        public static  bool ModificarSala(Sala sala)
        {
            int result = 0;
            if (sala.codigoSala != null)
            {
                using SqlConnection connection = new SqlConnection(_connectionString);
                connection.Open();
                new SqlCommand("Set xact_abort on", connection).ExecuteNonQuery();
                using SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE V_SALA SET tipo = @tipo, capacidad_filas = @filas, capacidad_columnas=@columnas WHERE NOMBRE_SUCURSAL = @nombre_sucursal AND CODIGO_SALA = @codigo_sala";
                command.Parameters.AddWithValue("@tipo", sala.tipo);
                command.Parameters.AddWithValue("@filas", sala.capacidadFilas);
                command.Parameters.AddWithValue("@columnas", sala.capacidadColumnas);
                command.Parameters.AddWithValue("@nombre_sucursal", sala.nombreSucursal);
                command.Parameters.AddWithValue("@codigo_sala", sala.codigoSala);
                result = command.ExecuteNonQuery();
            }
            return result > 0;
        }


        public static bool EliminarSala(string codigoSala)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();
            new SqlCommand("Set xact_abort on", connection).ExecuteNonQuery();
            using SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM SALA_SUR WHERE NOMBRE_SUCURSAL = @nombre_sucursal";
            command.Parameters.AddWithValue("@codigo_sala", codigoSala);
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
