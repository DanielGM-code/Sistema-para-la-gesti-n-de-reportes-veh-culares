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
    class VehiculosReporteDAO
    {
        public static List<VehiculosReporte> getAllVehiculosReporte()
        {
            List<VehiculosReporte> vehiculosReportes = new List<VehiculosReporte>();
            SqlConnection connection = null;
            try
            {
                connection = ConexionBD.getConnection();
                if (connection != null)
                {
                    SqlCommand command;
                    SqlDataReader dataReader;
                    String query = "SELECT * FROM VehiculosReporte";
                    command = new SqlCommand(query, connection);
                    dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        VehiculosReporte vehiculosReporte = new VehiculosReporte();
                        vehiculosReporte.IdVehiculosReporte = (!dataReader.IsDBNull(0)) ? dataReader.GetInt32(0) : 0;
                        vehiculosReporte.IdReporte = (!dataReader.IsDBNull(1)) ? dataReader.GetInt32(1) : 0;
                        vehiculosReporte.IdVehiculo = (!dataReader.IsDBNull(2)) ? dataReader.GetInt32(2) : 0;
                        vehiculosReportes.Add(vehiculosReporte);
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
            return vehiculosReportes;
        }

        public static VehiculosReporte getVehiculosReporteById(int idVehiculosReporte)
        {
            VehiculosReporte vehiculosReporte = new VehiculosReporte();
            SqlConnection connection = null;
            try
            {
                connection = ConexionBD.getConnection();
                if (connection != null)
                {
                    SqlCommand command;
                    SqlDataReader dataReader;
                    String query = String.Format("SELECT * FROM VehiculosReporte WHERE idVehiculosReporte = {0}", idVehiculosReporte);
                    command = new SqlCommand(query, connection);
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        vehiculosReporte.IdVehiculosReporte = (!dataReader.IsDBNull(0)) ? dataReader.GetInt32(0) : 0;
                        vehiculosReporte.IdReporte = (!dataReader.IsDBNull(1)) ? dataReader.GetInt32(1) : 0;
                        vehiculosReporte.IdVehiculo = (!dataReader.IsDBNull(2)) ? dataReader.GetInt32(2) : 0;
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
            return vehiculosReporte;
        }

        public static void addVehiculosReporte(VehiculosReporte vehiculosReporte)
        {
            SqlConnection connection = null;
            try
            {
                connection = ConexionBD.getConnection();
                if (connection != null)
                {
                    SqlCommand command;
                    int idReporte = vehiculosReporte.IdReporte;
                    int idVehiculo = vehiculosReporte.IdVehiculo;
                    String query = String.Format("INSERT INTO VehiculosReporte (idReporte, idVehiculo) VALUES ('{0}', '{1})", idReporte, idVehiculo);
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
