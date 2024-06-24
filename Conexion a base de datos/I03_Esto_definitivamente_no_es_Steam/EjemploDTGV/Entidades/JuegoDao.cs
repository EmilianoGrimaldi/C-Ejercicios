using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class JuegoDao
    {
        static string cadenaConexion;
        static SqlCommand comando;
        static SqlConnection conexion;
        static JuegoDao()
        {
            cadenaConexion = @"Data Source =.;Database =EJERCICIOS_UTN;Trusted_Connection = True;";
            comando = new SqlCommand();
            conexion = new SqlConnection(cadenaConexion);
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
        }
        public static List<Biblioteca> Leer()
        {
            List<Biblioteca> bibliotecas = new();

            try
            {
                conexion.Open();
                comando.CommandText = $"SELECT USUARIOS.USERNAME, JUEGOS.GENERO, JUEGOS.NOMBRE, JUEGOS.CODIGO_JUEGO  FROM JUEGOS JOIN USUARIOS ON JUEGOS.CODIGO_USUARIO = USUARIOS.CODIGO_USUARIO";
                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        bibliotecas.Add(new(reader["USERNAME"].ToString(), reader["GENERO"].ToString(), reader["NOMBRE"].ToString(), Convert.ToInt32(reader["CODIGO_JUEGO"])));
                    }
                }

                return bibliotecas;
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
        public static Juego LeerPorId(int id)
        {
            Juego juego = null;

            try
            {
                conexion.Open();
                comando.CommandText = $"SELECT * FROM JUEGOS WHERE CODIGO_JUEGO = {id}";
                using (SqlDataReader reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        juego = new(reader["NOMBRE"].ToString(), Convert.ToDouble(reader["PRECIO"]), reader["GENERO"].ToString(), Convert.ToInt32(reader["CODIGO_USUARIO"]), Convert.ToInt32(reader["CODIGO_JUEGO"]));
                    }

                }

                return juego;
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
        public static void Eliminar(int id)
        {
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = $"DELETE FROM JUEGOS WHERE CODIGO_JUEGO = {id}";
                comando.ExecuteNonQuery();
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
        public static void Modificar(Juego juego)
        {
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = $"UPDATE JUEGOS SET NOMBRE = @NombreNuevo, GENERO = @GeneroNuevo, PRECIO = @PrecioNuevo WHERE CODIGO_JUEGO = {juego.CodigoJuego}";
                comando.Parameters.AddWithValue("@NombreNuevo", juego.Nombre);
                comando.Parameters.AddWithValue("@GeneroNuevo", juego.Genero);
                comando.Parameters.AddWithValue("@PrecioNuevo", juego.Precio);
                comando.ExecuteNonQuery();
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
        public static void Guardar(Juego juego)
        {
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = $"INSERT INTO JUEGOS(CODIGO_USUARIO, NOMBRE, PRECIO, GENERO) VALUES(@CodigoUsuario,@Nombre,@Precio,@Genero)";
                comando.Parameters.AddWithValue("@CodigoUsuario", juego.CodigoUsuario);
                comando.Parameters.AddWithValue("@Nombre", juego.Nombre);
                comando.Parameters.AddWithValue("@Precio", juego.Precio);
                comando.Parameters.AddWithValue("@Genero", juego.Genero);
                comando.ExecuteNonQuery();
                
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
