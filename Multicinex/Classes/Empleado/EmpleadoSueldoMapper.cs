using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Multicinex.Classes.Conexion;

namespace Multicinex.Classes.Empleado
{
    public class EmpleadoSueldoMapper
    {
        private static readonly string _connectionString = Connection.getConnectionString();

        public static List<EmpleadoSueldo> ConsultarEmpleadoSueldo()
        {
            List<EmpleadoSueldo> empleadoSueldoRegistrados = new List<EmpleadoSueldo>();
            SqlConnection connection = new SqlConnection(_connectionString);
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM EMPLEADO_SUELDO", connection);
                SqlDataReader reader = command.ExecuteReader();
                {
                    while (reader.Read())
                    {
                        empleadoSueldoRegistrados.Add(new EmpleadoSueldo(reader.GetString(0), (double)reader.GetDecimal(1), reader.GetDateTime(2)));
                    }
                }
            }
            return empleadoSueldoRegistrados;
        }



        public static void ingresarEmpleadoSueldo(EmpleadoSueldo empleadoSueldo)
        {
            // Conexión a BD
            using var connection = new SqlConnection(_connectionString);
            connection.Open();

            using (var cmd = new SqlCommand("INSERT INTO EMPLEADO_SUELDO (cc, sueldo, fecha_contratacion) values (@cc, @sueldo, @fecha_contratacion);", connection))
            {
                cmd.Parameters.AddWithValue("@cc", empleadoSueldo.cc);
                cmd.Parameters.AddWithValue("@sueldo", empleadoSueldo.sueldo);
                cmd.Parameters.AddWithValue("@fecha_contratacion", empleadoSueldo.fechaContratacion);
                cmd.ExecuteNonQuery();
            }
        }

        public static bool ModificarEmpleadoSueldo(EmpleadoSueldo empleadoSueldo)
        {
            int result = 0;
            if (empleadoSueldo.cc != null)
            {
                using SqlConnection connection = new SqlConnection(_connectionString);
                connection.Open();
                using SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE EMPLEADO_SUELDO SET sueldo = @sueldo, fecha_contratacion = @fecha_contratacion WHERE CC = @cc";
                command.Parameters.AddWithValue("@cc", empleadoSueldo.cc);
                command.Parameters.AddWithValue("@sueldo", empleadoSueldo.sueldo);
                command.Parameters.AddWithValue("@fecha_contratacion", empleadoSueldo.fechaContratacion);
                result = command.ExecuteNonQuery();
            }
            return result > 0;
        }


        public static bool EliminarEmpleadoSueldo(string cc)
        {
            using var connection = new SqlConnection(_connectionString);
            connection.Open();
            using SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM EMPLEADO_SUELDO WHERE CC = @cc;";
            command.Parameters.AddWithValue("@cc", cc);
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
