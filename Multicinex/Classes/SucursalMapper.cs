﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multicinex.Classes
{
    public class SucursalMapper
    {
        private static readonly string _connectionString = "Data Source=DESKTOP-GLGPNIG; Initial Catalog= MulticinexSur; User ID=sa; Password=P@ssw0rd;";

        public static List<Sucursal> ConsultarSucursal()
        {
            List<Sucursal> sucursalesRegistradas = new List<Sucursal>();
            SqlConnection connection = new SqlConnection(_connectionString);
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM SUCURSAL", connection);
                SqlDataReader reader = command.ExecuteReader();
                {
                    while (reader.Read())
                    {
                        sucursalesRegistradas.Add(new Sucursal(reader.GetString(0), reader.GetString(1), reader.GetString(2)));
                    }
                }
            }
            return sucursalesRegistradas;
        }

        public static async Task<bool> ModificarPelicula(Sucursal sucursal)
        {
            int result = 0;
            if (sucursal.nombreSucursal != null)
            {
                await using SqlConnection connection = new SqlConnection(_connectionString);
                connection.Open();
                await using SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE SUCURSAL SET telefono = @telefono WHERE NOMBRE_SUCURSAL = @nombre_sucursal";
                command.Parameters.AddWithValue("@telefono", sucursal.telefono);
                command.Parameters.AddWithValue("@nombre_sucursal", sucursal.nombreSucursal);
                result = await command.ExecuteNonQueryAsync();
            }
            return result > 0;
        }


    }
}
