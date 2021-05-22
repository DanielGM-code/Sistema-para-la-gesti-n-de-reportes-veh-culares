using SGRV.modelo.database;
using SGRV.modelo.poco;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SGRV.modelo.dao
{
    class AdministrativoDAO
    {
        public static List<Administrativo> getAllAdministrativos()
        {
            List<Administrativo> administrativos = new List<Administrativo>();
            SqlConnection connection = null;
            try
            {
                connection = ConexionBD.getConnection();
                if(connection != null)
                {
                    SqlCommand command;
                    SqlDataReader dataReader;
                    String query = "SELECT * FROM Administrativo";
                    command = new SqlCommand(query, connection);
                    dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        Administrativo administrativo = new Administrativo();
                        administrativo.IdAdministrativo = (!dataReader.IsDBNull(0)) ? dataReader.GetInt32(0) : 0;
                        administrativo.Nombre = (!dataReader.IsDBNull(1)) ? dataReader.GetString(1) : "";
                        administrativo.Correo = (!dataReader.IsDBNull(2)) ? dataReader.GetString(2) : "";
                        administrativo.Estado = (!dataReader.IsDBNull(3)) ? dataReader.GetString(3) : "";
                        administrativos.Add(administrativo);
                    }
                    dataReader.Close();
                    command.Dispose();
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            finally
            {
                connection.Close();
            }
            return administrativos;
        }

        public static Administrativo getAdministrativoById(int idAdministrativo)
        {
            Administrativo administrativo = new Administrativo();
            SqlConnection connection = null;
            try
            {
                connection = ConexionBD.getConnection();
                if (connection != null)
                {
                    SqlCommand command;
                    SqlDataReader dataReader;
                    String query = String.Format("SELECT * FROM Administrativo WHERE idAdministrativo = {0}", idAdministrativo);
                    command = new SqlCommand(query, connection);
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        administrativo.IdAdministrativo = (!dataReader.IsDBNull(0)) ? dataReader.GetInt32(0) : 0;
                        administrativo.Nombre = (!dataReader.IsDBNull(1)) ? dataReader.GetString(1) : "";
                        administrativo.Correo = (!dataReader.IsDBNull(2)) ? dataReader.GetString(2) : "";
                        administrativo.Estado = (!dataReader.IsDBNull(3)) ? dataReader.GetString(3) : "";
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
            return administrativo;
        }

        public static void addAdministrativo(Administrativo administrativo)
        {
            SqlConnection connection = null;
            try
            {
                connection = ConexionBD.getConnection();
                if (connection != null)
                {
                    SqlCommand command;
                    String nombre = administrativo.Nombre;
                    String correo = administrativo.Correo;
                    String estado = administrativo.Estado;
                    String query = String.Format("INSERT INTO Administrativo (nombre, correo, estado) VALUES ('{0}','{1}','{2}')", nombre, correo, estado);
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

        public static void removeAdministrativo(Administrativo administrativo)
        {
            SqlConnection connection = null;
            try
            {
                connection = ConexionBD.getConnection();
                if (connection != null)
                {
                    SqlCommand command;
                    int idAdministrativo = administrativo.IdAdministrativo;
                    String query = String.Format("UPDATE Administrativo SET estado = 'Eliminado' WHERE idAdministrativo = {0}", idAdministrativo);
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
