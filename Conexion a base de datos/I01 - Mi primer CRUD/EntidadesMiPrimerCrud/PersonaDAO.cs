using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EntidadesMiPrimerCrud
{
    public static class PersonaDAO
    {
        static string connectionString;
        static SqlCommand command;
        static SqlConnection connection;
        static PersonaDAO()
        {
            connectionString = @"Data Source =.;Database=Ejercicio01;Trusted_Connection=True;";
            command = new SqlCommand();
            connection = new SqlConnection(connectionString);
            command.CommandType = System.Data.CommandType.Text;
            command.Connection = connection;
        }

        public static void Guardar(Persona persona)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"INSERT PERSONA(NOMBRE,APELLIDO) VALUES (@nombre,@apellido)";
                command.Parameters.AddWithValue("@nombre",persona.Nombre);
                command.Parameters.AddWithValue("@apellido",persona.Apellido);
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

        public static void Modificar(Persona persona)
        {
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"UPDATE PERSONA SET NOMBRE = @nombre, APELLIDO = @apellido WHERE ID = {persona.Id}";
                command.Parameters.AddWithValue("@nombre", persona.Nombre);
                command.Parameters.AddWithValue("@apellido", persona.Apellido);
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
                command.CommandText = $"DELETE FROM PERSONA WHERE ID = {id}";
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
        public static List<Persona> Leer()
        {
            List<Persona> personas = new List<Persona>();
            try
            {
                command.Parameters.Clear();     
                connection.Open();
                command.CommandText = $"SELECT * FROM PERSONA";
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        personas.Add(new(Convert.ToInt32(reader["ID"]), reader["NOMBRE"].ToString(), reader["APELLIDO"].ToString()));
                    }
                }       
                command.ExecuteNonQuery();
                return personas;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }

            return personas;
        }
        public static Persona Leer(int id)
        {
            Persona persona = null;
            try
            {
                command.Parameters.Clear();
                connection.Open();
                command.CommandText = $"SELECT * FROM PERSONA WHERE ID = {id}";
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        persona = (new(Convert.ToInt32(reader["ID"]), reader["NOMBRE"].ToString(), reader["APELLIDO"].ToString()));
                    }
                }
                command.ExecuteNonQuery();
                return persona;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                connection.Close();
            }

            return persona;
        }
    }
}
