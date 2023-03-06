using Multicinex.GUI;
using System.Data.SqlClient;

namespace Multicinex.Classes
{
    public class EmpleadoInfoMapper
    {
        private static readonly string _connectionString = "Data Source=DESKTOP-GLGPNIG; Initial Catalog= MulticinexSur; User ID=sa; Password=P@ssw0rd;";

        public static List<EmpleadoInfo> ConsultarEmpleado()
        {
            List<EmpleadoInfo> empleadosRegistrados = new List<EmpleadoInfo>();
            SqlConnection connection = new SqlConnection(_connectionString);
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM \"EMPLEADO_INFO_SUR\"", connection);
                SqlDataReader reader = command.ExecuteReader();
                {
                    while (reader.Read())
                    {
                        empleadosRegistrados.Add(new EmpleadoInfo(reader.GetString(0), reader.GetString(1), reader.GetString(2), null, null ,reader.GetString(3)));
                    }
                }
            }
            return empleadosRegistrados;
        }

    }
}
