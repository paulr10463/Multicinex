using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multicinex.Classes
{
    
    public class SalaMapper
    {
        private static readonly string _connectionString = "Data Source=DESKTOP-GLGPNIG; Initial Catalog= MulticinexSur; User ID=sa; Password=P@ssw0rd;";
        public static List<Sala> ConsultarSala()
        {
            List<Sala> empleadosRegistrados = new List<Sala>();
            SqlConnection connection = new SqlConnection(_connectionString);
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM SALA_SUR", connection);
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

            using (var cmd = new SqlCommand("INSERT INTO SALA_SUR (nombre_sucursal, codigo_sala, capacidad_filas, capacidad_columnas, tipo) values (@nombre_sucursal, @codigo_sala, @capacidad_filas, @capacidad_columnas, @tipo);", connection))
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

        public static async Task<bool> ModificarSala(Sala sala)
        {
            int result = 0;
            if (sala.codigoSala != null)
            {
                await using SqlConnection connection = new SqlConnection(_connectionString);
                connection.Open();
                await using SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE SALA_SUR SET tipo = @tipo WHERE NOMBRE_SUCURSAL = @nombre_sucursal AND CODIGO_SALA = @codigo_sala";
                command.Parameters.AddWithValue("@tipo", sala.tipo);
                command.Parameters.AddWithValue("@nombre_sucursal", sala.nombreSucursal);
                command.Parameters.AddWithValue("@codigo_sala", sala.codigoSala);
                result = await command.ExecuteNonQueryAsync();
            }
            return result > 0;
        }


        public static bool EliminarSala(string codigoSala)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();
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
