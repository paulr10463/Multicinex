using Multicinex.GUI;
using System.Data;
using System.Data.SqlClient;

namespace Multicinex.Classes
{
    public class EmpleadoInfoMapper
    {
        private static readonly string _connectionString = "Data Source=DESKTOP-GLGPNIG; Initial Catalog= MulticinexSur; User ID=sa; Password=P@ssw0rd;";

        public static List<Empleado> ConsultarEmpleado()
        {
            List<Empleado> empleadosRegistrados = new List<Empleado>();
            SqlConnection connection = new SqlConnection(_connectionString);
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM \"EMPLEADO_INFO_SUR\"", connection);
                SqlDataReader reader = command.ExecuteReader();
                {
                    while (reader.Read())
                    {
                        empleadosRegistrados.Add(new Empleado(reader.GetString(0), reader.GetString(1), reader.GetString(2), null, null ,reader.GetString(3)));
                    }
                }
            }
            return empleadosRegistrados;
        }

        public static void IngresarEmpleado(Empleado empleadoInfo)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();

            using (var cmd = new SqlCommand("INSERT INTO EMPLEADO_INFO_SUR (cc, nombre, apellido, nombre_sucursal) VALUES (@cc, @nombre, @apellido, @nombre_sucursal)", connection))
            {
                cmd.Parameters.AddWithValue("@cc", empleadoInfo.cc);
                cmd.Parameters.AddWithValue("@nombre", empleadoInfo.nombre);
                cmd.Parameters.AddWithValue("@apellido", empleadoInfo.apellido);
                cmd.Parameters.AddWithValue("@nombre_sucursal", empleadoInfo.nombreSucursal);
                cmd.ExecuteNonQuery();
            }
            using (var cmd = new SqlCommand("INSERT INTO EMPLEADO_SUELDO VALUES (@cc,@sueldo, @fecha_contratacion)", connection))
            {
                cmd.Parameters.AddWithValue("@cc", empleadoInfo.cc);
                cmd.Parameters.AddWithValue("@sueldo", empleadoInfo.sueldo);
                cmd.Parameters.AddWithValue("@fecha_contratacion", empleadoInfo.fechaContratacion);
                cmd.ExecuteNonQuery();
            }
        }

        public static async Task<bool> ModificarEmpleadoInfo(Empleado empleadoInfo)
        {
            int result = 0;
            if (empleadoInfo.cc != null && empleadoInfo.nombreSucursal != null)
            {
                await using SqlConnection connection = new SqlConnection(_connectionString);
                connection.Open();
                await using SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE EMPLEADO_INFO_SUR SET nombre = @nombre, apellido = @apellido WHERE NOMBRE_SUCURSAL = @nombreSucursal AND CC = @cc";
                command.Parameters.AddWithValue("@nombre", empleadoInfo.nombre);
                command.Parameters.AddWithValue("@apellido", empleadoInfo.apellido);
                command.Parameters.AddWithValue("@nombre_sucursal", empleadoInfo.nombreSucursal);
                command.Parameters.AddWithValue("@cc", empleadoInfo.cc);
                result = await command.ExecuteNonQueryAsync();
            }
            return result > 0;
        }

        public static bool EliminarEmpleadoInfo(string empleadoCC)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();
            using SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM EMPLEADO_INFO_SUR WHERE CC = @cc";
            command.Parameters.AddWithValue("@cc", empleadoCC);
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
