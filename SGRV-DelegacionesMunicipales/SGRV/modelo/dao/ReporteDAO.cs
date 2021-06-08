using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SGRV.modelo.poco;
using System.Data.SqlClient;
using SGRV.modelo.database;

namespace SGRV.modelo.dao
{
    class ReporteDAO
    { 
        public static List<Reporte> getAllReportes()
        {
            List<Reporte> reportes = new List<Reporte>();
            SqlConnection connection = null;
            try
            {
                connection = ConexionBD.getConnection();
                if(connection != null)
                {
                    SqlCommand command;
                    SqlDataReader dataReader;
                    String query = "SELECT * FROM Reporte";
                    command = new SqlCommand(query, connection);
                    dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        Reporte reporte = new Reporte();
                        reporte.IdReporte = (!dataReader.IsDBNull(0)) ? dataReader.GetInt32(0) : 0;
                        reporte.Fecha = (!dataReader.IsDBNull(1)) ? dataReader.GetDateTime(1) : new DateTime();
                        reporte.Direccion = (!dataReader.IsDBNull(2)) ? dataReader.GetString(2) : "";
                        reporte.Descripcion = (!dataReader.IsDBNull(3)) ? dataReader.GetString(3) : "";
                        reporte.Estado = (!dataReader.IsDBNull(4)) ? dataReader.GetString(4) : "";
                        reporte.IdAgenteDeTransito = (!dataReader.IsDBNull(5)) ? dataReader.GetInt32(5) : 0;
                        reportes.Add(reporte);
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
            return reportes;
        }

        public static Reporte getReporteById(int idReporte)
        {
            Reporte reporte = new Reporte();
            SqlConnection connection = null;
            try
            {
                connection = ConexionBD.getConnection();
                if(connection != null)
                {
                    SqlCommand command;
                    SqlDataReader dataReader;
                    String query = String.Format("SELECT * FROM Reporte WHERE idReporte = {0}", idReporte);
                    command = new SqlCommand(query, connection);
                    dataReader = command.ExecuteReader();
                    while (dataReader.Read())
                    {
                        reporte.IdReporte = (!dataReader.IsDBNull(0)) ? dataReader.GetInt32(0) : 0;
                        reporte.Fecha = (!dataReader.IsDBNull(1)) ? dataReader.GetDateTime(1) : new DateTime();
                        reporte.Direccion = (!dataReader.IsDBNull(2)) ? dataReader.GetString(2) : "";
                        reporte.Descripcion = (!dataReader.IsDBNull(3)) ? dataReader.GetString(3) : "";
                        reporte.Estado = (!dataReader.IsDBNull(4)) ? dataReader.GetString(4) : "";
                        reporte.IdAgenteDeTransito = (!dataReader.IsDBNull(5)) ? dataReader.GetInt32(5) : 0;
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
            return reporte;
        }

        public static void addReporte(Reporte reporte)
        {
            SqlConnection connection = null;
            try
            {
                connection = ConexionBD.getConnection();
                if(connection != null)
                {
                    SqlCommand command;
                    DateTime fecha = reporte.Fecha;
                    String direccion = reporte.Direccion;
                    String descripcion = reporte.Descripcion;
                    String estado = reporte.Estado;
                    String query = String.Format("INSERT INTO Reporte (fecha, direccion, descripcion, estado) VALUES ('{0}','{1}','{2}', '{3})", fecha, direccion, descripcion, estado);
                    command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
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
        }

        public static void removeReporte(Reporte reporte)
        {
            SqlConnection connection = null;
            try
            {
                connection = ConexionBD.getConnection();
                if(connection != null)
                {
                    SqlCommand command;
                    int idReprte = reporte.IdReporte;
                    String query = String.Format("UPDATE Reporte SET estado = 'Eliminado' WHERE idAdministrativo = {0}", idReprte);
                    command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
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
        }
    }
}
