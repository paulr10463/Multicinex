using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multicinex.Classes
{
    public class EmpleadoSueldoMapper
    {
        private static readonly string _connectionString = "Data Source=DESKTOP-GLGPNIG; Initial Catalog= MulticinexSur; User ID=sa; Password=P@ssw0rd;";

        public static List<EmpleadoSueldo> ConsultarEmpleado()
        {
            List<EmpleadoSueldo> sueldosEmpleadosRegistrados = new List<EmpleadoSueldo>();
            SqlConnection connection = new SqlConnection(_connectionString);
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM EMPLEADO_SUELDO", connection);
                SqlDataReader reader = command.ExecuteReader();
                {
                    while (reader.Read())
                    {
                        sueldosEmpleadosRegistrados.Add(new EmpleadoSueldo(reader.GetString(0), reader.GetDouble(1), reader.GetDateTime(2)));
                    }
                }
            }
            return sueldosEmpleadosRegistrados;
        }

    }
}
