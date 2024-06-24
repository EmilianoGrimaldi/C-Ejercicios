using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public static class UsuarioDao
    {
        static string cadenaConexion;
        static SqlCommand comando;
        static SqlConnection conexion;
        const string CODIGO_USUARIO = "CODIGO_USUARIO";
        const string EMAIL = "EMAIL";
        const string USER = "USERNAME";
        const string PASS = "PASSWORD";
        static UsuarioDao()
        {
            cadenaConexion = @"Data Source =.;Database =EJERCICIOS_UTN;Trusted_Connection = True;";
            comando = new SqlCommand();
            conexion = new SqlConnection(cadenaConexion);
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
        }
        public static List<Usuario> Leer()
        {
            List<Usuario> personas = new();

            try
            {
                conexion.Open();
                comando.CommandText = $"SELECT CODIGO_USUARIO, USERNAME FROM USUARIOS";
                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        personas.Add(new(reader[USER].ToString(), Convert.ToInt32(reader[CODIGO_USUARIO])));
                    }
                }

                return personas;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}
