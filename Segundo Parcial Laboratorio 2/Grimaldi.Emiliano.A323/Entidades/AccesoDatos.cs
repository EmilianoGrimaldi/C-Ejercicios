using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class AccesoDatos
    {
        static SqlCommand comando;
        static SqlConnection conexion;

        static AccesoDatos()
        {
            conexion = new SqlConnection("Server=.;Database=20240701-SP;Trusted_Connection=True;");
            comando = new SqlCommand();
        }

        public static void ActualizarSerie(Serie item)
        {
            try
            {
                conexion.Open();
                comando = conexion.CreateCommand();
                comando.CommandText = @"UPDATE dbo.series SET alumno = @alumno WHERE genero = @genero AND nombre = @nombre";
                comando.Parameters.AddWithValue("@genero", item.Genero);
                comando.Parameters.AddWithValue("@nombre", item.Nombre);
                comando.Parameters.AddWithValue("@alumno", "Grimaldi Emiliano");
                comando.ExecuteNonQuery();              
                comando.Parameters.Clear();
            }
            catch (Exception ex)
            {
                Logger.Log(ex.Message);
            }
            finally 
            { 
                conexion.Close(); 
            }
        }

        public static List<Serie> ObtenerBacklog()
        {
            List<Serie> series = new();
            try
            {
                conexion.Open();
                comando = conexion.CreateCommand();
                comando.CommandText = @"SELECT * FROM dbo.series";
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    string nombre = reader["nombre"].ToString();
                    string genero = reader["genero"].ToString();
                    series.Add(new(genero,nombre));                      
                }
                comando.ExecuteNonQuery();
                
                return series;
            }
            catch (Exception ex)
            {
                Logger.Log(ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            return series;
        }
    }
}
