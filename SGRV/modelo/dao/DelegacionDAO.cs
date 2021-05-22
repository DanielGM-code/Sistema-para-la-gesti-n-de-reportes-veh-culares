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
    class DelegacionDAO
    {
        public static List<Delegacion> getAllDelegaciones()
        {
            List<Delegacion> delegaciones = new List<Delegacion>();
            SqlConnection connection = null;
            try
            {
                connection = ConexionBD.getConnection();
                if (connection != null)
                {
                    SqlCommand command;
                    SqlDataReader dataReader;
                    String query = "SELECT * FROM Delegacion";
                    command = new SqlCommand(query, connection);
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Delegacion delegacion = new Delegacion();
                        delegacion.IdDelegacion = (!dataReader.IsDBNull(0)) ? dataReader.GetInt32(0) : 0;
                        delegacion.Nombre = (!dataReader.IsDBNull(1)) ? dataReader.GetString(1) : "";
                        delegacion.Direccion = (!dataReader.IsDBNull(2)) ? dataReader.GetString(2) : "";
                        delegacion.CodigoPostal = (!dataReader.IsDBNull(3)) ? dataReader.GetString(3) : "";
                        delegacion.Municipio = (!dataReader.IsDBNull(4)) ? dataReader.GetString(4) : "";
                        delegacion.Telefono = (!dataReader.IsDBNull(5)) ? dataReader.GetString(5) : "";
                        delegacion.Correo = (!dataReader.IsDBNull(6)) ? dataReader.GetString(6) : "";
                        delegacion.Estado = (!dataReader.IsDBNull(7)) ? dataReader.GetString(7) : "";
                        delegaciones.Add(delegacion);
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
            return delegaciones;
        }

        public static Delegacion getDelegacionById(int idDelegacion)
        {
            Delegacion delegacion = new Delegacion();
            SqlConnection connection = null;
            try
            {
                connection = ConexionBD.getConnection();
                if (connection != null)
                {
                    SqlCommand command;
                    SqlDataReader dataReader;
                    String query = String.Format("SELECT * FROM Delegacion WHERE idDelegacion = {0}", idDelegacion);
                    command = new SqlCommand(query, connection);
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        delegacion.IdDelegacion = (!dataReader.IsDBNull(0)) ? dataReader.GetInt32(0) : 0;
                        delegacion.Nombre = (!dataReader.IsDBNull(1)) ? dataReader.GetString(1) : "";
                        delegacion.Direccion = (!dataReader.IsDBNull(2)) ? dataReader.GetString(2) : "";
                        delegacion.CodigoPostal = (!dataReader.IsDBNull(3)) ? dataReader.GetString(3) : "";
                        delegacion.Municipio = (!dataReader.IsDBNull(4)) ? dataReader.GetString(4) : "";
                        delegacion.Telefono = (!dataReader.IsDBNull(5)) ? dataReader.GetString(5) : "";
                        delegacion.Correo = (!dataReader.IsDBNull(6)) ? dataReader.GetString(6) : "";
                        delegacion.Estado = (!dataReader.IsDBNull(7)) ? dataReader.GetString(7) : "";
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
            return delegacion;
        }

        public static void addDelegacion(Delegacion delegacion)
        {
            SqlConnection connection = null;
            try
            {
                connection = ConexionBD.getConnection();
                if (connection != null)
                {
                    SqlCommand command;
                    String nombre = delegacion.Nombre;
                    String direccion = delegacion.Direccion;
                    String codigoPostal = delegacion.CodigoPostal;
                    String municipio = delegacion.Municipio;
                    String telefono = delegacion.Telefono;
                    String correo = delegacion.Correo;
                    String estado = delegacion.Estado;
                    String query = String.Format("INSERT INTO Delegacion (nombre, direccion, codigoPostal," +
                                                " municipio, telefono, correo, estado) VALUES ('{0}','{1}',"+
                                                "'{2}','{3}','{4}','{5}','{6}')", nombre, direccion, codigoPostal,
                                                municipio, telefono, correo, estado);
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

        public static void removeDelegacion(Delegacion delegacion)
        {
            SqlConnection connection = null;
            try
            {
                connection = ConexionBD.getConnection();
                if (connection != null)
                {
                    SqlCommand command;
                    int idDelegacion = delegacion.IdDelegacion;
                    String query = String.Format("UPDATE Delegacion SET estado = 'Eliminado' WHERE idDelegacion = {0}", idDelegacion);
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
