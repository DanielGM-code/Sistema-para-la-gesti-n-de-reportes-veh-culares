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
    class SoporteDAO
    {
        public static List<Soporte> getAllSoportes()
        {
            List<Soporte> soportes = new List<Soporte>();
            SqlConnection connection = null;
            try
            {
                connection = ConexionBD.getConnection();
                if (connection != null)
                {
                    SqlCommand command;
                    SqlDataReader dataReader;
                    String query = "SELECT * FROM Soporte";
                    command = new SqlCommand(query, connection);
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Soporte soporte = new Soporte();
                        soporte.IdSoporte = (!dataReader.IsDBNull(0)) ? dataReader.GetInt32(0) : 0;
                        soporte.Nombre = (!dataReader.IsDBNull(1)) ? dataReader.GetString(1) : "";
                        soporte.Correo = (!dataReader.IsDBNull(2)) ? dataReader.GetString(2) : "";
                        soporte.Estado = (!dataReader.IsDBNull(3)) ? dataReader.GetString(3) : "";
                        soportes.Add(soporte);
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
            return soportes;
        }

        public static Soporte getSoporteById(int idSoporte)
        {
            Soporte soporte = new Soporte();
            SqlConnection connection = null;
            try
            {
                connection = ConexionBD.getConnection();
                if (connection != null)
                {
                    SqlCommand command;
                    SqlDataReader dataReader;
                    String query = String.Format("SELECT * FROM Soporte WHERE idSoporte = {0}", idSoporte);
                    command = new SqlCommand(query, connection);
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        soporte.IdSoporte = (!dataReader.IsDBNull(0)) ? dataReader.GetInt32(0) : 0;
                        soporte.Nombre = (!dataReader.IsDBNull(1)) ? dataReader.GetString(1) : "";
                        soporte.Correo = (!dataReader.IsDBNull(2)) ? dataReader.GetString(2) : "";
                        soporte.Estado = (!dataReader.IsDBNull(3)) ? dataReader.GetString(3) : "";
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
            return soporte;
        }

        public static void addSoporte(Soporte soporte)
        {
            SqlConnection connection = null;
            try
            {
                connection = ConexionBD.getConnection();
                if (connection != null)
                {
                    SqlCommand command;
                    String nombre = soporte.Nombre;
                    String correo = soporte.Correo;
                    String estado = soporte.Estado;
                    String query = String.Format("INSERT INTO Soporte (nombre, correo, estado) VALUES ('{0}','{1}','{2}')",
                                                 nombre, correo, estado);
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

        public static void removeSoporte(Soporte soporte)
        {
            SqlConnection connection = null;
            try
            {
                connection = ConexionBD.getConnection();
                if (connection != null)
                {
                    SqlCommand command;
                    int idSoporte = soporte.IdSoporte;
                    String query = String.Format("UPDATE Soporte SET estado ='Eliminado' WHERE idSoporte = {0}", idSoporte);
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
