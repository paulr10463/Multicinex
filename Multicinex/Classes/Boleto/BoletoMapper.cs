using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multicinex.Classes.Boleto
{
    internal class BoletoMapper
    {
        private static readonly string _connectionString = "Data Source=DESKTOP-GLGPNIG; Initial Catalog= MulticinexSur; User ID=sa; Password=P@ssw0rd;";

        public static List<Boleto> ConsultarBoleto()
        {
            List<Boleto> boletosRegistrados = new List<Boleto>();
            SqlConnection connection = new SqlConnection(_connectionString);
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM V_BOLETO", connection);
                SqlDataReader reader = command.ExecuteReader();
                {
                    while (reader.Read())
                    {
                        boletosRegistrados.Add(new Boleto(reader.GetString(0), reader.GetString(1), reader.GetInt32(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetDateTime(6), reader.GetTimeSpan(7)));
                    }
                }
            }
            return boletosRegistrados; 
        }

        public static List<Boleto> ConsultarBoletoFuncion(string codFuncion)
        {
            List<Boleto> boletosRegistrados = new List<Boleto>();
            SqlConnection connection = new SqlConnection(_connectionString);
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM BOLETO_SUR WHERE CODIGO_FUNCION = '" + codFuncion + "'", connection);
                SqlDataReader reader = command.ExecuteReader();
                {
                    while (reader.Read())
                    {
                        boletosRegistrados.Add(new Boleto(reader.GetString(0), reader.GetString(1), reader.GetInt32(2), reader.GetString(3), reader.GetString(4), reader.GetString(5), reader.GetDateTime(6), reader.GetTimeSpan(7)));
                    }
                }
            }
            return boletosRegistrados;
        }

        public static void IngresarBoleto(Boleto boleto)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();
            new SqlCommand("Set xact_abort on", connection).ExecuteNonQuery();
            using (var cmd = new SqlCommand("INSERT INTO V_BOLETO values (@codigo_boleto, @fila, @columna, @nombre_sucursal, @codigo_sala, @codigo_funcion, @fecha_emision, @hora_emision)", connection))
            {
                cmd.Parameters.AddWithValue("@codigo_boleto", boleto.codigoBoleto);
                cmd.Parameters.AddWithValue("@fila", boleto.fila);
                cmd.Parameters.AddWithValue("@columna", boleto.columna);
                cmd.Parameters.AddWithValue("@nombre_Sucursal", boleto.nombreSucursal);
                cmd.Parameters.AddWithValue("@codigo_sala", boleto.codigoSala);
                cmd.Parameters.AddWithValue("@codigo_funcion", boleto.codigoFuncion);
                cmd.Parameters.AddWithValue("@fecha_emision", boleto.fechaEmision);
                cmd.Parameters.AddWithValue("@hora_emision", boleto.horaEmision);
                cmd.ExecuteNonQuery();
            }
        }

        public static bool ModificarBoleto(Boleto boleto)
        {
            int result = 0;
            if (boleto.codigoBoleto != null && boleto.nombreSucursal != null)
            {
                using SqlConnection connection = new SqlConnection(_connectionString);
                connection.Open();
                new SqlCommand("Set xact_abort on", connection).ExecuteNonQuery();
                using SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE V_BOLETO SET FILA = @fila, COLUMNA = @columna, FECHA_EMISION = @fecha_emision, HORA_EMISION = @hora_emision, CODIGO_SALA = @codigo_sala, CODIGO_FUNCION = @codigo_Funcion WHERE CODIGO_BOLETO = @codigo_Boleto AND NOMBRE_SUCURSAL = @nombre_Sucursal";
                command.Parameters.AddWithValue("@codigo_boleto", boleto.codigoBoleto);
                command.Parameters.AddWithValue("@fila", boleto.fila);
                command.Parameters.AddWithValue("@columna", boleto.columna);
                command.Parameters.AddWithValue("@nombre_Sucursal", boleto.nombreSucursal);
                command.Parameters.AddWithValue("@codigo_sala", boleto.codigoSala);
                command.Parameters.AddWithValue("@codigo_Funcion", boleto.codigoFuncion);
                command.Parameters.AddWithValue("@fecha_emision", boleto.fechaEmision);
                command.Parameters.AddWithValue("@hora_emision", boleto.horaEmision);
                command.ExecuteNonQuery();
            }
            return result > 0;
        }

        public static bool EliminarBoleto(string codigoBoleto)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();
            new SqlCommand("Set xact_abort on", connection).ExecuteNonQuery();
            using SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM V_BOLETO WHERE CODIGO_BOLETO = @codigo_boleto";
            command.Parameters.AddWithValue("@codigo_boleto", codigoBoleto);

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
