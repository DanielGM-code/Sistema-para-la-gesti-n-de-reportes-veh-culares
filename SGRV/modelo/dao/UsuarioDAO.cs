using SGRV.modelo.database;
using SGRV.modelo.poco;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SGRV.modelo.dao
{
    class UsuarioDAO
    {
        public static List<Usuario> getAllUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();
            SqlConnection connection = null;
            try
            {
                connection = ConexionBD.getConnection();
                if (connection != null)
                {
                    SqlCommand command;
                    SqlDataReader dataReader;
                    String query = "SELECT U.idUsuario, U.username, U.contraseña, U.cargo, U.idDelegacion, U.estado, D.nombre " +
                                   "FROM Usuario U INNER JOIN Delegacion D ON U.idDelegacion = D.idDelegacion WHERE U.estado = 'Activo'";
                    command = new SqlCommand(query, connection);
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Usuario usuario = new Usuario();
                        usuario.IdUsuario = (!dataReader.IsDBNull(0)) ? dataReader.GetInt32(0) : 0;
                        usuario.Username = (!dataReader.IsDBNull(1)) ? dataReader.GetString(1) : "";
                        usuario.Contraseña = (!dataReader.IsDBNull(2)) ? dataReader.GetString(2) : "";
                        usuario.Cargo = (!dataReader.IsDBNull(3)) ? dataReader.GetString(3) : "";
                        usuario.IdDelegacion = (!dataReader.IsDBNull(4)) ? dataReader.GetInt32(4) : 0;
                        usuario.Estado = (!dataReader.IsDBNull(5)) ? dataReader.GetString(5) : "";
                        usuario.Delegacion = (!dataReader.IsDBNull(6)) ? dataReader.GetString(6) : "";
                        usuarios.Add(usuario);
                    }
                    dataReader.Close();
                    command.Dispose();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            finally
            {
                connection.Close();
            }
            return usuarios;
        }

        public static Usuario getUsuarioById(int idUsuario)
        {
            Usuario usuario = new Usuario();
            SqlConnection connection = null;
            try
            {
                connection = ConexionBD.getConnection();
                if (connection != null)
                {
                    SqlCommand command;
                    SqlDataReader dataReader;
                    String query = String.Format("SELECT U.idUsuario, U.username, U.contraseña, U.cargo, U.idDelegacion, U.estado, D.nombre " +
                                                 "FROM Usuario U INNER JOIN Delegacion D ON U.idDelegacion = D.idDelegacion " +
                                                 "WHERE idUsuario = {0}", idUsuario);
                    command = new SqlCommand(query, connection);
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        usuario.IdUsuario = (!dataReader.IsDBNull(0)) ? dataReader.GetInt32(0) : 0;
                        usuario.Username = (!dataReader.IsDBNull(1)) ? dataReader.GetString(1) : "";
                        usuario.Contraseña = (!dataReader.IsDBNull(2)) ? dataReader.GetString(2) : "";
                        usuario.Cargo = (!dataReader.IsDBNull(3)) ? dataReader.GetString(3) : "";
                        usuario.IdDelegacion = (!dataReader.IsDBNull(4)) ? dataReader.GetInt32(4) : 0;
                        usuario.Estado = (!dataReader.IsDBNull(5)) ? dataReader.GetString(5) : "";
                        usuario.Delegacion = (!dataReader.IsDBNull(6)) ? dataReader.GetString(6) : "";
                    }
                    dataReader.Close();
                    command.Dispose();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            finally
            {
                connection.Close();
            }
            return usuario;
        }

        public static Usuario getUsuarioByUsername(String username)
        {
            Usuario usuario = new Usuario();
            SqlConnection connection = null;
            try
            {
                connection = ConexionBD.getConnection();
                if (connection != null)
                {
                    SqlCommand command;
                    SqlDataReader dataReader;
                    String query = String.Format("SELECT U.idUsuario, U.username, U.contraseña, U.cargo, U.idDelegacion, U.estado, D.nombre " +
                                                 "FROM Usuario U INNER JOIN Delegacion D ON U.idDelegacion = D.idDelegacion " +  
                                                 "WHERE username = '{0}' AND U.estado = 'Activo'", username);
                    command = new SqlCommand(query, connection);
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        usuario.IdUsuario = (!dataReader.IsDBNull(0)) ? dataReader.GetInt32(0) : 0;
                        usuario.Username = (!dataReader.IsDBNull(1)) ? dataReader.GetString(1) : "";
                        usuario.Contraseña = (!dataReader.IsDBNull(2)) ? dataReader.GetString(2) : "";
                        usuario.Cargo = (!dataReader.IsDBNull(3)) ? dataReader.GetString(3) : "";
                        usuario.IdDelegacion = (!dataReader.IsDBNull(4)) ? dataReader.GetInt32(4) : 0;
                        usuario.Estado = (!dataReader.IsDBNull(5)) ? dataReader.GetString(5) : "";
                        usuario.Delegacion = (!dataReader.IsDBNull(6)) ? dataReader.GetString(6) : "";
                    }
                    dataReader.Close();
                    command.Dispose();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            finally
            {
                connection.Close();
            }
            return usuario;
        }

        public static void addUsuario(Usuario usuario)
        {
            SqlConnection connection = null;
            try
            {
                connection = ConexionBD.getConnection();
                if (connection != null)
                {
                    SqlCommand command;
                    String username = usuario.Username;
                    String contraseña = usuario.Contraseña;
                    String cargo = usuario.Cargo;
                    int idDelegacion = usuario.IdDelegacion;
                    String estado = usuario.Estado;
                    String query = String.Format("INSERT INTO Usuario (username, contraseña, cargo, idDelegacion, estado) " +
                                                 "VALUES ('{0}','{1}','{2}','{3}','{4}')", username, contraseña, cargo,
                                                 idDelegacion, estado);
                    command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    command.Dispose();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            finally
            {
                connection.Close();
            }
        }

        public static void removeUsuario(Usuario usuario)
        {
            SqlConnection connection = null;
            try
            {
                connection = ConexionBD.getConnection();
                if (connection != null)
                {
                    SqlCommand command;
                    int idUsuario = usuario.IdUsuario;
                    String query = String.Format("UPDATE Usuario SET estado = 'Eliminado' WHERE idUsuario = {0}", idUsuario);
                    command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    command.Dispose();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
