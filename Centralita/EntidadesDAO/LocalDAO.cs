using EntidadesCentralita;
using System.Data;
using System.Data.SqlClient;

namespace EntidadesDAO
{
    public static class LocalDAO
    {
        static string stringConexion;
        static SqlCommand comando;
        static SqlConnection conexion;

        static LocalDAO()
        {
            stringConexion = @"Server=.;Database=CENTRALITA;Trusted_Connection=True;";
            comando = new SqlCommand();
            conexion = new SqlConnection(stringConexion);
            comando.CommandType = CommandType.Text;
            comando.Connection = conexion;
        }

        public static void Guardar(Local llamada)
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
                comando.Parameters.AddWithValue("@tipo", 1);
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

        public static List<Local> Leer()
        {
            List<Local> llamadas = new();
            try
            {
                conexion.Open();
                comando.CommandText = @"SELECT DURACION,ORIGEN,DESTINO,COSTO FROM LLAMADAS WHERE TIPO = 1";
                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    llamadas.Add(new Local(reader["ORIGEN"].ToString(),Convert.ToInt32(reader["DURACION"]), reader["DESTINO"].ToString(), (float)reader["COSTO"]));
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
