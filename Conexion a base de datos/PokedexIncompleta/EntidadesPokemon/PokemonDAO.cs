using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPokemon
{
    public static class PokemonDAO
    {
        public static class PersonaDAO
        {
            static string connectionString;
            static SqlCommand command;
            static SqlConnection connection;
            static PersonaDAO()
            {
                connectionString = @"Data Source =.;Database=POKEDEX_DataBase;Trusted_Connection=True;";
                command = new SqlCommand();
                connection = new SqlConnection(connectionString);
                command.CommandType = System.Data.CommandType.Text;
                command.Connection = connection;
            }

            public static void Guardar(Pokemon pokemon)
            {
                try
                {
                    command.Parameters.Clear();
                    connection.Open();
                    command.CommandText = $"INSERT POKEMON(ID,NOMBRE,TIPO,ENTRENADOR,URLIMAGEN) VALUES (@id,@nombre,@tipo,@entrenador,@urlImagen)";
                    command.Parameters.AddWithValue("@id", pokemon.Id);
                    command.Parameters.AddWithValue("@nombre", pokemon.Nombre);
                    command.Parameters.AddWithValue("@tipo", pokemon.Tipo);
                    command.Parameters.AddWithValue("@entrenador", pokemon.Entrenador);
                    command.Parameters.AddWithValue("@urlImagen", pokemon.UrlImagen);
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

            public static void Modificar(Pokemon pokemon)
            {
                try
                {
                    command.Parameters.Clear();
                    connection.Open();
                    command.CommandText = $"UPDATE POKEMON SET ID = @id, NOMBRE = @nombre, TIPO = @tipo, ENTRENADOR = @entrenador, URLIMAGEN = @urlImagen WHERE ID = @id";
                    command.Parameters.AddWithValue("@id", pokemon.Id);
                    command.Parameters.AddWithValue("@nombre", pokemon.Nombre);
                    command.Parameters.AddWithValue("@tipo", pokemon.Tipo);
                    command.Parameters.AddWithValue("@entrenador", pokemon.Entrenador);
                    command.Parameters.AddWithValue("@urlImagen", pokemon.UrlImagen);
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
                    command.CommandText = $"DELETE FROM POKEMON WHERE ID = {id}";
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
            public static List<Pokemon> Leer()
            {
                List<Pokemon> pokemones = new();
                try
                {
                    command.Parameters.Clear();
                    connection.Open();
                    command.CommandText = $"SELECT * FROM POKEMON";
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            pokemones.Add(new(Convert.ToInt32(reader["ID"]), reader["NOMBRE"].ToString(), reader["TIPO"].ToString(), reader["ENTRENADOR"].ToString(), reader["URLIMAGEN"].ToString()));
                        }
                    }
                    command.ExecuteNonQuery();
                    return pokemones;
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    connection.Close();
                }

                return pokemones;
            }
            public static Pokemon Leer(int id)
            {
                Pokemon pokemon = null;
                try
                {
                    command.Parameters.Clear();
                    connection.Open();
                    command.CommandText = $"SELECT * FROM POKEMON WHERE ID = {id}";
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            pokemon = (new(Convert.ToInt32(reader["ID"]), reader["NOMBRE"].ToString(), reader["TIPO"].ToString(), reader["ENTRENADOR"].ToString(), reader["URLIMAGEN"].ToString()));
                        }
                    }
                    command.ExecuteNonQuery();
                    return pokemon;
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    connection.Close();
                }

                return pokemon;
            }
        }
    }
}
