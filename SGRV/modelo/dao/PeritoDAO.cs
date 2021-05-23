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
    class PeritoDAO
    {
        public static List<Perito> getAllPeritos()
        {
            List<Perito> peritos = new List<Perito>();
            SqlConnection connection = null;
            try
            {
                connection = ConexionBD.getConnection();
                if (connection != null)
                {
                    SqlCommand command;
                    SqlDataReader dataReader;
                    String query = "SELECT * FROM Perito";
                    command = new SqlCommand(query, connection);
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        Perito perito = new Perito();
                        perito.IdPerito = (!dataReader.IsDBNull(0)) ? dataReader.GetInt32(0) : 0;
                        perito.Nombre = (!dataReader.IsDBNull(1)) ? dataReader.GetString(1) : "";
                        perito.Correo = (!dataReader.IsDBNull(2)) ? dataReader.GetString(2) : "";
                        perito.Estado = (!dataReader.IsDBNull(3)) ? dataReader.GetString(2) : "";
                        peritos.Add(perito);
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
            return peritos;
        }

        public static Perito getPeritoById(int idPerito)
        {
            Perito perito = new Perito();
            SqlConnection connection = null;
            try
            {
                connection = ConexionBD.getConnection();
                if (connection != null)
                {
                    SqlCommand command;
                    SqlDataReader dataReader;
                    String query = String.Format("SELECT * FROM Perito WHERE idPerito = {0}", idPerito);
                    command = new SqlCommand(query, connection);
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        perito.IdPerito = (!dataReader.IsDBNull(0)) ? dataReader.GetInt32(0) : 0;
                        perito.Nombre = (!dataReader.IsDBNull(1)) ? dataReader.GetString(1) : "";
                        perito.Correo = (!dataReader.IsDBNull(2)) ? dataReader.GetString(2) : "";
                        perito.Estado = (!dataReader.IsDBNull(3)) ? dataReader.GetString(2) : "";
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
            return perito;
        }

        public static void addPerito(Perito perito)
        {
            SqlConnection connection = null;
            try
            {
                connection = ConexionBD.getConnection();
                if (connection != null)
                {
                    SqlCommand command;
                    String nombre = perito.Nombre;
                    String correo = perito.Correo;
                    String estado = perito.Estado;
                    String query = String.Format("INSERT INTO Perito (nombre, correo, estado) VALUES ('{0}', '{1}', '{2}')",
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

        public static void removePerito(Perito perito)
        {
            SqlConnection connection = null;
            try
            {
                connection = ConexionBD.getConnection();
                if (connection != null)
                {
                    SqlCommand command;
                    int idPerito = perito.IdPerito;
                    String query = String.Format("UPDATE Perito SET estado = 'Eliminado' WHERE idPerito = {0}", idPerito);
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
