using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesCentralita;

namespace EntidadesDAO
{
    public static class ProvincialDAO
    {
        static string stringConexion;
        static SqlCommand comando;
        static SqlConnection conexion;
        static ProvincialDAO()
        {
            stringConexion = @"Server=.;Database=CENTRALITA;Trusted_Connection=True;";
            comando = new SqlCommand();
            conexion = new SqlConnection(stringConexion);
            comando.CommandType = CommandType.Text;
            comando.Connection = conexion;
        }
        public static void Guardar(Provincial llamada)
        {
            try
            {
                conexion.Open();
                comando.Parameters.Clear();
                comando.CommandText = @"INSERT INTO LLAMADAS(DURACION,ORIGEN,DESTINO,COSTO,TIPO) VALUES (@duracion,@origen,@destino,@costo,@tipo)";
                comando.Parameters.AddWithValue("@duracion", llamada.Duracion);
                comando.Parameters.AddWithValue("@origen", llamada.NroOrigen);
                comando.Parameters.AddWithValue("@destino", llamada.NroDestino);
                comando.Parameters.AddWithValue("@costo", llamada.CostoLlamada);
                comando.Parameters.AddWithValue("@tipo", 0);
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            { 
                conexion.Close(); 
            }    
        }

        public static List<Provincial> Leer()
        {
            List <Provincial> llamadas = new();
            try
            {
                conexion.Open();
                comando.CommandText = @"SELECT DURACION,ORIGEN,DESTINO,COSTO FROM LLAMADAS WHERE TIPO = 0";
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    llamadas.Add(new Provincial(reader["ORIGEN"].ToString(), default, Convert.ToInt32(reader["DURACION"]), reader["DESTINO"].ToString()));
                }
                comando.ExecuteNonQuery();
                return llamadas;
            }
            catch (Exception)
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
