using Multicinex.GUI;
using System.Data;
using System.Data.SqlClient;
using Multicinex.Classes.Conexion;

namespace Multicinex.Classes.Empleado
{
    public class EmpleadoInfoMapper
    {
        private static readonly string _connectionString = Connection.getConnectionString();

        public static List<Empleado> ConsultarEmpleado()
        {
            List<Empleado> empleadosRegistrados = new List<Empleado>();
            SqlConnection connection = new SqlConnection(_connectionString);
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM V_EMPLEADO_INFO", connection);
                SqlDataReader reader = command.ExecuteReader();
                {
                    while (reader.Read())
                    {
                        empleadosRegistrados.Add(new Empleado(reader.GetString(0), reader.GetString(1), reader.GetString(2), null, null, reader.GetString(3)));
                    }
                }
            }
            return empleadosRegistrados;
        }

        public static void IngresarEmpleado(Empleado empleadoInfo)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();
            using (var cmd = new SqlCommand("INSERT INTO V_EMPLEADO_INFO (cc, nombre, apellido, nombre_sucursal) VALUES (@cc, @nombre, @apellido, @nombre_sucursal)", connection))
            {
                cmd.Parameters.AddWithValue("@cc", empleadoInfo.cc);
                cmd.Parameters.AddWithValue("@nombre", empleadoInfo.nombre);
                cmd.Parameters.AddWithValue("@apellido", empleadoInfo.apellido);
                cmd.Parameters.AddWithValue("@nombre_sucursal", empleadoInfo.nombreSucursal);
                cmd.ExecuteNonQuery();
            }
            using (var cmd = new SqlCommand("INSERT INTO ["+ Connection.getSurServerName() +"].MulticinexSur.dbo.EMPLEADO_SUELDO VALUES (@cc,@sueldo, @fecha_contratacion)", connection))
            {
                cmd.Parameters.AddWithValue("@cc", empleadoInfo.cc);
                cmd.Parameters.AddWithValue("@sueldo", empleadoInfo.sueldo);
                cmd.Parameters.AddWithValue("@fecha_contratacion", empleadoInfo.fechaContratacion);
                cmd.ExecuteNonQuery();
            }
        }

        public static bool ModificarEmpleadoInfo(Empleado empleadoInfo)
        {
            int result = 0;
            if (empleadoInfo.cc != null && empleadoInfo.nombreSucursal != null)
            {
                using SqlConnection connection = new SqlConnection(_connectionString);
                connection.Open();
                using SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE V_EMPLEADO_INFO SET nombre = @nombre, apellido = @apellido WHERE CC = @cc and NOMBRE_SUCURSAL= @nombreSucursal";
                command.Parameters.AddWithValue("@nombre", empleadoInfo.nombre);
                command.Parameters.AddWithValue("@apellido", empleadoInfo.apellido);
                command.Parameters.AddWithValue("@cc", empleadoInfo.cc);
                command.Parameters.AddWithValue("@nombreSucursal", empleadoInfo.nombreSucursal);
                result =  command.ExecuteNonQuery();
            }
            return result > 0;
        }

        public static bool EliminarEmpleadoInfo(string empleadoCC)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();
            using SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "EXECUTE ["+ Connection.getSurServerName() +"].MulticinexSur.dbo.SPEliminarEmpleado @cc;";
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
