using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multicinex.Classes.Butaca
{
    internal class ButacaMapper
    {
        private static readonly string _connectionString = "Data Source=DESKTOP-GLGPNIG; Initial Catalog= MulticinexSur; User ID=sa; Password=P@ssw0rd;";

        public static List<Butaca> ConsultarButaca()
        {
            List<Butaca> butacasRegistradas = new List<Butaca>();
            SqlConnection connection = new SqlConnection(_connectionString);
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM BUTACA_SUR;", connection);
                SqlDataReader reader = command.ExecuteReader();
                {
                    while (reader.Read())
                    {
                        butacasRegistradas.Add(new Butaca(reader.GetString(0), reader.GetInt32(1), reader.GetString(2), reader.GetString(3)));
                    }
                }
            }
            return butacasRegistradas;
        }

        public static void IngresarEmpleadoInfo(Butaca butaca)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();

            using (var cmd = new SqlCommand("INSERT INTO BUTACA_SUR (fila, columna, nombre_sucursal, codigo_sala) values (@fila, @columna, @nombre_sucursal, @codigo_sala)", connection))
            {
                cmd.Parameters.AddWithValue("@fila", butaca.fila);
                cmd.Parameters.AddWithValue("@columna", butaca.columna);
                cmd.Parameters.AddWithValue("@nombre_sucursal", butaca.nombreSucursal);
                cmd.Parameters.AddWithValue("@codigo_sala", butaca.codigoSala);
                cmd.ExecuteNonQuery();
            }
        }

        /*public static async Task<bool> ModificarButaca(Butaca butaca, string filaModificar, int columnaModificar)
        {
            int result = 0;
            if (butaca.fila != null && butaca.nombreSucursal != null && butaca.codigoSala != null)
            {
                await using SqlConnection connection = new SqlConnection(_connectionString);
                connection.Open();
                await using SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE BUTACA_SUR SET  FILA = @filaModificar, COLUMNA = @columnaModificar WHERE FILA = @fila AND COLUMNA = @columna AND NOMBRE_SUCURSAL =  @nombre_sucursal, CODIGO_SALA = codigo_sala";
                command.Parameters.AddWithValue("@filaModificar", filaModificar);
                command.Parameters.AddWithValue("@columnaModificar", columnaModificar);
                command.Parameters.AddWithValue("@fila", butaca.fila);
                command.Parameters.AddWithValue("@columna", butaca.columna);
                command.Parameters.AddWithValue("@nombre_sucursal", butaca.nombreSucursal);
                command.Parameters.AddWithValue("@codigo_sala", butaca.codigoSala);
                result = await command.ExecuteNonQueryAsync();
            }
            return result > 0;
        }*/

        public static async Task<bool> EliminarButaca(Butaca butaca)
        {
            await using var connection = new SqlConnection(_connectionString);
            connection.Open();
            await using SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM BUTACA_SUR WHERE FILA = @fila AND COLUMNA = @columna AND NOMBRE_SUCURSAL =  @nombre_sucursal, CODIGO_SALA = @codigo_sala";
            command.Parameters.AddWithValue("@fila", butaca.fila);
            command.Parameters.AddWithValue("@columna", butaca.columna);
            command.Parameters.AddWithValue("@nombre_sucursal", butaca.nombreSucursal);
            command.Parameters.AddWithValue("@codigo_sala", butaca.codigoSala);

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
