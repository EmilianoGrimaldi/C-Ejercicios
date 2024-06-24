using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPokemon
{
    public static class TipoDAO
    {
        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;
        static TipoDAO()
        {
            connectionString = @"Data Source =.;Database=POKEDEX_DataBase;Trusted_Connection=True;";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }

        public static void Guardar(Tipo tipo)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"INSERT TIPOS(IDTIPO,NOMBRE) VALUES (@id,@nombre)";
                command.Parameters.AddWithValue("@id", tipo.Id);
                command.Parameters.AddWithValue("@nombre", tipo.Nombre);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static void Modificar(Tipo tipo)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"UPDATE TIPOS SET IDTIPO = @id, NOMBRE = @nombre WHERE ID = @id";
                command.Parameters.AddWithValue("@id", tipo.Id);
                command.Parameters.AddWithValue("@nombre", tipo.Nombre);
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static void Eliminar(int id)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"DELETE FROM TIPOS WHERE ID = {id}";
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
        public static List<Tipo> Leer()
        {
            List<Tipo> tipos = new();
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"SELECT * FROM TIPOS";
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tipos.Add(new(Convert.ToInt32(reader["IDTIPO"]), reader["NOMBRE"].ToString()));
                    }
                }
                command.ExecuteNonQuery();
                return tipos;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }

            return tipos;
        }
        public static Tipo Leer(int id)
        {
            Tipo tipo = null;
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"SELECT * FROM TIPOS WHERE ID = {id}";
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        tipo = (new(Convert.ToInt32(reader["IDTIPO"]), reader["NOMBRE"].ToString()));
                    }
                }
                command.ExecuteNonQuery();
                return tipo;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }

            return tipo;
        }
    }
}
