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
    class AgenteDeTransitoDAO
    {
        public static List<AgenteDeTransito> getAllAgentesDeTransito()
        {
            List<AgenteDeTransito> agentesDeTransito = new List<AgenteDeTransito>();
            SqlConnection connection = null;
            try
            {
                connection = ConexionBD.getConnection();
                if (connection != null)
                {
                    SqlCommand command;
                    SqlDataReader dataReader;
                    String query = "SELECT * FROM AgenteDeTransito";
                    command = new SqlCommand(query, connection);
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        AgenteDeTransito agenteDeTransito = new AgenteDeTransito();
                        agenteDeTransito.IdAgenteDeTransito = (!dataReader.IsDBNull(0)) ? dataReader.GetInt32(0) : 0;
                        agenteDeTransito.Nombre = (!dataReader.IsDBNull(1)) ? dataReader.GetString(1) : "";
                        agenteDeTransito.Correo = (!dataReader.IsDBNull(2)) ? dataReader.GetString(2) : "";
                        agenteDeTransito.Estado = (!dataReader.IsDBNull(3)) ? dataReader.GetString(3) : "";
                        agentesDeTransito.Add(agenteDeTransito);
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
            return agentesDeTransito;
        }

        public static AgenteDeTransito getAgenteDeTransitoById(int idAgenteDeTransito)
        {
            AgenteDeTransito agenteDeTransito = new AgenteDeTransito();
            SqlConnection connection = null;
            try
            {
                connection = ConexionBD.getConnection();
                if (connection != null)
                {
                    SqlCommand command;
                    SqlDataReader dataReader;
                    String query = String.Format("SELECT * FROM AgenteDeTransito WHERE idAgenteDeTransito = {0}", idAgenteDeTransito);
                    command = new SqlCommand(query, connection);
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        agenteDeTransito.IdAgenteDeTransito = (!dataReader.IsDBNull(0)) ? dataReader.GetInt32(0) : 0;
                        agenteDeTransito.Nombre = (!dataReader.IsDBNull(1)) ? dataReader.GetString(1) : "";
                        agenteDeTransito.Correo = (!dataReader.IsDBNull(2)) ? dataReader.GetString(2) : "";
                        agenteDeTransito.Estado = (!dataReader.IsDBNull(3)) ? dataReader.GetString(3) : "";
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
            return agenteDeTransito;
        }

        public static void addAgenteDeTransito(AgenteDeTransito agenteDeTransito)
        {
            SqlConnection connection = null;
            try
            {
                connection = ConexionBD.getConnection();
                if (connection != null)
                {
                    SqlCommand command;
                    String nombre = agenteDeTransito.Nombre;
                    String correo = agenteDeTransito.Correo;
                    String estado = agenteDeTransito.Estado;
                    String query = String.Format("INSERT INTO AgenteDeTransito (nombre, correo, estado) " +
                                                 "VALUES ('{0}','{1}','{2}')", nombre, correo, estado);
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

        public static void removeAgenteDeTransito(AgenteDeTransito agenteDeTransito)
        {
            SqlConnection connection = null;
            try
            {
                connection = ConexionBD.getConnection();
                if (connection != null)
                {
                    SqlCommand command;
                    int idAgenteDeTransito = agenteDeTransito.IdAgenteDeTransito;
                    String query = String.Format("UPDATE AgenteDeTransito SET estado = 'Eliminado' WHERE idAgenteDeTransito = {0}", idAgenteDeTransito);
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
