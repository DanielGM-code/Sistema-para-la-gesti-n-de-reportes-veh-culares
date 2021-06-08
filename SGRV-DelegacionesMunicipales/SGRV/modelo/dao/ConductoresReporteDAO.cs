using SGRV.modelo.poco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SGRV.modelo.database;

namespace SGRV.modelo.dao
{
    class ConductoresReporteDAO
    {
        public static List<ConductoresReporte> getAllConductoresReportes()
        {
            List<ConductoresReporte> conductoresReportes = new List<ConductoresReporte>();
            SqlConnection connection = null;
            try
            {
                connection = ConexionBD.getConnection();
                if (connection != null)
                {
                    SqlCommand command;
                    SqlDataReader dataReader;
                    String query = "SELECT * FROM ConductoresReporte";
                    command = new SqlCommand(query, connection);
                    dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        ConductoresReporte conductoresReporte = new ConductoresReporte();
                        conductoresReporte.IdConductoresReporte = (!dataReader.IsDBNull(0)) ? dataReader.GetInt32(0) : 0;
                        conductoresReporte.IdReporte = (!dataReader.IsDBNull(1)) ? dataReader.GetInt32(1) : 0;
                        conductoresReporte.IdConductor = (!dataReader.IsDBNull(2)) ? dataReader.GetInt32(2) : 0;
                        conductoresReportes.Add(conductoresReporte);
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
            return conductoresReportes;
        }

        public static ConductoresReporte getConductoresReporteById(int idConductoresReporte)
        {
            ConductoresReporte conductoresReporte = new ConductoresReporte();
            SqlConnection connection = null;
            try
            {
                connection = ConexionBD.getConnection();
                if (connection != null)
                {
                    SqlCommand command;
                    SqlDataReader dataReader;
                    String query = String.Format("SELECT * FROM ConductoresReporte WHERE idConductoresReporte = {0}", idConductoresReporte);
                    command = new SqlCommand(query, connection);
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        conductoresReporte.IdConductoresReporte = (!dataReader.IsDBNull(0)) ? dataReader.GetInt32(0) : 0;
                        conductoresReporte.IdReporte = (!dataReader.IsDBNull(1)) ? dataReader.GetInt32(1) : 0;
                        conductoresReporte.IdConductor = (!dataReader.IsDBNull(2)) ? dataReader.GetInt32(2) : 0;
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
            return conductoresReporte;
        }

        public static void addConductoresReporte(ConductoresReporte conductoresReporte)
        {
            SqlConnection connection = null;
            try
            {
                connection = ConexionBD.getConnection();
                if (connection != null)
                {
                    SqlCommand command;
                    int idReporte = conductoresReporte.IdReporte;
                    int idConductor = conductoresReporte.IdConductor;
                    String query = String.Format("INSERT INTO ConductoresReporte (idReporte, idConductor) VALUES ('{0}', '{1})", idReporte, idConductor);
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
