using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class PersonaDAO // objeto de acceso de datos
    {
        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;
        const string NOMBRE_TABLA = "NOMBRE";
        const string ID_TABLA = "ID";
        static PersonaDAO()
        {
            connectionString = @"Data Source =.;Database =PRUEBA;Trusted_Connection = True;";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }

        public static PersonaDTO Leer (int id)
        {
            PersonaDTO persona = null;

            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"SELECT * FROM Persona WHERE ID = @ID";
                command.Parameters.AddWithValue("@ID",id);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        persona = new(reader[NOMBRE_TABLA].ToString(), Convert.ToInt32(reader[ID_TABLA]));
                    }
                }

                return persona;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
        public static List<PersonaDTO> Leer()
        {
            List<PersonaDTO> personas = new();

            try
            {
                connection.Open();
                command.CommandText = $"SELECT * FROM Persona";     
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        personas.Add(new(reader[NOMBRE_TABLA].ToString(),Convert.ToInt32(reader[ID_TABLA])));
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
                connection.Close();
            }
        }
        public static void Eliminar(int id)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"DELETE FROM Persona WHERE ID = @ID";
                command.Parameters.AddWithValue("@ID", id);
                int rown = command.ExecuteNonQuery();
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

        public static void Agregar(string nombre)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"INSERT INTO Persona(NOMBRE) VALUES (@Nombre)";
                command.Parameters.AddWithValue("@Nombre", nombre);
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
        public static void Modificar(string nuevoNombre, int id)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"UPDATE Persona SET NOMBRE = @Nombre WHERE ID = @ID";
                command.Parameters.AddWithValue("@Nombre", nuevoNombre);
                command.Parameters.AddWithValue("@ID", id);
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
    }
}
