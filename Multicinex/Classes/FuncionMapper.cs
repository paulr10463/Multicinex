﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Multicinex.Classes
{
    internal class FuncionMapper
    {
        private static readonly string _connectionString = "Data Source=DESKTOP-GLGPNIG; Initial Catalog= MulticinexSur; User ID=sa; Password=P@ssw0rd;";

        public static List<Funcion> ConsultarFuncion()
        {
            List<Funcion> funcionesRegistradas = new List<Funcion>();
            SqlConnection connection = new SqlConnection(_connectionString);
            {
                connection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM FUNCION_SUR", connection);
                SqlDataReader reader = command.ExecuteReader();
                {
                    while (reader.Read())
                    {
                        funcionesRegistradas.Add(new Funcion(reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetDateTime(4), reader.GetDateTime(5), reader.GetDateTime(6)));
                    }
                }
            }
            return funcionesRegistradas;
        }

        public static void IngresarFuncion(Funcion funcion)
        {
            SqlConnection connection = new SqlConnection(_connectionString);
            connection.Open();

            using (var cmd = new SqlCommand("INSERT INTO FUNCION_SUR (codigo_pelicula, codigo_funcion, nombre_sucursal, codigo_sala,hora_inicio, hora_fin, fecha) values (@codigo_pelicula, @codigo_funcion, @nombre_sucursal, @codigo_sala, @hora_inicio, @hora_fin, @fecha) ", connection))
            {
                cmd.Parameters.AddWithValue("@codigo_pelicula", funcion.codigoPelicula);
                cmd.Parameters.AddWithValue("@codigo_funcion", funcion.codigoFuncion);
                cmd.Parameters.AddWithValue("@nombre_sucursal", funcion.nombreSucursal);
                cmd.Parameters.AddWithValue("@codigo_sala", funcion.codigoSala);
                cmd.Parameters.AddWithValue("@hora_inicio", funcion.horaInicio);
                cmd.Parameters.AddWithValue("@hora_fin", funcion.horaFin);
                cmd.Parameters.AddWithValue("@fecha", funcion.fecha);
                cmd.ExecuteNonQuery();
            }
        }

        public static async Task<bool> ModificarFuncion(Funcion funcion)
        {
            int result = 0;
            if (funcion.nombreSucursal != null && funcion.codigoFuncion != null)
            {
                await using SqlConnection connection = new SqlConnection(_connectionString);
                connection.Open();
                await using SqlCommand command = connection.CreateCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = "UPDATE FUNCION_SUR SET hora_inicio = @hora_inicio, hora_fin = @hora_fin, fecha = @fecha WHERE NOMBRE_SUCURSAL = @nombre_sucursal AND CODIGO_FUNCION = @codigo_funcion";
                command.Parameters.AddWithValue("@hora_inicio", funcion.horaInicio);
                command.Parameters.AddWithValue("@hora_fin", funcion.horaFin);
                command.Parameters.AddWithValue("@fecha", funcion.fecha);
                command.Parameters.AddWithValue("@nombre_sucursal", funcion.nombreSucursal);
                command.Parameters.AddWithValue("@codigo_funcion", funcion.codigoFuncion);
                result = await command.ExecuteNonQueryAsync();
            }
            return result > 0;
        }

        public static async Task<bool> EliminarFuncion(Funcion funcion)
        {
            await using var connection = new SqlConnection(_connectionString);
            connection.Open();
            await using SqlCommand command = connection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = "DELETE FROM FUNCION_SUR WHERE NOMBRE_SUCURSAL = @nombre_Sucursal AND CODIGO_FUNCION = @codigo_funcion";
            command.Parameters.AddWithValue("@nombre_sucursal", funcion.nombreSucursal);
            command.Parameters.AddWithValue("@codigo_funcion", funcion.codigoFuncion);

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
